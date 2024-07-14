using System;
 
 
 
 
 
using SLZ.Marrow.Utilities;
 
using UltEvents;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

#endif
namespace SLZ.Marrow.Warehouse
{
    [SelectionBase]
    [AddComponentMenu("MarrowSDK/Crate Spawner")]
    [HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Spawnables")]
    public partial class CrateSpawner : MonoBehaviour
    {
        [Tooltip("Drag a Spawnable Crate from the Asset Warehouse or use the picker button to the right to select a Spawnable Crate.")]
        [SerializeField]
        public SpawnableCrateReference spawnableCrateReference = new SpawnableCrateReference(Barcode.EmptyBarcode());
        [SerializeField]
        public CrateQuery crateQuery = new CrateQuery();
        [SerializeField]
        public bool useQuery = false;
        [Tooltip("With Manual Mode enabled, CrateSpawners will *not* activate when their associated Zone is triggered.  Instead, they must be activated through an event, button press or similar action that calls the SpawnSpawnable() method.")]
        [SerializeField]
        public bool manualMode = false;
        [Tooltip("Trigger additional events or actions once the CrateSpawner is activated.")]
        [SerializeField]
        public OnSpawnEvent onSpawnEvent;
#if UNITY_EDITOR
        public static bool showPreviewMesh = true;
        public static bool showColliderBounds = true;
        public static bool showLitMaterialPreview = false;
        private static Material defaultLitMat = null;
        public static float gizmoVisRange = 50f;
#endif
        private SpawnableCrateReference GetCrateReference()
        {
            if (AssetWarehouse.ready)
            {
                if (useQuery)
                {
                    return new SpawnableCrateReference(crateQuery.Barcode);
                }
                else
                {
                    return spawnableCrateReference;
                }
            }

            return null;
        }

        [ContextMenu("Spawn Spawnable")]
        public void SpawnSpawnable()
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.Warehouse.CrateSpawner.SpawnSpawnable()");
            throw new System.NotImplementedException();
        }

        public void SetSpawnable()
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.Warehouse.CrateSpawner.SetSpawnable()");
            throw new System.NotImplementedException();
        }

#if UNITY_EDITOR
        [DrawGizmo(GizmoType.Active | GizmoType.Selected | GizmoType.NonSelected)]
        private static void DrawPreviewGizmo(CrateSpawner spawner, GizmoType gizmoType)
        {
            bool gizmoInRange = Camera.current != null && Vector3.Dot(spawner.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < gizmoVisRange;
            if (!Application.isPlaying && spawner.gameObject.scene != default)
            {
                if (showLitMaterialPreview && defaultLitMat == null)
                {
                    defaultLitMat = AssetDatabase.LoadAssetAtPath<Material>("Packages/com.unity.render-pipelines.universal/Runtime/Materials/Lit.mat");
                }

                EditorPreviewMeshGizmo.Draw("PreviewMesh", spawner.gameObject, spawner.GetCrateReference(), showLitMaterialPreview ? defaultLitMat : MarrowSDK.VoidMaterial, !showPreviewMesh, !showColliderBounds || !gizmoInRange, true);
                spawner.EditorUpdateName();
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
            gameObject.name = "CrateSpawner";
        }

        [ContextMenu("Reset Name")]
        public void ResetName()
        {
            gameObject.name = "CrateSpawner";
        }

        public void EditorUpdateName()
        {
            if (gameObject.name == "CrateSpawner" && AssetWarehouse.ready && !Application.isPlaying && AssetWarehouse.Instance.TryGetCrate(GetCrateReference().Barcode, out var crate))
            {
                gameObject.name = useQuery ? "CrateSpawner (query)" : $"CrateSpawner ({crate.Title})";
                GameObjectUtility.EnsureUniqueNameForSibling(gameObject);
            }
        }

        public static GameObject EditorCreateCrateSpawner(SpawnableCrate crate = null, Transform targetTransform = null, Transform parentTransform = null)
        {
            GameObject go = new GameObject("Auto CrateSpawner", typeof(CrateSpawner));
            go.transform.localScale = Vector3.one;
            if (parentTransform != null)
                go.transform.parent = parentTransform;
            if (targetTransform != null)
            {
                go.transform.localPosition = targetTransform.localPosition;
                go.transform.localRotation = targetTransform.localRotation;
            }

            var spawner = go.GetComponent<CrateSpawner>();
            if (crate == null)
                spawner.spawnableCrateReference = new SpawnableCrateReference();
            else
                spawner.spawnableCrateReference = new SpawnableCrateReference(crate.Barcode);
            spawner.EditorUpdateName();
            Undo.RegisterCreatedObjectUndo(go, $"Create CrateSpawner {(crate != null ? crate.Title : "")}");
            return go;
        }
#endif
    }

    [Serializable]
    public class OnSpawnEvent : UltEvent<CrateSpawner, GameObject>
    {
    }
}