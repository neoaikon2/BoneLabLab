using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[MarrowPlugin("SLZ.Marrow", "CollisionManager", "0.0.1")]
	public class MarrowCollisionManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		private static readonly Dictionary<int, int> _ignoreCounts;

		private static readonly Dictionary<Collider, HashSet<Collider>> _colliderToColliderMap;

		private static readonly List<Collider> _colBsToRemove;

		UniTask IMarrowPluginLevelCallbacks.OnAfterLevelUnload()
		{
			return default(UniTask);
		}

		public static void ManagedIgnore(Collider colliderA, Collider colliderB, bool doIgnore = true)
		{
		}

		public static bool IsIgnored(Collider colliderA, Collider colliderB)
		{
			return default(bool);
		}

		private static int GetHashForPair(Collider colliderA, Collider colliderB)
		{
			return default(int);
		}

		public static void ClearManagedIgnoresFor(Collider colliderA)
		{
		}

		private static void CacheLookups(Collider colliderA, Collider colliderB)
		{
		}

		private static void ClearLookups(Collider colliderA, Collider colliderB)
		{
		}

		public MarrowCollisionManager()
			: base()
		{
		}
	}
}
