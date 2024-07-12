using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Counter")]
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	public sealed class CounterNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		public int Value { get; set; }

		public int Min { get; set; }

		public int Max { get; set; }

		private EdgeDetector DecrementEdgeDetector { get; set; }

		private EdgeDetector IncrementEdgeDetector { get; set; }

		private EdgeDetector ResetEdgeDetector { get; set; }

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

		public CounterNode()
			: base()
		{
		}
	}
}
