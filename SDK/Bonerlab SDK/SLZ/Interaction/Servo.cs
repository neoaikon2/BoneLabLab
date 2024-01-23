using System;
using UnityEngine;

namespace SLZ.Interaction
{
	[Serializable]
	public class Servo : MonoBehaviour
	{
		private enum RotationJointType
		{
			None = 0,
			Revolute = 1,
			ZeroTwist = 2,
			Spherical = 3
		}

		[SerializeField]
		private ConfigurableJoint _joint;

		private Quaternion _initialRotation;

		private Quaternion _toJointSpace;

		private Quaternion _toJointSpaceInv;

		private Quaternion _toJointSpaceFromDefault;

		private RotationJointType _rotationJointType;

		public ConfigurableJoint joint => null;

		public InteractableHost host { get; private set; }

		public Rigidbody rb { get; private set; }

		public JointDrive xDriveBase { get; set; }

		public JointDrive yDriveBase { get; set; }

		public JointDrive zDriveBase { get; set; }

		public JointDrive angularXDriveBase { get; set; }

		public JointDrive angularYZDriveBase { get; set; }

		public JointDrive slerpDriveBase { get; set; }

		public Quaternion initialRotation => default(Quaternion);

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		public virtual void Initiate()
		{
		}

		public float GetTwistInDegrees()
		{
			return 0f;
		}

		public float GetSwingInDegrees()
		{
			return 0f;
		}

		public float GetSwingInDegrees(out Vector2 yPositiveAlignsToSecAxis)
		{
			yPositiveAlignsToSecAxis = default(Vector2);
			return 0f;
		}

		public float GetSwingInLimitPercent(out Vector2 yPositiveAlignsToSecAxis)
		{
			yPositiveAlignsToSecAxis = default(Vector2);
			return 0f;
		}

		public float GetTwistInLimitPercent()
		{
			return 0f;
		}

		public void SetXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetYDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetAngularYZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetSlerpDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		public void SetXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetYDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularXDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetAngularYZDriveBase(float spring, float damper, float maxForce)
		{
		}

		public void SetSlerpDriveBase(float spring, float damper, float maxForce)
		{
		}

		private JointDrive ComputeJointDrive(JointDrive driveBase, float springMult, float damperMult, float maxForceMult)
		{
			return default(JointDrive);
		}

		public void FreeAllConstraints()
		{
		}

		public JointDrive SetJointDrive(float spring, float damper, float maxForce)
		{
			return default(JointDrive);
		}

		public void SetJointLimitsAll(float linearLimit, Vector4 angularLimits)
		{
		}

		public void SetTargetRotationLocal(Quaternion targetLocal)
		{
		}

		public void SetTargetRotationAndAngVelocityLocal(Quaternion targetLocal, float deltaTime)
		{
		}

		public void SetTargetPositionLocal(Vector3 targetLocalPosition, Quaternion targetLocalRotation)
		{
		}
	}
}
