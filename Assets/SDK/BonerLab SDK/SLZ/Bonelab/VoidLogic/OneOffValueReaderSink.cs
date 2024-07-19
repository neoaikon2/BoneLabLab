using System;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Value Reader One-off Sink")]
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	public sealed class OneOffValueReaderSink : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver
	{
		[SerializeField]
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[Obsolete("Replace with `_previousConnection`")]
		private MonoBehaviour _previousNode;

		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private OutputPortReference _previousConnection;

		private float _priorValue;

		[SerializeField]
		private TextMeshPro tmp;

		public string labelText;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

		public PortMetadata PortMetadata => throw new NotImplementedException();

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
		{
		}

		private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
		{
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateText()
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
			throw new NotImplementedException();
		}

		public void OnAfterDeserialize()
		{
			throw new NotImplementedException();
		}
	}
}
