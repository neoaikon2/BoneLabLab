using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct VertexGradient
	{
		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		public VertexGradient(Color color)
		{
			this.bottomRight = default(Color);
			this.bottomLeft = default(Color);
			this.topRight = default(Color);
			this.topLeft = default(Color);
		}

		public VertexGradient(Color color0, Color color1, Color color2, Color color3)
		{
			this.bottomRight = default(Color);
			this.bottomLeft = default(Color);
			this.topRight = default(Color);
			this.topLeft = default(Color);
		}
	}
}
