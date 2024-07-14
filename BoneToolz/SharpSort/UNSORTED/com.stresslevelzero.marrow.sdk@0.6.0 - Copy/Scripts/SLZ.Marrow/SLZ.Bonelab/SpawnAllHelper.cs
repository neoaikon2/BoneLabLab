using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnAllHelper : MonoBehaviour
	{
		[SerializeField]
		private CrateSpawner[] _crateSpawners;

		private List<Poolee> _poolees;

		public void SpawnAll()
		{
		}

		public void DespawnAll()
		{
		}
		private UniTaskVoid SpawnAsync()
		{
			return default(UniTaskVoid);
		}

		public void ToggleSpawn()
		{
		}
	}
}
