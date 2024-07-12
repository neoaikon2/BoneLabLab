using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class ZoneTriggerNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		[SerializeField]
		private Zone _zone;

		public EntityAggregator aggregator;

		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		protected MonoBehaviour[] _previous;

		public UltEvent<MarrowBody> OnBodyTriggerEnter;

		public UltEvent<MarrowBody> OnBodyTriggerExit;

		public UltEvent<MarrowEntity> OnEntityTriggerEnter;

		public UltEvent<MarrowEntity> OnEntityTriggerExit;

		[ReadOnly(false)]
		[SerializeField]
		private float logicMultiplier;

		protected internal float _cachedValue;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		protected bool IsCachedInternal { get; private set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Reset()
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

		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}

		void IVoidLogicSource.Calculate(NodeState nodeState)
		{
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public ZoneTriggerNode()
			: base()
		{
		}
	}
}
