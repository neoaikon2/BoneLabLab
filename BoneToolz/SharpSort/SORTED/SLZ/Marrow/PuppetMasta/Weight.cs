using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	[Serializable]
	public class Weight
	{
		[Serializable]
		public enum Mode
		{
			Float = 0,
			Curve = 1
		}

		public Mode mode;

		public float floatValue;

		public AnimationCurve curve;

		public string tooltip;

		public Weight(float floatValue)
		{
		}

		public Weight(float floatValue, string tooltip)
		{
		}

		public float GetValue(float param)
		{
			return 0f;
		}
	}
}
