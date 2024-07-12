using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/PowerSource")]
	[AddComponentMenu("VoidLogic/Sources/VoidLogic Power")]
	[Support(SupportFlags.Supported, null)]
	public class PowerSource : MonoBehaviour, IVoidLogicSource, IVoidLogicNode
	{
		[SerializeField]
		[Tooltip("Amount of power supplied by this source")]
		private float _value;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public float OutputValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public PowerSource()
			: base()
		{
		}
	}
}
