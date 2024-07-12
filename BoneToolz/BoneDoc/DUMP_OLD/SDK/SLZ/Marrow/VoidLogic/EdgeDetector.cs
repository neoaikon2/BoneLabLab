using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.VoidLogic
{
	[Serializable]
	public sealed class EdgeDetector
	{
		private bool _inputWasNotLow;

		private bool _inputWasNotHigh;

		private float _nextAvailableTick;

		public float HighThreshold { get; internal set; }

		public float LowThreshold { get; internal set; }

		public TriggerBehavior TriggerBehavior { get; set; }

		public float MaximumRepeatRate { get; set; }

		public EdgeDetector(float lowThreshold = 0.05f, float highThreshold = 0.95f, TriggerBehavior triggerBehavior = TriggerBehavior.OnRisingEdge, float maximumRepeatRate = 60f)
			: base()
		{
		}

		private EdgeType Tick(float nextInput)
		{
			return default(EdgeType);
		}

		private ValueType TestValue(float value)
		{
			return default(ValueType);
		}

		[PublicAPI]
		public bool TickAndTest(float value)
		{
			return default(bool);
		}

		[PublicAPI]
		public bool TickAndTest(float value, [Out] EdgeType edgeType)
		{
			return default(bool);
		}
	}
}
