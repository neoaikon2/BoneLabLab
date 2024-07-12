using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class BigGachaPlacer : SpawnDecorator
	{
		[Space(10f)]
		[Header("Requires Crate Spawner to be in Manual Mode")]
		[SerializeField]
		private GenericCrateReference unlockCrate;

		[SerializeField]
		private BonelabAvatarLevelGameControl gameControl;

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

		public override void OnSpawn(GameObject go)
		{
		}

		public BigGachaPlacer()
			: base()
		{
		}
	}
}
