using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[AttributeUsage(AttributeTargets.Field)]
	internal class LabelWidthAttribute : PropertyAttribute
	{
		public float Width { get; }

		public LabelWidthAttribute(float width)
			: base()
		{
		}
	}
}
