using System;
 
 
using SLZ.Marrow.Warehouse;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
    [AddComponentMenu("MarrowSDK/Zones/Scene Chunk")]
    public class SceneChunk : MonoBehaviour
    {
        [Tooltip("Lists the Scenes that make up this SceneChunk.\n\nThe Scene Layers list usually only holds one scene that makes up the SceneChunk that will be dynamically loaded and unloaded, but, if needed, multiple scenes can be listed.")]
        public MarrowScene[] sceneLayers = Array.Empty<MarrowScene>();
        [Tooltip("Lists the ZoneCullers that are in this SceneChunk.\n\nZoneCullers track the entities that enter and leave the Zone's bounds and manage level assets contained within.  Entities and objects will be culled, hidden or despawned based on their state when the Zone and SceneChunk is unloaded.")]
        public ZoneCuller[] zoneCullers = Array.Empty<ZoneCuller>();
        [Space(10)]
        [Tooltip("Trigger events once this SceneChunk is loaded.")]
        public UltEvent onChunkLoad = new();
        [Space(10)]
        [Tooltip("Trigger events once this SceneChunk is loaded.")]
        public UltEvent onChunkUnload = new();
        [HideInInspector]
        public static bool showZoneCullerHandles = false;
    }
}