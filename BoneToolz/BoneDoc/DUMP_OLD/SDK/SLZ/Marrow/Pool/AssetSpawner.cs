using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	public class AssetSpawner : MonoBehaviour
	{
		private static bool _hasInstance;

		private static AssetSpawner _instance;

		private Dictionary<Barcode, Pool> _barcodeToPool;

		private Dictionary<Poolee, SpawnPolicy> _pooleeToPolicy;

		private Dictionary<int, SpawnPolicy> _policySpawns;

		private List<Pool> _poolList;

		private static ulong _spawnCount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private static void Instantiate()
		{
		}

		public static ulong GetNewID()
		{
			return default(ulong);
		}

		public static void Register(Spawnable spawnable)
		{
		}

		public static UniTask RegisterAsync(Barcode barcode)
		{
			return default(UniTask);
		}

		public static UniTask InstantiateForWarmupAsync(Spawnable spawnable)
		{
			return default(UniTask);
		}

		public static void Spawn(Spawnable spawnable, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = default(Vector3?), bool ignorePolicy = false, int? groupID = default(int?), Action<GameObject> spawnCallback = default(Action<GameObject>), Action<GameObject> despawnCallback = default(Action<GameObject>))
		{
		}

		public static UniTask<Poolee> SpawnAsync(Spawnable spawnable, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = default(Vector3?), bool ignorePolicy = false, int? groupID = default(int?), Action<GameObject> spawnCallback = default(Action<GameObject>), Action<GameObject> despawnCallback = default(Action<GameObject>))
		{
			return default(UniTask<Poolee>);
		}

		public static void Clear(Poolee poolee)
		{
		}

		public static void Despawn(Poolee poolee, bool skipDisable = false)
		{
		}

		public AssetSpawner()
			: base()
		{
		}
	}
}
