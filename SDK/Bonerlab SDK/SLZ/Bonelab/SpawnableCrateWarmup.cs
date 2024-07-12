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

namespace SLZ.Bonelab
{
	public class SpawnableCrateWarmup : MonoBehaviour
	{
		[SerializeField]
		private PoolWarmupProfile[] _warmupProfiles;

		private Queue<ValueTuple<Spawnable, int>> _spawnQueue;

		private int _maxBatch;

		private int _currentBatch;

		private bool _isDraining;

		private Func<bool> _isDrainingFunc;

		private void Awake()
		{
		}

		private void OnWillLoadPersistent()
		{
		}

		private UniTaskVoid WarmupSpreadAsync(Dictionary<Barcode, int> compiledManifest)
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid WarmupAsync(Spawnable spawnable)
		{
			return default(UniTaskVoid);
		}

		public SpawnableCrateWarmup()
			: base()
		{
		}
	}
}
