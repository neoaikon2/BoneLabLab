using UnityEngine;

namespace SLZ.Interaction
{
	public static class MathUtils
	{
		public static readonly float Epsilon;

		public static float _sqrt_2;

		public static void DecomposeSwingTwist(Quaternion q, Vector3 twistAxis, out Quaternion swing, out Quaternion twist)
		{
			swing = default(Quaternion);
			twist = default(Quaternion);
		}

		public static void CalculateDelta(float pos, float rot, ref float lastPos, ref float lastRot, out float posDelta, out float rotDelta)
		{
			posDelta = default(float);
			rotDelta = default(float);
		}

		public static float Magnitude(in Quaternion q)
		{
			return 0f;
		}

		public static Quaternion Normalize(in Quaternion q)
		{
			return default(Quaternion);
		}

		public static bool IsQuaternionNan(in Quaternion rotation)
		{
			return false;
		}

		public static Vector3 FastRotateTowards(in Vector3 lhsNorm, in Vector3 rhsNorm, float targetAngle)
		{
			return default(Vector3);
		}

		public static Vector3 OrthoNormalVectorFast(in Vector3 v)
		{
			return default(Vector3);
		}

		public static Quaternion LimitSwingTwistRotation(in Quaternion q, in Vector3 primaryAxis, in float swingLimit, in float twistLimit)
		{
			return default(Quaternion);
		}

		public static Quaternion SoftLimitSwingTwistRotation(in Quaternion q, in Vector3 primaryAxis, in float swingSoftLimit, in float swingHardLimit, in float twistSoftLimit, in float twistHardLimit)
		{
			return default(Quaternion);
		}
	}
}
