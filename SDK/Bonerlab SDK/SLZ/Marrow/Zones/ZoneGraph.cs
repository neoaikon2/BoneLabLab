using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	public class ZoneGraph<TVert> where TVert : class
	{
		private List<TVert> _verts;

		private Dictionary<TVert, HashSet<TVert>> _edgeHashes;

		private Dictionary<TVert, List<TVert>> _outEdges;

		private Dictionary<TVert, List<TVert>> _inEdges;

		private bool _isCacheDirty;

		private List<HashSet<TVert>> _graphsVertHashes;

		private List<List<TVert>> _graphsVertLists;

		private Dictionary<TVert, int> _vertToGraphIdxLookup;

		private HashSet<TVert> _counted;

		private HashSet<TVert> _visited;

		private Queue<TVert> _searchQueue;

		public void Clear()
		{
		}

		public bool AddEdge(TVert vertA, TVert vertB)
		{
			return default(bool);
		}

		public bool RemoveEdge(TVert vertA, TVert vertB)
		{
			return default(bool);
		}

		public bool AddVert(TVert vertA)
		{
			return default(bool);
		}

		public bool RemoveVert(TVert vert)
		{
			return default(bool);
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
			return default(bool);
		}

		public bool TryGetOutVerts(TVert vert, List<TVert> verts)
		{
			return default(bool);
		}

		public bool TryGetInVerts(TVert vert, List<TVert> verts)
		{
			return default(bool);
		}

		public bool IsConnected(TVert vertA, TVert vertB)
		{
			return default(bool);
		}

		public ZoneGraph()
			: base()
		{
		}
	}
}
