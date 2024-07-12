using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class TimedPrefabSpawner : MonoBehaviour
	{
		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable spawnable;

		[Tooltip("Spawn Points")]
		[SerializeField]
		private Transform[] spawnPoints;

		[SerializeField]
		[Tooltip("Spawn Interval")]
		private float spawnInterval;

		[Tooltip("Ignore Colliders")]
		[SerializeField]
		private Collider[] ignoreColliders;

		private CancellationTokenSource cts;

		private bool doSpawnLoop;

		private int spawnIndex;

		private void Start()
		{
		}

		public void ACTIVATESPAWNER()
		{
		}

		public void DEACTIVATESPAWNER()
		{
		}

		private UniTaskVoid SpawnLoop(CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		public void SpawnPrefab()
		{
		}

		public TimedPrefabSpawner()
			: base()
		{
		}
	}
}
