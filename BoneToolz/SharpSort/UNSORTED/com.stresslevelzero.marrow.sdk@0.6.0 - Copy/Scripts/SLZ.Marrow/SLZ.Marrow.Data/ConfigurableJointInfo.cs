using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	[Serializable]
	public class ConfigurableJointInfo
	{
		public Quaternion startRotation;

		public Vector3 axis;

		public Vector3 secondaryAxis;

		public Vector3 anchor;

		public Vector3 connectedAnchor;

		public bool autoConfigureConnectedAnchor;

		public float breakForce;

		public float breakTorque;

		public bool enableCollision;

		public bool enablePreprocessing;

		public float massScale;

		public float connectedMassScale;

		public float projectionAngle;

		public float projectionDistance;

		public JointProjectionModeExt projectionModeExt;

		public JointDriveExt slerpDriveExt;

		public JointDriveExt angularYZDriveExt;

		public JointDriveExt angularXDriveExt;

		public RotationDriveMode rotationDriveMode;

		public Vector3 targetAngularVelocity;

		public Quaternion targetRotation;

		public JointDriveExt zDriveExt;

		public JointDriveExt yDriveExt;

		public JointDriveExt xDriveExt;

		public Vector3 targetVelocity;

		public Vector3 targetPosition;

		public SoftJointLimitExt angularZLimitExt;

		public SoftJointLimitExt angularYLimitExt;

		public SoftJointLimitExt highAngularXLimitExt;

		public SoftJointLimitExt lowAngularXLimitExt;

		public SoftJointLimitExt linearLimitExt;

		public SoftJointLimitSpringExt angularYZLimitSpringExt;

		public SoftJointLimitSpringExt angularXLimitSpringExt;

		public SoftJointLimitSpringExt linearLimitSpringExt;

		public ConfigurableJointMotion angularZMotion;

		public ConfigurableJointMotion angularYMotion;

		public ConfigurableJointMotion angularXMotion;

		public ConfigurableJointMotion zMotion;

		public ConfigurableJointMotion yMotion;

		public ConfigurableJointMotion xMotion;

		public bool configuredInWorldSpace;

		public bool swapBodies;

		public void CopyTo(ConfigurableJoint joint)
		{
		}

		public void CopyFrom(ConfigurableJoint joint)
		{
		}

		public Quaternion GetJointSpace()
		{
			return default(Quaternion);
		}
	}
}
