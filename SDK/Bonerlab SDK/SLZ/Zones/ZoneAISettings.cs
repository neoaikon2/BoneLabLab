using PuppetMasta;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Zones
{
	[RequireComponent(typeof(ZoneSpawner))]
	public class ZoneAISettings : ZoneItem
	{
		private static ComponentCache<ZoneAISettings> _cache;

		public ZoneSpawner zoneSpawner;

		public BaseEnemyConfig baseConfig;

		public Transform homeTransform;

		public bool homeIsPost;

		public bool isAutoInvestigate;

		public bool isAutoAggro;

		public bool isSoundAggroWhenInSecondaryZone;

		public float investigateTimeout = 10.0f;

		public bool overrideRoam;

		public Vector2 roamXz = Vector2.zero;

		public float roamSpeed = 0.8f;

		public bool roamWanders;

		private GameObject _playerObject;

		public static ComponentCache<ZoneAISettings> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateAIState(GameObject spawnedGo)
		{
		}

		public void AgroOnPlayer()
		{
		}

		public override void OnZoneDisabled(GameObject playerObject)
		{
		}

		public override void OnZoneEnabled(GameObject playerObject)
		{
		}

		private void OnPreSpawn(GameObject spawnedGo, GameObject playerObject)
		{
		}

		private void OnSpawn(GameObject spawnedGo, GameObject playerObject)
		{
		}
	}
}
