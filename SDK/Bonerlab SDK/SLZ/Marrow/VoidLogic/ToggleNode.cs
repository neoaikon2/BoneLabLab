using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Toggle")]
	public class ToggleNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

		public bool Value { get; set; }

		private EdgeDetector SetEdgeDetector { get; set; }

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

		public ToggleNode()
			: base()
		{
		}
	}
}
