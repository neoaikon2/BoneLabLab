using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Max")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MaxNode")]
	[Support(SupportFlags.Supported, null)]
	public class MaxNode : BaseNode
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

		public MaxNode()
			: base()
		{
		}
	}
}
