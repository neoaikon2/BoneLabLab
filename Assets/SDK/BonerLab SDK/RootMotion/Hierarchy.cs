using UnityEngine;

namespace RootMotion
{
	public class Hierarchy
	{
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return false;
		}

		public static Object ContainsDuplicate(Object[] objects)
		{
			return null;
		}

		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return false;
		}

		public static bool ContainsChild(Transform transform, Transform child)
		{
			return false;
		}

		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}
	}
}
