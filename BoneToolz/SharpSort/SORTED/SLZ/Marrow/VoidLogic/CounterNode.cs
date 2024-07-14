using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Counter")]
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	public sealed class CounterNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		[field: Tooltip("Counter initial value")]
		[field: SerializeField]
		public int Value { get; set; }

		[field: SerializeField]
		[field: Tooltip("Minimum allowable value")]
		public int Min { get; set; }

		[field: Tooltip("Maximum allowable value")]
		[field: SerializeField]
		public int Max { get; set; }

		[field: Tooltip("Edge detection configuration for decrement input")]
		[field: SerializeField]
		private EdgeDetector DecrementEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for increment input")]
		[field: SerializeField]
		private EdgeDetector IncrementEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for reset input")]
		[field: SerializeField]
		private EdgeDetector ResetEdgeDetector { get; set; }

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
