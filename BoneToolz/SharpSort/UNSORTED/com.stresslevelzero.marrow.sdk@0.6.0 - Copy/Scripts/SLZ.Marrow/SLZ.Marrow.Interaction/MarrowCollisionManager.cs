using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnAfterLevelUnload()
		{
			return default(UniTask);
		}

		public static void ManagedIgnore(Collider colliderA, Collider colliderB, bool doIgnore = true)
		{
		}

		public static bool IsIgnored(Collider colliderA, Collider colliderB)
		{
			return false;
		}

		[MethodImpl(256)]
		private static int GetHashForPair(Collider colliderA, Collider colliderB)
		{
			return 0;
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
	}
}
