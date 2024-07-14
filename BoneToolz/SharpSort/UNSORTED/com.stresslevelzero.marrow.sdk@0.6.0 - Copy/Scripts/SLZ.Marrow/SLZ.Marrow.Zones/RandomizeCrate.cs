using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public class RandomizeCrate : SpawnDecorator
	{
		public SpawnableCrateReference[] crates;

		[Tooltip("If this is part of a CrateSpawnSequencer set this to false")]
		public bool spawnOnStart;

		private void Start()
		{
		}

		public SpawnableCrateReference SelectRandomCrate()
		{
			return null;
		}

		public void SelectAndSpawnRandomCrate()
		{
		}
	}
}
