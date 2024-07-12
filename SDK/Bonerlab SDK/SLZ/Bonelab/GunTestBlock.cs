using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GunTestBlock : MonoBehaviour
	{
		public float fireFrequency;

		public CrateSpawner[] gunSpawners;

		private List<Gun> _guns;

		private bool _isReady;

		private float _lastFireTime;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private UniTaskVoid SpawnAsync()
		{
			return default(UniTaskVoid);
		}

		private UniTask SpawnAsync(CrateSpawner spawner)
		{
			return default(UniTask);
		}

		private void Update()
		{
		}

		public GunTestBlock()
			: base()
		{
		}
	}
}
