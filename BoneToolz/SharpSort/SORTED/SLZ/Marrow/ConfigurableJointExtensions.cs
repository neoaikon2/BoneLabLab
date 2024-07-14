using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow
{
	public static class ConfigurableJointExtensions
	{
		public static Quaternion GetJointSpace(this ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation)
		{
		}

		public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
		{
		}

		public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
		{
		}

		public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
		{
		}

		public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
		{
		}

		public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation, Quaternion worldToJointSpace)
		{
		}

		private static void SetTargetPositionInternal(ConfigurableJoint joint, Vector3 targetPosition, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
		{
		}

		private static void SetTargetRotationInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
		{
		}

		public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, float deltaTime)
		{
		}

		public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace, float deltaTime)
		{
		}

		private static void SetTargetRotationAndAngVelocityInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space, float deltaTime)
		{
		}

		public static Vector3 CalculateAngVelocity(Quaternion startRotation, Quaternion endRotation, float deltaTime)
		{
			return default(Vector3);
		}

		public static void SetupAsCharacterJoint(this ConfigurableJoint joint)
		{
		}

		public static Vector3 GetAxisInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		public static Vector3 GetSecondaryAxisInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		public static Vector3 GetConnectedAnchorInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		[MethodImpl(256)]
		public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
		{
			return 0f;
		}

		private static float GetTwistInDegreesInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
		{
			return 0f;
		}

		public static float GetTwistInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation)
		{
			return 0f;
		}

		public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, out float yDegrees, out float zDegrees)
		{
			yDegrees = default(float);
			zDegrees = default(float);
			return 0f;
		}

		public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, out float yDegrees, out float zDegrees)
		{
			yDegrees = default(float);
			zDegrees = default(float);
			return 0f;
		}

		public static float GetSwingInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation, out float yPercent, out float zPercent)
		{
			yPercent = default(float);
			zPercent = default(float);
			return 0f;
		}

		private static float GetSwingCosineInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, out Vector2 direction)
		{
			direction = default(Vector2);
			return 0f;
		}
	}
}
