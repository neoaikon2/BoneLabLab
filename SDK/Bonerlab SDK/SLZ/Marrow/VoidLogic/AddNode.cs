using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Add")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/AddNode")]
	public class AddNode : BaseNode
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

		public AddNode()
			: base()
		{
		}
	}
}
