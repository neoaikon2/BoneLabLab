using UnityEngine;

namespace TMPro
{
	public struct TMP_Vertex
	{
		public Vector3 position;

		public Vector2 uv;

		public Vector2 uv2;

		public Vector2 uv4;

		public Color32 color;

		private static readonly TMP_Vertex k_Zero;

		public static TMP_Vertex zero
		{
			get
			{
				return default(TMP_Vertex);
			}
		}
	}
}
