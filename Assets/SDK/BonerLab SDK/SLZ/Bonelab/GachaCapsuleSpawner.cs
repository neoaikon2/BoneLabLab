using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GachaCapsuleSpawner : MonoBehaviour
	{
		[SerializeField]
		private Spawnable gacha;

		private List<SpawnableCrate> cratesToSpawn;

		private bool usedSpawnAll;

		private static PlayerUnlocks u => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPalletAdded(Barcode palletBarcode)
		{
		}

		public void UNLOCKALL()
		{
		}

		public void RELOCKALL()
		{
		}

		public void SPAWNUNLOCKGACHA()
		{
		}
		private IEnumerator SpawnGachas()
		{
			return null;
		}
		private UniTaskVoid SpawnGacha(SpawnableCrate crateToLink)
		{
			return default(UniTaskVoid);
		}
	}
}
