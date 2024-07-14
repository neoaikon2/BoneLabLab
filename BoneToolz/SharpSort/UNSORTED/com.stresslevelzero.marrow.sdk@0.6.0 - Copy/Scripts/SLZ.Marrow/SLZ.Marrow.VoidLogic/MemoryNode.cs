using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Memory")]
	public sealed class MemoryNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		public float Value { get; set; }

		[field: Tooltip("Edge detection configuration for store input")]
		[field: SerializeField]
		private EdgeDetector StoreEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for clear input")]
		[field: SerializeField]
		private EdgeDetector ClearEdgeDetector { get; set; }

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
