using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.VoidLogic
{
	[Serializable]
	public sealed class EdgeDetector
	{
		private bool _inputWasNotLow;

		private bool _inputWasNotHigh;

		private float _nextAvailableTick;

		[field: Tooltip("Level at which value is unambiguously \"high\"")]
		[field: SerializeField]
		public float HighThreshold { get; internal set; }

		[field: SerializeField]
		[field: Tooltip("Level at which value is unambiguously \"low\"")]
		public float LowThreshold { get; internal set; }

		[field: SerializeField]
		[field: Tooltip("Whether values are detected on rise, fall, or continuously")]
		public TriggerBehavior TriggerBehavior { get; set; }

		[field: Tooltip("Maximum repeat rate. IMPORTANT: This caps maximum repetitions per second, but does not guarantee a minimum repeat rate; the tick cadence is the responsibility of the object owning this edge detector.")]
		[field: SerializeField]
		[field: FormerlySerializedAs("MaximumRepeatRate")]
		public float MaximumRepeatRate { get; set; }

		public EdgeDetector(float lowThreshold = 0.05f, float highThreshold = 0.95f, TriggerBehavior triggerBehavior = TriggerBehavior.OnRisingEdge, float maximumRepeatRate = 60f)
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
			return false;
		}

		[PublicAPI]
		public bool TickAndTest(float value, out EdgeType edgeType)
		{
			edgeType = default(EdgeType);
			return false;
		}
	}
}
