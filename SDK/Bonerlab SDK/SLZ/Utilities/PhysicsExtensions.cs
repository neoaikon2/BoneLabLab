using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Utilities
{
	public static class PhysicsExtensions
	{
		public static void ToWorldSpaceBox(this BoxCollider box, [Out] Vector3 center, [Out] Vector3 halfExtents, [Out] Quaternion orientation)
		{
		}

		private static Vector3 AbsVec3(Vector3 v)
		{
			return default(Vector3);
		}
	}
}
