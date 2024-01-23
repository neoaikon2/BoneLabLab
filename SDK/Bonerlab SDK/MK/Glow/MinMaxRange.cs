using System;

namespace MK.Glow
{
	[Serializable]
	public struct MinMaxRange
	{
		public float minValue;

		public float maxValue;

		public MinMaxRange(float _minValue, float _maxValue)
		{
			minValue = _minValue;
			maxValue = _maxValue;
		}
	}
}
