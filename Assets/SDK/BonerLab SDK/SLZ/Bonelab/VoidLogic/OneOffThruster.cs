using System;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, null)]
	[AddComponentMenu(null)]
	public sealed class OneOffThruster : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, ISerializationCallbackReceiver, IVoidLogicActuator
	{
		[Obsolete("Replace with `_previousConnections`")]
		[Tooltip("Previous node(s) in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour[] _previous;

		[SerializeField]
		[NonReorderable]
		[Tooltip("Previous node(s) in the chain")]
		internal OutputPortReference[] _previousConnections;

		[SerializeField]
		private ForceMode forceMode;

		[SerializeField]
		private bool _relativeForce;

		[SerializeField]
		private bool _relativeTorque;

		[SerializeField]
		private Rigidbody _target;

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
