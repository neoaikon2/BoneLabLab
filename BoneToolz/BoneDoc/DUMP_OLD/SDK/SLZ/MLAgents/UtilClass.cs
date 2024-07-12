using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MLAgents
{
	public static class UtilClass
	{
		public static float WrapAngle(float angle)
		{
			return default(float);
		}

		public static List<int> GetShuffledList<T>(int length, bool ignore_first_last)
		{
			return null;
		}

		public static IList<T> Randomize<T>(IList<T> pList)
		{
			return null;
		}

		public static float Sigmoid(float val, float scale = 1f)
		{
			return default(float);
		}

		public static Vector3 Sigmoid(Vector3 v3, float scale = 1f)
		{
			return default(Vector3);
		}

		public static float DrivingSignedEulerVal(float val)
		{
			return default(float);
		}

		public static float ParkingSignedEulerVal(float val)
		{
			return default(float);
		}

		public static float MinMaxNorm(float x, float min, float max)
		{
			return default(float);
		}

		public static float MinMaxPolarNorm(float x, float min, float max)
		{
			return default(float);
		}

		public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
		{
		}

		public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
		{
		}

		private static void SetTargetRotationInternal(this ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Space space)
		{
		}

		public static float GetFinalVelocity(float aVelocityChange, float aDrag)
		{
			return default(float);
		}

		public static float GetFinalVelocityFromAcceleration(float aAcceleration, float aDrag)
		{
			return default(float);
		}

		public static float GetDrag(float aVelocityChange, float aFinalVelocity)
		{
			return default(float);
		}

		public static float GetDragFromAcceleration(float aAcceleration, float aFinalVelocity)
		{
			return default(float);
		}

		public static float GetRequiredVelocityChange(float aFinalSpeed, float aDrag)
		{
			return default(float);
		}

		public static float GetRequiredAcceleraton(float aFinalSpeed, float aDrag)
		{
			return default(float);
		}
	}
}
