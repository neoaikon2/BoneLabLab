using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[RequireComponent(typeof(BoxCollider))]
	public class CrateSpawnerGrid : MonoBehaviour
	{
		private struct GridRange
		{
			public Vector3 position;

			public float xMin;

			public float zMin;

			public float xMax;

			public float zMax;

			public float width;

			public float length;

			public GridRange(Vector3 position, float width, float length)
			{
				this.length = default(float);
				this.width = default(float);
				this.zMax = default(float);
				this.xMax = default(float);
				this.zMin = default(float);
				this.xMin = default(float);
				this.position = default(Vector3);
			}
		}

		public BoxCollider boxCollider;

		public bool allPallets;

		public List<PalletReference> pallets;

		public float margin;

		public float padding;

		public bool invertDirection;

		public bool manualSpawn;

		public List<SpawnableCrateReference> cratesToExclude;

		[SerializeField]
		[Header("Debug Fields")]
		private List<CrateSpawner> crateSpawners;

		[SerializeField]
		public List<float> rowMarkers;

		[SerializeField]
		public List<float> longestLengths;

		private void Reset()
		{
		}

		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		[ContextMenu("Spawn")]
		public void SpawnGrid()
		{
		}

		private UniTask SpawnGridAsync()
		{
			return default(UniTask);
		}

		public CrateSpawnerGrid()
			: base()
		{
		}
	}
}
