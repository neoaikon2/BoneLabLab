using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnerToggle : SpawnDecorator
	{
		[HideInInspector]
		public bool shouldSpawn;

		private void Awake()
		{
		}

		private bool ShouldSpawn()
		{
			return default(bool);
		}

		public void SpawnerEnabled(bool b)
		{
		}

		public SpawnerToggle()
			: base()
		{
		}
	}
}
