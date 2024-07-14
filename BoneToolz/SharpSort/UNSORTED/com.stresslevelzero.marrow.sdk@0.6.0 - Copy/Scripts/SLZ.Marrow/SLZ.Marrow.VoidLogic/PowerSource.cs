using SLZ.Marrow.Utilities;
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

		[field: ReadOnly(false)]
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public float OutputValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PortMetadata PortMetadata => default(PortMetadata);

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

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSource_002ECalculate(ref NodeState nodeState)
		{
		}

		public void Calculate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}
