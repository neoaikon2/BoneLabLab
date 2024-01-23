using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Utilities
{
	public static class PhysicsExtensions
	{
		private class AscendingDistanceComparer : IComparer<RaycastHit>
		{
			public int Compare(RaycastHit h1, RaycastHit h2)
			{
				return 0;
			}
		}

		private static AscendingDistanceComparer ascendDistance;

		public static bool BoxCast(BoxCollider box, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		public static bool BoxCast(BoxCollider box, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static RaycastHit[] BoxCastAll(BoxCollider box, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int BoxCastNonAlloc(BoxCollider box, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static bool CheckBox(BoxCollider box, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		public static Collider[] OverlapBox(BoxCollider box, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int OverlapBoxNonAlloc(BoxCollider box, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static void ToWorldSpaceBox(this BoxCollider box, out Vector3 center, out Vector3 halfExtents, out Quaternion orientation)
		{
			center = default(Vector3);
			halfExtents = default(Vector3);
			orientation = default(Quaternion);
		}

		public static bool SphereCast(SphereCollider sphere, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static RaycastHit[] SphereCastAll(SphereCollider sphere, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int SphereCastNonAlloc(SphereCollider sphere, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static bool CheckSphere(SphereCollider sphere, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		public static Collider[] OverlapSphere(SphereCollider sphere, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int OverlapSphereNonAlloc(SphereCollider sphere, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static void ToWorldSpaceSphere(this SphereCollider sphere, out Vector3 center, out float radius)
		{
			center = default(Vector3);
			radius = default(float);
		}

		public static bool CapsuleCast(CapsuleCollider capsule, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public static RaycastHit[] CapsuleCastAll(CapsuleCollider capsule, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int CapsuleCastNonAlloc(CapsuleCollider capsule, Vector3 direction, RaycastHit[] results, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static bool CheckCapsule(CapsuleCollider capsule, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return false;
		}

		public static Collider[] OverlapCapsule(CapsuleCollider capsule, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return null;
		}

		public static int OverlapCapsuleNonAlloc(CapsuleCollider capsule, Collider[] results, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			return 0;
		}

		public static void ToWorldSpaceCapsule(this CapsuleCollider capsule, out Vector3 point0, out Vector3 point1, out float radius)
		{
			point0 = default(Vector3);
			point1 = default(Vector3);
			radius = default(float);
		}

		public static void SortClosestToFurthest(RaycastHit[] hits, int hitCount = -1)
		{
		}

		private static Vector3 AbsVec3(Vector3 v)
		{
			return default(Vector3);
		}

		private static float MaxVec3(Vector3 v)
		{
			return 0f;
		}
	}
}
