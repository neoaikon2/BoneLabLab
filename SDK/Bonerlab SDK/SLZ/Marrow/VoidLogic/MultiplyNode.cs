using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Multiply")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MultiplyNode")]
	[Support(SupportFlags.Supported, null)]
	public class MultiplyNode : BaseNode
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

		public MultiplyNode()
			: base()
		{
		}
	}
}
