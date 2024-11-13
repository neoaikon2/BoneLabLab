using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Marrow.Redacted
{
	public sealed class PowerReceiver : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource, ISocketable
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Tooltip("Previous node in the chain")]
		[SerializeField]
		[ReadOnly(false)]
		private OutputPortReference _previousConnection;

		private static readonly PortMetadata _portMetadata;

		[SerializeField]
		private Socket _socket;

		private PowerSender _powerPlug;

		[field: ReadOnly(false)]		
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int InputCount => 0;

		public int OutputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		public Socket Socket => null;

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

		public void OnPlugAttached(Plug plug)
		{
		}

		public void OnPlugDetached(Plug plug)
		{
		}

		public void OnBeforeSerialize()
		{
			throw new System.NotImplementedException();
		}

		public void OnAfterDeserialize()
		{
			throw new System.NotImplementedException();
		}

		public void Calculate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}
