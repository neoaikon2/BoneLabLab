using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SubtractNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Subtract")]
	[Support(SupportFlags.Supported, null)]
	public class SubtractNode : BaseNode
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

		public SubtractNode()
			: base()
		{
		}
	}
}
