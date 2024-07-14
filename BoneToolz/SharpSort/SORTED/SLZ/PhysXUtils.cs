using UnityEngine;

namespace SLZ
{
	public static class PhysXUtils
	{
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		public static Vector3 GetFromToVelocity(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		public static Vector3 GetAngularDisplacement(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		public static Vector3 GetAngularVelocity(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		public static Vector3 GetLinearDisplacement(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		public static Vector3 GetLinearVelocity(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
}
