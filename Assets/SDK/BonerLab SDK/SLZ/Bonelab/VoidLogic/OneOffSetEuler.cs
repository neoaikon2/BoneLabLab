using System;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu(null)]
	[Support(SupportFlags.NotForRelease, "This is a one-off for testing.")]
	public sealed class OneOffSetEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver, IVoidLogicActuator
	{
		[Obsolete("Replace with `_previousConnections`")]
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour[] _previous;

		[Tooltip("Previous node(s) in the chain")]
		[NonReorderable]
		[SerializeField]
		internal OutputPortReference[] _previousConnections;

		[SerializeField]
		private bool _setOnActuation;

		[SerializeField]
		private Transform _target;

		private Vector3 targetRotation;

		private static readonly PortMetadata _portMetadata;

		[field: ReadOnly(false)]
		[field: SerializeField]
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

		private void Update()
		{
		}

		public void Actuate(ref NodeState nodeState)
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
