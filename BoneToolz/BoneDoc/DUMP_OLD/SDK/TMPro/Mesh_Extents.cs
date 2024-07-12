using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct Mesh_Extents
	{
		public Vector2 min;

		public Vector2 max;

		public Mesh_Extents(Vector2 min, Vector2 max)
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
