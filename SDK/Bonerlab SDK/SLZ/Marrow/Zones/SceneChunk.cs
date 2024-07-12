using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[AddComponentMenu("MarrowSDK/Zones/Scene Chunk")]
	public class SceneChunk : MonoBehaviour
	{
		[Tooltip("Lists the Scenes that make up this SceneChunk.\n\nThe Scene Layers list usually only holds one scene that makes up the SceneChunk that will be dynamically loaded and unloaded, but, if needed, multiple scenes can be listed.")]
		public MarrowScene[] sceneLayers;

		[Tooltip("Lists the ZoneCullers that are in this SceneChunk.\n\nZoneCullers track the entities that enter and leave the Zone's bounds and manage level assets contained within.  Entities and objects will be culled, hidden or despawned based on their state when the Zone and SceneChunk is unloaded.")]
		public ZoneCuller[] zoneCullers;

		private static bool _isWaitingforLoad;

		[Tooltip("Trigger events once this SceneChunk is loaded.")]
		[Space(10f)]
		public UltEvent onChunkLoad;

		[Tooltip("Trigger events once this SceneChunk is loaded.")]
		[Space(10f)]
		public UltEvent onChunkUnload;

		[HideInInspector]
		public static bool showZoneCullerHandles;

		public bool IsChunkLoaded { get; private set; }

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		public void OnUnload()
		{
		}

		public void OnLoad()
		{
		}

		public void Load()
		{
		}

		public UniTask LoadAsync()
		{
			return default(UniTask);
		}

		public SceneChunk()
			: base()
		{
		}
	}
}
