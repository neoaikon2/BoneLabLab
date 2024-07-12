using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MinNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Min")]
	[Support(SupportFlags.Supported, null)]
	public class MinNode : BaseNode
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

		public MinNode()
			: base()
		{
		}
	}
}
