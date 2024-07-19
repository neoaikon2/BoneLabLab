using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnableSaver : MonoBehaviour
	{
		public enum SpawnerItemType
		{
			UNKNOWN = 0,
			AMMO_CRATE = 1,
			AMMO_BOX = 2,
			PICKUP = 3
		}

		[Tooltip("This field is intentionally LOST after the initial spawn. It is serialized for an initial-load backreference, but should not otherwise be preserved.")]
		[field: FormerlySerializedAs("<AssignedPlacer>k__BackingField")]
		[field: FormerlySerializedAs("_assignedPlacer")]
		[field: SerializeField]
		public CrateSpawner AssignedSpawner { get; set; }

		[field: SerializeField]
		public BonelabGameControl GameControl { get; set; }

		[field: FormerlySerializedAs("_itemType")]
		[field: SerializeField]
		public SpawnerItemType ItemType { get; set; }

		[field: SerializeField]
		[field: FormerlySerializedAs("_saveable")]
		public Saveable Saveable { get; set; }

		public Object ItemComponent { get; set; }

		private void Awake()
		{
		}

		private bool ShouldSpawn()
		{
			return false;
		}

		public void OnSpawned(CrateSpawner spawner, GameObject go)
		{
		}

		private void OnAmmoCrateLootSpawned(ObjectDestructible ammoCrate, Spawnable ammoBoxSpawnable, GameObject ammoBox)
		{
		}

		private void OnAmmoBoxCollected()
		{
		}

		private void UpdateSave()
		{
		}
	}
}
