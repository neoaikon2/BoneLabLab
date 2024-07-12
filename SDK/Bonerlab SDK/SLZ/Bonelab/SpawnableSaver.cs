using System.Runtime.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.VFX;
using UnityEngine;

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
		public CrateSpawner AssignedSpawner { get; set; }

		public BonelabGameControl GameControl { get; set; }

		public SpawnerItemType ItemType { get; set; }

		public Saveable Saveable { get; set; }

		public Object ItemComponent { get; set; }

		private void Awake()
		{
		}

		private bool ShouldSpawn()
		{
			return default(bool);
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

		public SpawnableSaver()
			: base()
		{
		}
	}
}
