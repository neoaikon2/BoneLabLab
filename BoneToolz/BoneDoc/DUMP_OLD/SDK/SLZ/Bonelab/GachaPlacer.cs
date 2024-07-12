using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class GachaPlacer : SpawnDecorator
	{
		[Header("Requires Crate Spawner to be in Manual Mode")]
		[Space(10f)]
		[SerializeField]
		private GenericCrateReference unlockCrate;

		public bool onlyPlaceIfBeatGame;

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnPersistentLoad()
		{
		}

		private bool ShouldSpawn()
		{
			return default(bool);
		}

		public override void OnSpawn(GameObject go)
		{
		}

		public GachaPlacer()
			: base()
		{
		}
	}
}
