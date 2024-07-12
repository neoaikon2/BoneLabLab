using System.Collections.Generic;
using System.Runtime.InteropServices;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	[AddComponentMenu("MarrowSDK/Player Marker")]
	public class PlayerMarker : MonoBehaviour
	{
		private List<ISpawnListenable> _spawnListeners;

		private bool _hasSpawned;

		private GameObject _playerGameObject;

		private void Awake()
		{
		}

		public void RegisterSpawnEventListener(ISpawnListenable listener)
		{
		}

		public void UnregisterSpawnEventListener(ISpawnListenable listener)
		{
		}

		public void OnPlayerSpawned(GameObject go)
		{
		}

		public void OnPlayerDespawn(GameObject go)
		{
		}

		public bool TryGetPlayerGameObject([Out] GameObject go)
		{
			return default(bool);
		}

		public PlayerMarker()
			: base()
		{
		}
	}
}
