using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Props;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(SpawnableCratePlacer))]
	public class PlacerSaver : MonoBehaviour
	{
		public enum PlacerItemType
		{
			UNKNOWN = 0,
			AMMO_CRATE = 1,
			AMMO_BOX = 2,
			PICKUP = 3
		}

		[Tooltip("This field is intentionally LOST after the initial placement. It is serialized for an initial-load backreference, but should not otherwise be preserved.")]
		[field: FormerlySerializedAs("_assignedPlacer")]
		[field: SerializeField]
		public SpawnableCratePlacer AssignedPlacer { get; set; }

		[field: SerializeField]
		public BonelabGameControl GameControl { get; set; }

		[field: SerializeField]
		[field: FormerlySerializedAs("_itemType")]
		public PlacerItemType ItemType { get; set; }

		[field: FormerlySerializedAs("_saveable")]
		[field: SerializeField]
		public Saveable Saveable { get; set; }

		public Object ItemComponent { get; set; }

		private void Awake()
		{
		}

		private bool ShouldPlace()
		{
			return false;
		}

		public void OnPlaced(SpawnableCratePlacer placer, GameObject go)
		{
		}

		private void OnAmmoCrateLootSpawned(ObjectDestructable ammoCrate, Spawnable ammoBoxSpawnable, GameObject ammoBox)
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
