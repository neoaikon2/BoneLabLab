using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PuppetMasta;
using SLZ.AI;
using SLZ.Bonelab;
using SLZ.Data;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;
using SLZ.Marrow.Warehouse;
using Cysharp.Threading.Tasks;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace SLZ.Zones
{
    public class ZoneSpawner : ZoneItem
    {
        public enum modes
        {
            SINGLE = 0,
            EMITTER = 1
        }

        private static ComponentCache<ZoneSpawner> _cache;

        public bool autoStart = true;

        [Tooltip("Short-Circuit the spawning while active")]
        public bool isSpawningAllowed;

        public Spawnable spawnable;

        [Tooltip("Check this to have spawner use array below for random enemy")]
        public bool useRandomCrate;

        [Tooltip("Add crates of all enemies you want to random select from")]
        public Spawnable[] randomeSpawnables;

        [HideInInspector]
        public int amountOfCrates;

        public Spawnable spawnVFX;

        public Vector3 VFXPosition;

        public modes mode;

        [Tooltip("Maximum that can be spawned ")]
        [Header("Emitter Settings")]
        public int max = 1;

        [Tooltip("Maximum spawns that can be alive before spawning stops (0 = Infinity)")]
        public int concurrentAlive = 1;

        [Tooltip("Maximum spawns that can be alive or dead before spawning stops (0 = Infinity), Will require dead spawns to be manually cleaned up before spawning can continue")]
        public int concurrentTotal;

        [Tooltip("Resets when zone is entered by player, set to true if you want the emitter to persist")]
        public bool isResetOnZoneEnable;

        public AudioClip[] spawnClip;

        [Tooltip("Per-Second")]
        public float frequency = 2.0f;

        public Vector3 spawnVelocity;

        public Vector3 spawnAngularVelocity;

        public float minSpawnAngularVelocity;

        public float maxSpawnAngularVelocity;

        public Action<GameObject, GameObject> OnPreSpawnDelegate;

        public Action<GameObject, GameObject> OnSpawnDelegate;

        public Action<GameObject> OnDespawnDelegate;

        public Action OnDeathDelegate;

        public UnityEvent onActivate;

        public UnityEvent onDeactivate;

        public UnityEvent onSpawn;

        public UnityEvent onDeath;

        public UnityEvent onDeathOneShot;

        private bool deathEventSent;

        public Action<ZoneSpawner, AIBrain, EnemyProfile, bool> onSpawnNPCDelegate;

        public Action<BehaviourBaseNav, Rigidbody> OnSpawn_NPC_Launcher;

        private GameObject _playerObject;

        private int _dead;

        private int _total;

        private Coroutine _emitterCoroutine;

        [Tooltip("Used for explicit arena spawns only, useful for enemies spawned on ziplines or at heights, disables damage from collision for x seconds after spawn")]
        [Header("Arena")]
        [SerializeField]
        private float blockCollisionDelay;

        public EnemyProfile currEnemyProfile;

        public bool enableAgentLinking;

        public bool customSpawnerName;

        [HideInInspector]
        public GameObject playerObj;

        [HideInInspector]
        public Arena_GameController arenaGameController;

        [Tooltip("Reference to game obj that will be the spawned npc's parent")]
        public GameObject parentOverride;

#if UNITY_EDITOR

        public static bool showPreviewMesh = true;
        public static bool showColliderBounds = true;
        public static bool showLitMaterialPreview = false;
        private static Material defaultLitMat = null;
#endif

        public static ComponentCache<ZoneSpawner> Cache
        {
            get
            {
                return null;
            }
        }

        public List<GameObject> spawns { get; private set; }

        public bool IsActive { get; private set; }

        public int Alive { get; private set; }

        protected void InitSpawns()
        {
        }

        private void Awake()
        {
        }

        private void OnDestroy()
        {
        }

        public override void OnZoneDisabled(GameObject playerObject)
        {
        }

        public override void OnZoneEnabled(GameObject playerObject)
        {
        }

        public void Activate()
        {
        }

        public void AllowSpawning(bool isAllowed)
        {
        }

        public void SetAutostart(bool isAutoStart)
        {
        }

        public void Deactivate()
        {
        }

        public bool IsUnderMaxSpawn()
        {
            return default(bool);
        }

        public bool IsUnderConcurrentSpawn()
        {
            return default(bool);
        }

        public bool CanSpawn()
        {
            return default(bool);
        }

        public void SetMaxSpawnCount(int val)
        {
        }

        public void TriggerSpawn()
        {
        }

        public void ResetEmitter()
        {
        }

        public void StopEmitterSpawns()
        {
        }

        public void ExplicitFriendlySpawn(Vector3 spawnPos, Quaternion spawnRot, EnemyProfile enemyProfile, BaseEnemyConfig baseConfig = default(BaseEnemyConfig), bool autoDespawn = false, float colDelay = 0f)
        {
        }

        public void ExplicitArenaSpawn(EnemyProfile enemyProfile, bool autoDespawn = false, float colDelay = 0f, bool isFriendly = false)
        {
        }

        private void Spawn(GameObject playerObject)
        {
        }

        public void StartSpawn(GameObject playerObject = default(GameObject))
        {
        }

        private IEnumerator CoStartEmmiter(GameObject playerObject)
        {
            return null;
        }

        public void DisableSpawning()
        {
        }

        public void EnableSpawning()
        {
        }

        private void OnDespawn(GameObject despawnedObject)
        {
        }

        private void OnDeath()
        {
        }

        private void OnResurrect()
        {
        }

        private void RandomizeCrate()
        {
        }

#if UNITY_EDITOR

        static Material mat = null;

        [DrawGizmo(GizmoType.Active | GizmoType.Selected | GizmoType.NonSelected)]
        private static void DrawPreviewGizmo(ZoneSpawner placer, GizmoType gizmoType)
        {
            if (mat == null)
                mat = new Material(Shader.Find("Shader Graphs/Void Glow ShaderGraph"));
            if (!Application.isPlaying && placer.gameObject.scene != default)
            {
                if (showLitMaterialPreview && defaultLitMat == null)
                {
                    defaultLitMat = AssetDatabase.LoadAssetAtPath<Material>("Packages/com.unity.render-pipelines.universal/Runtime/Materials/Lit.mat");
                }
                EditorPreviewMeshGizmo.Draw("PreviewMesh", placer.gameObject, placer.GetCrateReference(), mat, !showPreviewMesh, !showColliderBounds, true);
                placer.EditorUpdateName();
            }
        }

        private void OnValidate()
        {
            if (!Application.isPlaying && gameObject.scene != default)
            {
                EditorUpdateName();
            }
        }

        private void Reset()
        {
            gameObject.name = "Spawnable Placer";
        }

        [ContextMenu("Reset Name")]
        public void ResetName()
        {
            gameObject.name = "Zone Spawner";
        }

        public void EditorUpdateName()
        {
            if (gameObject.name == "Zone Spawner" && AssetWarehouse.ready && !Application.isPlaying && AssetWarehouse.Instance.TryGetCrate(GetCrateReference().Barcode, out var crate))
            {
                gameObject.name = $"Zone Spawner ({crate.Title})";
                GameObjectUtility.EnsureUniqueNameForSibling(gameObject);
            }
        }

        private SpawnableCrateReference GetCrateReference()
        {
            if (AssetWarehouse.ready)
            {
                return spawnable.crateRef;
            }

            return null;
        }


        [MenuItem("GameObject/MarrowSDK/Spawnable Placer", priority = 1)]
        private static void MenuCreatePlacer(MenuCommand menuCommand)
        {
            GameObject go = EditorCreateSpawnablePlacer();

            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Selection.activeObject = go;
        }

        public static void EditorCreateSpawnablePlacer(Barcode barcode, Transform targetTransform, Transform parentTransform = null)
        {
            if (AssetWarehouse.ready && AssetWarehouse.Instance.TryGetCrate<SpawnableCrate>(barcode, out var crate))
            {
                EditorCreateSpawnablePlacer(crate, targetTransform, parentTransform);
            }
        }

        public static void EditorSwapPrefabForSpawnablePlacer(GameObject prefabInstance, bool deleteOriginalGameObject = true)
        {
            if (PrefabUtility.IsOutermostPrefabInstanceRoot(prefabInstance))
            {
                var prefab = PrefabUtility.GetCorrespondingObjectFromSource(prefabInstance);
                if (prefab != null)
                {
                    if (AssetWarehouse.Instance.EditorObjectCrateLookup.TryGetValue(prefab, out Crate prefabCrate) && prefabCrate is SpawnableCrate spawnableCrate)
                    {
                        EditorCreateSpawnablePlacer(spawnableCrate, prefabInstance.transform, prefabInstance.transform.parent);

                        if (deleteOriginalGameObject)
                        {
                            DeleteOriginalGameObject(prefabInstance).Forget();
                        }
                    }
                }
            }
        }

        private static async UniTaskVoid DeleteOriginalGameObject(GameObject go)
        {
            await UniTask.NextFrame();
            Undo.RecordObject(go, $"Delete Spawnable Placer Original GameObject {go.name}");
            UnityEngine.Object.DestroyImmediate(go);
        }

        public static GameObject EditorCreateSpawnablePlacer(SpawnableCrate crate = null, Transform targetTransform = null, Transform parentTransform = null)
        {
            GameObject go = new GameObject("Auto Spawnable Placer", typeof(SpawnableCratePlacer));
            go.transform.localScale = Vector3.one;
            if (parentTransform != null)
                go.transform.parent = parentTransform;
            if (targetTransform != null)
            {
                go.transform.localPosition = targetTransform.localPosition;
                go.transform.localRotation = targetTransform.localRotation;
            }

            var placer = go.GetComponent<SpawnableCratePlacer>();
            if (crate == null)
                placer.spawnableCrateReference = new SpawnableCrateReference();
            else
                placer.spawnableCrateReference = new SpawnableCrateReference(crate.Barcode);
            placer.EditorUpdateName();
            Undo.RegisterCreatedObjectUndo(go, $"Create Spawnable Placer {(crate != null ? crate.Title : "")}");

            return go;
        }


#endif

        public ZoneSpawner()
            : base()
        {
        }
    }
}