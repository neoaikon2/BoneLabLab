using System;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public struct RTVertexData
	{
		public Vector3 vertex;

		public Vector3 normal;

		public Vector2 uv;

		public Vector2 uv2;

		public Color color;

		public RTVertexData(Vector3 _vertex, Vector3 _normal, Vector2 _uv, Vector2 _uv2, Color _color)
		{
			vertex = _vertex;
			normal = _normal;
			uv = _uv;
			uv2 = _uv2;
			color = _color;
		}
	}
}
