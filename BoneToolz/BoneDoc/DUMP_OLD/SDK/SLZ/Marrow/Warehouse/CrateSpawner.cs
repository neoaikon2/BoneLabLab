using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[AddComponentMenu("MarrowSDK/Crate Spawner")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Spawnables")]
	[SelectionBase]
	public class CrateSpawner : MonoBehaviour
	{
		[Tooltip("Drag a Spawnable Crate from the Asset Warehouse or use the picker button to the right to select a Spawnable Crate.")]
		[SerializeField]
		public SpawnableCrateReference spawnableCrateReference;

		[SerializeField]
		[Tooltip("Policy Data is a ScriptableObject that is used to define whether policy rules should apply on a per-crate basis, the maximum spawn pool size, and how the pool of spawnables should handle reaching their maximum limit, i.e. Reuse the Oldest, Grow, Reuse the Newest, etc.")]
		public SpawnPolicyData policyData;

		[SerializeField]
		public CrateQuery crateQuery;

		[SerializeField]
		public bool useQuery;

		[Tooltip("With Manual Mode enabled, CrateSpawners will *not* activate when their associated Zone is triggered.  Instead, they must be activated through an event, button press or similar action that calls the SpawnSpawnable() method.")]
		[SerializeField]
		public bool manualMode;

		[Tooltip("Trigger additional events or actions once the CrateSpawner is activated.")]
		[SerializeField]
		public OnSpawnEvent onSpawnEvent;

		[SerializeField]
		public bool previewMeshInPlaymode;

		[SerializeField]
		public Material playmodePreviewMaterial;

		private List<ISpawnListenable> _spawnListeners;

		private Action<GameObject> _onPooleeSpawn;

		private Action<GameObject> _onPooleeDespawn;

		public Func<bool> shouldSpawn;

		[SerializeField]
		[ReadOnly(false)]
		public GameObject _spawnedSpawnable;

		private Spawnable _spawnable;

		private bool _runtimeMeshGenerated;

		private MarrowAsset _runtimeMeshAsset;

		private void Awake()
		{
		}

		private void OnPersistentLoad()
		{
		}

		private void OnPooleeSpawn(GameObject go)
		{
		}

		private void OnPooleeDespawn(GameObject go)
		{
		}

		private SpawnableCrateReference GetCrateReference()
		{
			return null;
		}

		[ContextMenu("Spawn Spawnable")]
		public void SpawnSpawnable()
		{
		}

		public void SetSpawnable()
		{
		}

		public UniTask<Poolee> SpawnSpawnableAsync(bool isHidden = false)
		{
			return default(UniTask<Poolee>);
		}

		public void ReSpawnSpawnable()
		{
		}

		[ContextMenu("Run Query")]
		private void RunQuery()
		{
		}

		[ContextMenu("Create Runtime Preview")]
		private void CreateRuntimePreview()
		{
		}

		private void OnDestroy()
		{
		}

		public void RegisterSpawnEventListener(ISpawnListenable listener)
		{
		}

		public void UnregisterSpawnEventListener(ISpawnListenable listener)
		{
		}

		public CrateSpawner()
			: base()
		{
		}
	}
}
