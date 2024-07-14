using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MarrowBehaviour, IPoolable
	{
		[Serializable]
		public enum Mode
		{
			Active = 0,
			Disabled = 1
		}

		public delegate void UpdateDelegate();

		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		public enum State
		{
			Alive = 0,
			Dead = 1,
			Frozen = 2
		}

		[Serializable]
		public struct StateSettings
		{
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			public static StateSettings Default => default(StateSettings);

			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
				this.killDuration = 0f;
				this.deadMuscleWeight = 0f;
				this.deadMuscleDamper = 0f;
				this.maxFreezeSqrVelocity = 0f;
				this.enableAngularLimitsOnKill = false;
				this.enableInternalCollisionsOnKill = false;
			}
		}
		[SerializeField]
		private Poolee _poolee;

		[LargeHeader("Puppet Master")]
		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		public Transform targetRoot;

		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		[LargeHeader("Simulation")]
		public State state;

		private State _initialState;

		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public StateSettings stateSettings;

		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		private Mode _initialMode;

		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetAnimation;

		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		public float mappingWeight;

		[Range(0f, 1f)]
		[Tooltip("The normalized strength of the muscles.")]
		public float muscleWeight;

		[LargeHeader("Joint and Muscle Settings")]
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		public float muscleSpring;

		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[LargeHeader("Individual Muscle Settings")]
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		public Muscle[] muscles;

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnRead;

		public UpdateDelegate OnWrite;

		public UpdateDelegate OnPostLateUpdate;

		public UpdateDelegate OnHierarchyChanged;

		public MuscleDelegate OnMuscleRemoved;

		public bool cullAnimators;

		public Animator[] cullableAnimators;

		private Animator _targetAnimator;

		private Dictionary<int, float> prefabParameters;

		private Dictionary<int, float> cullParameters;

		private int cachedClip;

		[HideInInspector]
		public List<SolverManager> solvers;

		private bool internalCollisionsEnabled;

		private bool angularLimitsEnabled;

		private bool _awakeFailed;

		private bool interpolated;

		private bool freezeFlag;

		private bool hasBeenDespawned;

		private bool hierarchyIsFlat;

		private bool _teleport;

		private float _freezeFlagTime;

		private Vector3 teleportPosition;

		private Quaternion teleportRotation;

		private bool teleportMoveToTarget;

		private float _previousAnimatorSpeed;

		private float _defaultMuscleWeight;

		private float _defaultMuscleSpring;

		private float _defaultMuscleDamper;

		private bool _isFirstInitialize;

		private float _time;

		private float _deltaTime;

		private float _fixedTime;

		private float _lastFixedTime;

		private Mode activeMode;

		private Mode lastMode;

		private float mappingBlend;

		private bool _hasPreKilled;

		private bool _hasPostKilled;

		public UpdateDelegate OnFreeze;

		public UpdateDelegate OnUnfreeze;

		public UpdateDelegate OnDeath;

		public UpdateDelegate OnResurrection;

		private State activeState;

		private State lastState;

		private bool angularLimitsEnabledOnKill;

		private bool internalCollisionsEnabledOnKill;

		private bool animationDisabledbyStates;

		private float aliveToFrozenMinTime;

		private Transform[] targetChildren;

		private Vector3[] targetStoredPositions;

		private Quaternion[] targetStoredRotations;

		private Vector3[] targetSampledPositions;

		private Quaternion[] targetSampledRotations;

		private Quaternion[] _sampledRotations;

		private bool sampleTargetMappedState;

		private bool hasProp;

		public Animator targetAnimator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BehaviourBase[] behaviours { get; private set; }

		public bool isActive => false;

		public bool initiated { get; private set; }

		public bool isBlending => false;

		public bool isSwitchingMode { get; private set; }

		public bool isSwitchingState => false;

		public bool isKilling { get; private set; }

		public bool isAlive => false;

		public bool isFrozen => false;

		public bool isDead => false;

		public static event Action<PuppetMaster> OnDeathStatsEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void ResetStateSettings()
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public static Animator[] FindAllAnimatorsInChildren(GameObject gameObject)
		{
			return null;
		}

		public void OnPoolInitialize()
		{
		}

		public void OnPoolSpawn()
		{
		}

		public void OnPoolDeInitialize()
		{
		}

		private void Awake()
		{
		}

		private void InitParameterDicts()
		{
		}

		public void SetParameters(bool cull = false)
		{
		}

		public void ReadParameters(bool cull = false)
		{
		}

		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		private void Initiate()
		{
		}

		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		private void DeactivateBehaviour(BehaviourBase behaviour)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		public void MoveToTarget()
		{
		}

		private void Read()
		{
		}

		private void VisualizeTargetPose(Color color)
		{
		}

		public void VisualizeHierarchy(Transform t, Color color)
		{
		}

		public void VisualizeHierarchy(Transform t, Color color, float duration)
		{
		}

		private void SetInternalCollisions(bool collide)
		{
		}

		private void SetAngularLimits(bool limited)
		{
		}

		private void ProcessTeleport()
		{
		}

		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		private bool HierarchyIsFlat()
		{
			return false;
		}

		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		private void KillJoint(ConfigurableJoint joint)
		{
		}

		public void DisableImmediately()
		{
		}

		protected virtual void SwitchModes()
		{
		}
		private IEnumerator DisabledToActive()
		{
			return null;
		}
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		private void UpdateInternalCollisions()
		{
		}

		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return false;
		}

		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return 0;
		}

		public int GetMuscleIndex(Transform target)
		{
			return 0;
		}

		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return 0;
		}

		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return 0;
		}

		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		private static void ValidateEntity(MarrowEntity entity)
		{
		}

		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		private void SetUpMuscles(Transform setUpTo)
		{
		}

		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		private void RemoveUnnecessaryBones()
		{
		}

		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return false;
		}

		public void Kill()
		{
		}

		public void Kill(StateSettings stateSettings)
		{
		}

		public void Freeze()
		{
		}

		public void Freeze(StateSettings stateSettings)
		{
		}

		public void Resurrect()
		{
		}

		protected virtual void SwitchStates()
		{
		}
		private IEnumerator PreKill()
		{
			return null;
		}

		private void PostKill()
		{
		}

		private void AliveToDead()
		{
		}

		private void AliveToFrozen()
		{
		}

		private void OnFreezeFlag()
		{
		}

		public void ForceFreezeOnCull()
		{
		}

		private void DeadToAlive()
		{
		}

		private void SetAnimationEnabled(bool to)
		{
		}

		private void DeadToFrozen()
		{
		}

		private void FrozenToAlive()
		{
		}

		private void FrozenToDead()
		{
		}

		public void SetFrozenMinTime(float t)
		{
		}

		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		private bool CanFreeze()
		{
			return false;
		}

		public Quaternion[] StoreTargetState(out Vector3[] positions)
		{
			positions = null;
			return null;
		}

		public void SetTargetState(Vector3[] positions, Quaternion[] rotations)
		{
		}

		public void SampleTargetState()
		{
		}

		public void BlendToSampledState(float weight)
		{
		}

		public void SampleTargetRotations(bool sampleMuscles = false)
		{
		}

		public void UpdateSampledRotation(GameObject refObj, int muscleIdx)
		{
		}

		public void BlendToSampledRotations(float weight, int muscleCount = -1)
		{
		}

		private void UpdateHierarchies()
		{
		}

		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		private void AssignParentAndChildIndexes()
		{
		}

		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		private void AssignKinshipDegrees()
		{
		}

		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return 0;
		}

		public bool IsValid(bool log)
		{
			return false;
		}

		private bool CheckMassVariation(float threshold, bool log)
		{
			return false;
		}

		private bool CheckIfInitiated()
		{
			return false;
		}
	}
}
