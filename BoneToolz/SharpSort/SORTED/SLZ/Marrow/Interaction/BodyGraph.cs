using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Interaction
{
	[Serializable]
	public class BodyGraph<TVert, TEdge> where TVert : class where TEdge : class
	{
		private List<TVert> _verts;

		private readonly Dictionary<int, List<TEdge>> _edges;

		private readonly Dictionary<TVert, HashSet<TVert>> _edgeHashes;

		private readonly Dictionary<TVert, List<TVert>> _outEdges;

		private readonly Dictionary<TVert, List<TVert>> _inEdges;

		private bool _isCacheDirty;

		private readonly List<HashSet<TVert>> _graphsVertHashes;

		private readonly List<List<TVert>> _graphsVertLists;

		private readonly Dictionary<TVert, int> _vertToGraphIdxLookup;

		private readonly HashSet<TVert> _counted;

		private readonly HashSet<TVert> _visited;

		private readonly Queue<TVert> _searchQueue;

		public void Clear()
		{
		}

		public bool AddEdge(TVert vertA, TVert vertB, TEdge edge)
		{
			return false;
		}

		public bool RemoveEdge(TVert vertA, TVert vertB, TEdge edge)
		{
			return false;
		}

		public bool RemoveVert(TVert vert)
		{
			return false;
		}

		private void BuildCache()
		{
		}

		public List<TVert> GetSiblingVerts(TVert vert)
		{
			return null;
		}

		public bool HasEdges(TVert vert)
		{
			return false;
		}

		public bool TryGetEdges(TVert vertA, TVert vertB, List<TEdge> edges)
		{
			return false;
		}

		public bool TryGetOutEdges(TVert vert, List<TEdge> edges)
		{
			return false;
		}

		public bool TryGetInVerts(TVert vert, List<TEdge> edges)
		{
			return false;
		}

		public bool IsConnected(TVert vertA, TVert vertB)
		{
			return false;
		}
	}
}
