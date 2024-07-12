using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[Support(SupportFlags.Supported, null)]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RemapNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Remap")]
	public class RemapNode : BaseNode
	{
		[Tooltip("Output response curve")]
		[SerializeField]
		private AnimationCurve _remapCurve;

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

		public RemapNode()
			: base()
		{
		}
	}
}
