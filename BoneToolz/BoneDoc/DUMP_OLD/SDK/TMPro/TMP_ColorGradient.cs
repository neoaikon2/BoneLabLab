using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset]
	public class TMP_ColorGradient : ScriptableObject
	{
		public ColorMode colorMode;

		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient;

		private static readonly Color k_DefaultColor;

		public TMP_ColorGradient()
			: base()
		{
		}

		public TMP_ColorGradient(Color color)
			: this()
		{
		}

		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
			: this()
		{
		}
	}
}
