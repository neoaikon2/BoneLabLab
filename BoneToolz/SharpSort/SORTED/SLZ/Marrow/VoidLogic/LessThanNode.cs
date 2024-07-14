using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LessThanNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Less Than")]
	[Support(SupportFlags.Supported, null)]
	public class LessThanNode : BaseNode
	{
		[SerializeField]
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		private float _tolerance;

		private static readonly PortMetadata _portMetadata;

		public override PortMetadata PortMetadata => default(PortMetadata);

		public override void Calculate(ref NodeState nodeState)
		{
		}
	}
}
