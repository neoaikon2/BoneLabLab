using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnDecorator : MonoBehaviour, ISpawnListenable
	{
		[SerializeField]
		protected CrateSpawner _crateSpawner;

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void OnSpawn(GameObject go)
		{
		}

		public virtual void OnDespawn(GameObject go)
		{
		}
	}
}
