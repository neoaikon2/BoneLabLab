using System.Collections.Generic;

namespace SLZ.Marrow.Graphs
{
	public class DirectedGraph<TNode>
	{
		internal HashSet<TNode> _nodes;

		internal List<TNode> _orderedNodes;

		internal Dictionary<TNode, HashSet<TNode>> _edges;

		internal Dictionary<TNode, HashSet<TNode>> _reverseEdges;

		public bool AddNode(TNode node)
		{
			return false;
		}

		public void AddEdge(TNode from, TNode to)
		{
		}

		public List<List<TNode>> ConnectedComponents_Tarjan()
		{
			return null;
		}

		private void StrongConnect(TNode v, Dictionary<TNode, int> indices, ref int index, Dictionary<TNode, int> lowlinks, Stack<TNode> stack, List<List<TNode>> components)
		{
		}
	}
}
