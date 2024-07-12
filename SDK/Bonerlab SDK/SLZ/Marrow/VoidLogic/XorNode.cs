using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/XorNode")]
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Xor")]
	public class XorNode : BaseNode
	{
		private static readonly PortMetadata _portMetadata;

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

		public XorNode()
			: base()
		{
		}
	}
}
