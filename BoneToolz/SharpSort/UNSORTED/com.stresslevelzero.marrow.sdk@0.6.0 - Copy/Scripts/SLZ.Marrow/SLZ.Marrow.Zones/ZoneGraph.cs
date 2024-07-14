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
			return false;
		}

		public bool RemoveEdge(TVert vertA, TVert vertB)
		{
			return false;
		}

		public bool AddVert(TVert vertA)
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

		public bool TryGetOutVerts(TVert vert, List<TVert> verts)
		{
			return false;
		}

		public bool TryGetInVerts(TVert vert, List<TVert> verts)
		{
			return false;
		}

		public bool IsConnected(TVert vertA, TVert vertB)
		{
			return false;
		}
	}
}
