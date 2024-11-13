using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Marrow.Redacted
{
	public class PowerSender : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource, IPlugable
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Tooltip("Previous node in the chain")]
		[SerializeField]
		private OutputPortReference _previousConnection;

		private static readonly PortMetadata _portMetadata;

		[SerializeField]
		private Plug _plug;

		private PowerReceiver _powerReceiver;

		[field: SerializeField]		
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int InputCount => 0;

		public int OutputCount => 0;

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

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EInitialize(ref NodeState nodeState)
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicSource_002ECalculate(ref NodeState nodeState)
		{
		}

		public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
		{
			connectedPort = default(OutputPortReference);
			return false;
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return false;
		}

		public void OnSocketAttached(Socket socket)
		{
		}

		public void OnSocketDetached(Socket socket)
		{
		}

		public void Calculate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}

		public void OnBeforeSerialize()
		{
			throw new System.NotImplementedException();
		}

		public void OnAfterDeserialize()
		{
			throw new System.NotImplementedException();
		}
	}
}
