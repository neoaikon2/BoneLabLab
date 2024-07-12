using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Memory")]
	public sealed class MemoryNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		public float Value { get; set; }

		private EdgeDetector StoreEdgeDetector { get; set; }

		private EdgeDetector ClearEdgeDetector { get; set; }

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		public MemoryNode()
			: base()
		{
		}
	}
}
