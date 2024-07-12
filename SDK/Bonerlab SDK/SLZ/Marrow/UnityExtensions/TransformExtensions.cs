using UnityEngine;

namespace SLZ.Marrow.UnityExtensions
{
	public static class TransformExtensions
	{
		public delegate bool Filter(GameObject go);

		public static Transform FindDeepChild(this Transform aParent, Filter callback)
		{
			return null;
		}

		public static Transform FindDeepChild(this Transform aParent, string aName)
		{
			return null;
		}
	}
}
