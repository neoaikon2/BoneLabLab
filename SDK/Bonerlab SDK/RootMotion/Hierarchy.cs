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

		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return false;
		}
	}
}
