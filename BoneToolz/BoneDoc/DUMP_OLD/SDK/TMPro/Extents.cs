using UnityEngine;

namespace TMPro
{
	public struct Extents
	{
		internal static Extents zero;

		internal static Extents uninitialized;

		public Vector2 min;

		public Vector2 max;

		public Extents(Vector2 min, Vector2 max)
		{
			this.max = default(Vector2);
			this.min = default(Vector2);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
