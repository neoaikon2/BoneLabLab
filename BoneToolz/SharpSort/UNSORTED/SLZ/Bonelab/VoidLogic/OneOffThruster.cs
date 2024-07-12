using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu(null)]
	[Support(SupportFlags.Unsupported, null)]
	public sealed class OneOffThruster : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		internal MonoBehaviour[] _previous;

		[SerializeField]
		private ForceMode forceMode;

		[SerializeField]
		private bool _relativeForce;

		[SerializeField]
		private bool _relativeTorque;

		[SerializeField]
		private Rigidbody _target;

		private static readonly PortMetadata _portMetadata;

		[field: ReadOnly(false)]
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

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

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}
	}
}
