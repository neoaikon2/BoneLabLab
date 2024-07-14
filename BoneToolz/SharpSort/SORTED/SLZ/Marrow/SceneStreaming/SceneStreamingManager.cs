using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	[MarrowPlugin("SLZ.Marrow.SceneStreaming", "Scene Streaming Plugin", "0.0.1")]
	public class SceneStreamingManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		private static SceneStreamingManager _manager;

		private Dictionary<GameObject, SceneChunk> _gameObjectToScenes;

		public static SceneStreamingManager Instance => null;

		public void RegisterSceneZone(GameObject gameObject, SceneChunk sceneChunk)
		{
		}

		public void UnregisterSceneZone(GameObject gameObject)
		{
		}

		internal bool TryGetScenesFromCollider(GameObject gameObject, out SceneChunk sceneChunk)
		{
			sceneChunk = null;
			return false;
		}

		public UniTask OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}
	}
}
