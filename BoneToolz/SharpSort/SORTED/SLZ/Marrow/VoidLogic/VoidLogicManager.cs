using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[DefaultExecutionOrder(-16384)]
	[AddComponentMenu(null)]
	public class VoidLogicManager : MonoBehaviour
	{
		internal readonly Dictionary<MonoBehaviour, Object> _temporaryMarrowEntityMap;

		internal static readonly double _ticksToNanoseconds;

		internal readonly Stopwatch _stopwatch;

		internal Dictionary<MonoBehaviour, VoidLogicSubgraph> _node2Subgraph;

		private readonly Dictionary<MonoBehaviour, GraphUpdate> _pendingAddRemoves;

		private readonly Queue<GraphUpdate> _inputQueue;

		private readonly Queue<GraphUpdate> _toggleQueue;

		private readonly HashSet<MonoBehaviour> _nodeAdds;

		private readonly HashSet<MonoBehaviour> _nodeRemoves;

		private readonly HashSet<VoidLogicSubgraph> _invalidatedGraphs;

		[field: SerializeField]
		public List<VoidLogicSubgraph> Subgraphs { get; private set; }

		[field: SerializeField]
		public long DeadlineTicks { get; private set; }

		[field: SerializeField]
		public bool Running { get; internal set; }

		[field: SerializeField]
		public int Cursor { get; private set; }

		internal void _addNode(IVoidLogicNode node, Object entity)
		{
		}

		internal void _removeNode(IVoidLogicNode node)
		{
		}

		internal void _updateInput(IVoidLogicSink sink, uint index, IVoidLogicSource source)
		{
		}

		internal void _enableNode(IVoidLogicNode node)
		{
		}

		internal void _disableNode(IVoidLogicNode node)
		{
		}

		private void Reset()
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

		private void _drainUpdateQueue()
		{
		}

		private void _step1_FlushPendingAddRemovesToWorkingSet()
		{
		}

		private void _step2_FlushInputUpdateQueueToWorkingSet()
		{
		}

		private List<List<MonoBehaviour>> _step3a_CalculateSubgraphsFromWorkingSet()
		{
			return null;
		}

		private static MonoBehaviour[] _step3b_OrderSubgraphNodesInReverseDependencyOrder(List<MonoBehaviour> subgraphNodes)
		{
			return null;
		}

		private VoidLogicSubgraph _step4_FillNodeAndGraphStates(MonoBehaviour[] subgraph)
		{
			return null;
		}

		private void _stepFinal_PropagateEnableDisable()
		{
		}

		private void _collectGarbage()
		{
		}
	}
}
