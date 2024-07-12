using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Passthrough")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/PassthroughNode")]
	public class PassthroughNode : BaseNode
	{
		[SerializeField]
		private bool _cutoff;

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

		public void Toggle()
		{
		}

		public void TurnOn()
		{
		}

		public void TurnOff()
		{
		}

		public PassthroughNode()
			: base()
		{
		}
	}
}
