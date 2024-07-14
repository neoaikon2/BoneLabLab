using System;
using System.Collections.Generic;
using SLZ.Marrow.AI;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.Marrow.PuppetMasta
{
	public abstract class BehaviourBaseNav : BehaviourBase, IMarrowEntityCullable
	{
		public enum RoamMode
		{
			ZONE = 0,
			ZONE3D = 1,
			WAYPOINTS = 2,
			LEGACY = 3
		}

		public enum WaypointEvalMode
		{
			LINEAR = 0,
			PING_PONG = 1,
			RANDOM = 2,
			RANDOM_MIN_TIME = 3
		}

		public enum MentalState
		{
			Rest = 0,
			Roam = 1,
			Investigate = 2,
			Agroed = 3,
			Engaged = 4,
			MindControlled = 5
		}

		public enum LocoState
		{
			Standing = 0,
			Walking = 1,
			Fallen = 2,
			GetUp = 3,
			Jumping = 4,
			InAir = 5,
			Grappling = 6
		}

		[Header("Config Section")]
		[FormerlySerializedAs("baseConfig")]
		public BaseEnemyConfig overrideConfig;

		[FormerlySerializedAs("defaultConfig")]
		[SerializeField]
		protected BaseEnemyConfig prefabConfig;

		[Tooltip("The name that will be appended to the config file created from this prefab (ie Behaviour..._[Roam]")]
		public string behaviourConfigSuffix;

		[Tooltip("Location that the prefab config will be placed if generated from this NPC")]
		public string configSavePath;

		[Header("Resting State")]
		[Range(0f, 16f)]
		public float restingRange;

		[HideInInspector]
		public bool freezeWhileResting;

		public bool homeIsPost;

		[Header("Roam State")]
		[Range(1f, 16f)]
		public float activeRange;

		public float roamSpeed;

		public Vector2 roamRange;

		public Vector3 roamRange3D;

		public float roamAngSpeed;

		[Range(0f, 1f)]
		public float roamFrequency;

		public bool roamWanders;

		public Vector3[] waypoints;

		public GameObject[] waypointObjects;

		public int currWaypoint;

		public RoamArea roamArea;

		public List<Vector3> usedWPList;

		public List<Vector3> failedWPList;

		private Vector3 _cachedDestination;

		private bool _isNavAgentStopped;

		public Dictionary<int, float> wpTimeLookup;

		public float wpMinTime;

		public Vector3 ranRoamTarget;

		public Vector3 roamOffset;

		protected float nextRoamTime;

		public float roamWaitDuration;

		public RoamMode roamMode;

		public WaypointEvalMode waypointEvalMode;

		[Range(4f, 16f)]
		[Header("Investigate State")]
		public float investigateRange;

		[EnumFlags]
		[Header("Agro State General")]
		public TriggerRefProxy.NpcType agroOnNpcType;

		public float breakAgroTargetDistance;

		public float breakAgroHomeDistance;

		public float agroedSpeed;

		public float agroedAngSpeed;

		public LayerMask meleeAttackMask;

		public bool enableThrowAttack;

		public bool throwAttackUsesGravity;

		public bool forceAgentPath;

		public float fwdDotThresh;

		public float throwMaxRange;

		public float throwMinRange;

		public float throwCooldown;

		public float throwVelocity;

		public float gunRange;

		public float gunCooldown;

		[Range(0f, 10f)]
		public float accuracy;

		public float reloadTime;

		[Range(1f, 60f)]
		public int clipSize;

		[Range(1f, 20f)]
		public int burstSize;

		public float desiredGunDistance;

		[ColorUsage(true, true)]
		public Color baseColor;

		[ColorUsage(true, true)]
		public Color agroColor;

		public Renderer[] emissionRenderers;

		public bool isSoundAggroWhenInSecondaryZone;

		public MentalState mentalState;

		public bool applyCachedMental;

		public MentalState cachedMentalState;

		public LocoState locoState;

		public float aiTickFreq;

		[SerializeField]
		protected Transform eyeTran;

		public SubBehaviourSensors sensors;

		public SubBehaviourSfx sfx;

		public SubBehaviourHealth health;

		protected NavMeshAgent _navAgent;

		private bool _homeBound;

		public Vector3 homePosition;

		protected MentalState _preAggroState;

		protected bool investIsPosition;

		protected Vector3 _investigateTarget;

		protected Vector3 _targetDirWorld;

		protected Vector3 _targetDirNormalWorld;

		protected float _investigationCooldown;

		protected float _blockCollisionsUntil;

		protected float _lastAiTickTime;

		protected float _lastJumpTime;

		protected float _cooldownLocoSwitch;

		protected float _currentRotVel;

		protected float _currentRotDelta;

		protected float _animatedRotVel;

		protected Vector3 _animatedRoot;

		protected Quaternion _localAnimatedRoot;

		protected bool meleeAttackActive;

		protected bool _forceAiTick;

		protected int emissColor;

		protected int triggerCount;

		protected MaterialPropertyBlock materialPropertyBlock;

		protected VisualDamageController visualDamage;

		protected HashSet<Rigidbody> selfRbs;

		private Vector3 navTarget;

		private Vector3 flatNavTarget;

		public UnityEvent OnDeath;

		public UnityEvent OnDeathStart;

		public Action<BehaviourBaseNav> OnPostReactivate;

		private float _time;

		private float _fixedTime;

		private bool displayNavpath;

		private bool displayCrabCones;

		public float targetDistance { get; protected set; }

		private void OnEnable()
		{
		}

		protected override void OnInitiate()
		{
		}

		public void BlockCollisions(float time)
		{
		}

		private void OnDestroy()
		{
		}

		public void ChangeEmissiveColor(Color color)
		{
		}

		public void ApplyOverrideConfig(BaseEnemyConfig ovrConfig)
		{
		}

		public override void RestorePrefabState()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void Resurrect()
		{
		}

		[ContextMenu("PuppetMasterKill")]
		protected virtual void PuppetMasterKill()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		public void SetRoam(Vector2 roamXz, float speed = 0.8f, float frequency = 0.2f)
		{
		}

		public void SetRoam(Vector3 roamXyz, float speed = 0.8f, bool wanders = false, float frequency = 0.2f)
		{
		}

		public void Investigate(Vector3 target, bool isPosition = false, float investForSeconds = 2f)
		{
		}

		public void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		public void SetTeam(int t)
		{
		}

		public void SetEngaged(TriggerRefProxy engagedTarget)
		{
		}

		public void AddThreat(TriggerRefProxy trp, float threat)
		{
		}

		protected void RoamByMode()
		{
		}

		private int GetNextWaypoint()
		{
			return 0;
		}

		public void SetPath(Vector3 target)
		{
		}

		protected void ProcessTargetRelativePathing(float idealDistance, float nearBuffer, float farBuffer, float orbitMeters = 0f)
		{
		}

		public void SetHomePosition(Vector3 worldPosition, bool goToHome = true, bool homePost = false)
		{
		}

		public void SetHomeIsPost(bool isPost)
		{
		}

		public void ClearPath()
		{
		}

		protected void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		protected void SetNavAgent(float speed, float angSpeed, float accel = 2f, float stopDistance = 1f)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		protected bool CheckTarget()
		{
			return false;
		}

		public virtual void DealMeleeDamage(MuscleCollision m, float impulse)
		{
		}

		protected float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return 0f;
		}

		private static float PredictiveAimWildGuessAtImpactTime()
		{
			return 0f;
		}

		public static bool PredictiveAim(Vector3 muzzlePosition, float projectileSpeed, Vector3 targetPosition, Vector3 targetVelocity, float gravity, out Vector3 projectileVelocity)
		{
			projectileVelocity = default(Vector3);
			return false;
		}

		protected abstract void SwitchMentalState(MentalState mState);

		protected abstract void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false);

		protected virtual void AiUpdate()
		{
		}

		protected virtual void AiTick()
		{
		}

		protected virtual void SetAnimatorVars()
		{
		}

		protected virtual void RestoreFromCrumbleDeath()
		{
		}

		protected virtual void DoCrumbleDeath()
		{
		}

		protected virtual void ResetAnimator()
		{
		}

		protected virtual void AnimRest()
		{
		}

		protected virtual void AnimAwake()
		{
		}

		protected virtual void ReturnToPreAgro()
		{
		}

		public void ClearState()
		{
		}

		public new void OnDrawGizmos()
		{
		}

		protected virtual void DisableNav()
		{
		}

		protected virtual void EnableNav()
		{
		}

		public virtual void OnEntityCull()
		{
		}

		public virtual void OnEntityUncull()
		{
		}
	}
}
