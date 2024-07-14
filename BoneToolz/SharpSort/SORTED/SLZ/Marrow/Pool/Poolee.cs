using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	[DefaultExecutionOrder(1000)]
	public class Poolee : MonoBehaviour
	{
		private static ComponentCache<Poolee> _cache;

		private bool _isInPool;

		private readonly List<IPoolable> _poolables;

		public Action<GameObject> OnSpawnDelegate;

		public Action<GameObject> OnDespawnDelegate;

		private bool _hasBeenInitialized;

		public static ComponentCache<Poolee> Cache => null;

		public SpawnableCrate SpawnableCrate { get; internal set; }

		public ulong ID { get; internal set; }

		public bool IsInPool => false;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		internal void OnInitialize()
		{
		}

		internal void OnSpawnEvent()
		{
		}

		internal void OnSpawn()
		{
		}

		internal void OnDespawnEvent()
		{
		}

		internal void OnDeinitialize()
		{
		}

		public void Despawn()
		{
		}

		public void RegisterPoolable(IPoolable poolable)
		{
		}

		public void DeregisterPoolable(IPoolable poolable)
		{
		}
	}
}
