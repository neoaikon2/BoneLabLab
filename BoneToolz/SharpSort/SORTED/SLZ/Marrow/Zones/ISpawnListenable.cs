using UnityEngine;

namespace SLZ.Marrow.Zones
{
	public interface ISpawnListenable
	{
		void OnSpawn(GameObject go);

		void OnDespawn(GameObject go);
	}
}
