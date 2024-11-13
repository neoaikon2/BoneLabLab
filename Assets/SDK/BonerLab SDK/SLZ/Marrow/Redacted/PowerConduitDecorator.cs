using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.Redacted
{
	public class PowerConduitDecorator : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource, ISpawnListenable
	{
		[SerializeField]
		protected CrateSpawner _crateSpawner;

		[SerializeField]
		private bool _isAutobindOnAttached;

		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Tooltip("Previous node in the chain")]
		[SerializeField]
		[ReadOnly(false)]
		private OutputPortReference _previousConnection;

		private static readonly PortMetadata _portMetadata;

		[field: ReadOnly(false)]		
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int InputCount => 0;

		public int OutputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDespawn(GameObject go)
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
