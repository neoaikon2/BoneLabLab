using System;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	[Serializable]
	public class Muscle
	{
		[Serializable]
		public enum Group
		{
			Hips = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Hand = 4,
			Leg = 5,
			Foot = 6,
			Tail = 7,
			Prop = 8
		}

		[Serializable]
		public class Props
		{
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			[Range(0f, 1f)]
			[Tooltip("The muscle strength (multiplier).")]
			public float muscleWeight;

			[Range(0f, 1f)]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			public float muscleDamper;

			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			public int[] ignoredMuscleIndexs;

			public Props()
			{
			}

			public Props(float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float muscleWeightMlp;

			public float muscleDamperMlp;

			public float maxForceMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public static State Default => default(State);
		}

		[HideInInspector]
		public string name;

		public Transform target;

		public Props props;

		public State state;

		[HideInInspector]
		public int[] parentIndexes;

		[HideInInspector]
		public int[] childIndexes;

		[HideInInspector]
		public bool[] childFlags;

		[HideInInspector]
		public int[] kinshipDegrees;

		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[HideInInspector]
		public Vector3 positionOffset;

		[HideInInspector]
		public Vector3 mappedVelocity;

		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		private Vector3 _defaultConnectedAnchor;

		public MarrowJoint marrowJoint;

		public MarrowBody marrowBody;

		private Quaternion _lastTargetAnimRotation;

		private Quaternion _targetAnimRotation;

		private JointDrive slerpDrive;

		private float _lastSlerpSpring;

		private float _lastSlerpDamper;

		private float _lastSlerpMaxF;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion toParentSpace;

		private Quaternion targetAnimatedRotation;

		private Quaternion rotationRelativeToTarget;

		private Quaternion defaultTargetLocalRotation;

		private Quaternion lastMappedRotation;

		private Transform targetParent;

		private Transform connectedBodyTransform;

		private ConfigurableJointMotion angularXMotionDefault;

		private ConfigurableJointMotion angularYMotionDefault;

		private ConfigurableJointMotion angularZMotionDefault;

		private bool directTargetParent;

		private bool initiated;

		private float _maxForce;

		private Collider[] _colliders;

		private float lastWriteTime;

		private bool[] disabledColliders;

		public Transform transform { get; private set; }

		public Transform connectedBodyTarget { get; private set; }

		public Vector3 targetAnimatedPosition { get; private set; }

		public Collider[] colliders => null;

		public Quaternion targetRotationRelative { get; private set; }

		private Quaternion ParentRotation => default(Quaternion);

		private Quaternion targetParentRotation => default(Quaternion);

		private Quaternion targetLocalRotation => default(Quaternion);

		public bool IsValid(bool log)
		{
			return false;
		}

		public void Rebuild()
		{
		}

		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		public void UpdateColliders()
		{
		}

		public void DisableColliders()
		{
		}

		public void EnableColliders()
		{
		}

		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		public void IgnoreAngularLimits(bool ignore)
		{
		}

		public void FixTargetTransforms()
		{
		}

		public void FullDeath(float muscleWeight, float muscleDamper, float deadMuscleWeight)
		{
		}

		public void MoveToTarget()
		{
		}

		public void Read()
		{
		}

		public void ClearVelocities()
		{
		}

		public void UpdateAnchor()
		{
		}

		public virtual void Update(float muscleWeightMaster, float muscleSpring, float muscleDamper, bool fixedRan, float deltaTime)
		{
		}

		public virtual void FixedUpdate(float t)
		{
		}

		public void Map(float mappingWeightMaster)
		{
		}

		public void CalculateMappedVelocity()
		{
		}

		private void MusclePdController(bool fixedRan, float deltaTime)
		{
		}

		private void MusclePdDrive(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}
	}
}
