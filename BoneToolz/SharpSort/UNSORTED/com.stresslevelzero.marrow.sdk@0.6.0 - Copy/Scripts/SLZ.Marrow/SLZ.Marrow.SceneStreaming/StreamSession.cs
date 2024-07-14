using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace SLZ.Marrow.SceneStreaming
{
	public class StreamSession
	{
		private readonly LevelCrateReference _level;

		public readonly LevelCrate Level;

		private readonly LevelCrateReference _loadLevel;

		public readonly LevelCrate LoadLevel;

		private readonly SceneLoadQueue _persistentQueue;

		private Action _doLevelLoad;

		private Action _doLevelUnload;

		private bool _willPersistentSceneLoadHappened;

		private Action _willPersistentSceneLoad;

		private bool _doPersistentSceneLoadHappened;

		private Action _doPersistentSceneLoad;

		private List<PlayerMarker> _playerMarkers;

		private int _loadDependencyCount;

		public StreamStatus Status { get; private set; }

		public SceneLoader SceneLoader { get; private set; }

		public StreamSession(LevelCrateReference level, LevelCrateReference loadLevel = null)
		{
		}

		public void RegisterLoadDependency()
		{
		}

		public void UnregisterLoadDependency()
		{
		}

		public void AddDoPersistentLoadCallback(Action cb)
		{
		}

		public void AddWillPersistentLoadCallback(Action cb)
		{
		}

		public void AddDoLevelLoadCallback(Action cb)
		{
		}

		public void AddDoLevelUnloadCallback(Action cb)
		{
		}
		internal UniTask Load()
		{
			return default(UniTask);
		}

		public void End()
		{
		}

		public StreamSession Refresh()
		{
			return null;
		}

		public void RegisterPlayerMarker(PlayerMarker playerMarker)
		{
		}
		private UniTask<Scene> LoadPersistentScenes()
		{
			return default(UniTask<Scene>);
		}
		private UniTask UnloadAllOtherScenes(Scene loadingScene)
		{
			return default(UniTask);
		}
	}
}
