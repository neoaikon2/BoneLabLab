using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/GreaterThanEqualNode")]
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Greater Than or Equal")]
	public class GreaterThanEqualNode : BaseNode
	{
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		[SerializeField]
		private float _tolerance;

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

		public GreaterThanEqualNode()
			: base()
		{
		}
	}
}
