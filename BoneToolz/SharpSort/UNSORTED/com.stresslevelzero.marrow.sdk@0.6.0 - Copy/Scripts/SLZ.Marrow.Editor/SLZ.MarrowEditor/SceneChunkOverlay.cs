#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    [Overlay(typeof(SceneView), id: ID_OVERLAY_SCENECHUNK, displayName: "Scene Chunks")]
    public class SceneChunkOverlay : Overlay, ITransientOverlay
    {
        private const string ID_OVERLAY_SCENECHUNK = "scene-chunk-overlay";
        private string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("079422efa492e3444a9e9ad1e0ee7dab");
        static private Color sceneChunkColor = new Color(0.5f, 0f, 1f, 0.8f);
        static private Color sceneChunkTextColor = new Color(0.5f, 0f, 1f, 1f);
        static private Color sceneChunkColorFade = new Color(0.5f, 0f, 1f, 0.25f);
        static Toggle zoneChunkOverviewToggle;
        public static Toggle zoneChunkCullerHandleToggle;
        static List<SceneChunk> sceneChunksList;
        static List<ZoneCuller> zoneCullersList;
        static List<ZoneCuller> zoneCullersInSceneChunksList;
        static List<SceneChunk> selectedSceneChunks;
        public bool visible
        {
            get
            {
                if (Selection.activeGameObject != null)
                {
                    if (Selection.activeGameObject.GetComponent<SceneChunk>() != null)
                    {
                        sceneChunksList = GameObject.FindObjectsOfType<SceneChunk>().ToList();
                        zoneCullersList = GameObject.FindObjectsOfType<ZoneCuller>().ToList();
                        selectedSceneChunks = new List<SceneChunk>();
                        foreach (GameObject sceneChunkObj in Selection.gameObjects)
                        {
                            SceneChunk selectedSceneChunk = sceneChunkObj.GetComponent<SceneChunk>();
                            if (selectedSceneChunk != null && !selectedSceneChunks.Contains(selectedSceneChunk))
                            {
                                selectedSceneChunks.Add(selectedSceneChunk);
                            }
                        }

                        return true;
                    }
                }

                return false;
            }
        }

        public override VisualElement CreatePanelContent()
        {
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement rootVisualElement = new VisualElement();
            rootVisualElement.Add(tree);
            zoneChunkOverviewToggle = rootVisualElement.Q<Toggle>("zoneChunkOverviewToggle");
            zoneChunkCullerHandleToggle = rootVisualElement.Q<Toggle>("zoneChunkCullerHandleToggle");
            ToggleToolbarDefaults();
            zoneChunkCullerHandleToggle.RegisterValueChangedCallback(evt =>
            {
                if (zoneChunkCullerHandleToggle.value)
                {
                    SceneChunk.showZoneCullerHandles = true;
                }
                else
                {
                    SceneChunk.showZoneCullerHandles = false;
                }
            });
            return rootVisualElement;
        }

        private void ToggleToolbarDefaults()
        {
            zoneChunkOverviewToggle.value = false;
            if (SceneChunk.showZoneCullerHandles)
            {
                zoneChunkCullerHandleToggle.SetValueWithoutNotify(true);
            }
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.Selected)]
        static void DrawPickableSelectedSceneChunkOverviewGizmos(SceneChunk sceneChunk, GizmoType gizmoType)
        {
            if (zoneChunkOverviewToggle.value)
            {
                EnableZoneChunkOverview();
            }
        }

        private static void EnableZoneChunkOverview()
        {
            zoneCullersInSceneChunksList = new List<ZoneCuller>();
            int sceneChunkCounter = 1;
            foreach (SceneChunk sceneChunk in sceneChunksList)
            {
                float slice = (float)sceneChunkCounter / (float)sceneChunksList.Count;
                sceneChunkColor = new Color(Mathf.Clamp(slice, 0, 1), Mathf.Clamp(1 - (slice), 0, 1), Mathf.Clamp(1f / (sceneChunkCounter), 0, 1));
                Color scColor = sceneChunkColor;
                Color.RGBToHSV(scColor, out float H, out float S, out float V);
                float negativeH = (H + 0.5f) % 1f;
                Color negativeColor = Color.HSVToRGB(negativeH, S, V);
                if (sceneChunkCounter % 2 == 0)
                {
                    sceneChunkColor = scColor;
                }
                else
                {
                    sceneChunkColor = negativeColor;
                }

                sceneChunkColorFade = sceneChunkColor;
                if (selectedSceneChunks.Contains(sceneChunk))
                {
                    sceneChunkColorFade.a = 0.5f;
                }
                else
                {
                    sceneChunkColorFade.a = 0.1f;
                }

                sceneChunkTextColor = sceneChunkColor;
                foreach (ZoneCuller zoneCuller in sceneChunk.zoneCullers)
                {
                    if (zoneCuller != null)
                    {
                        zoneCullersInSceneChunksList.Add(zoneCuller);
                        DrawSceneChunkOverviewGizmos(zoneCuller, sceneChunk.gameObject.name);
                    }
                }

                sceneChunkCounter++;
            }

            foreach (ZoneCuller zoneCuller in zoneCullersList)
            {
                sceneChunkColor = new Color(1f, 0f, 0f);
                sceneChunkColorFade = new Color(0f, 0f, 0f, 0.5f);
                sceneChunkTextColor = sceneChunkColor;
                if (zoneCuller != null && !zoneCullersInSceneChunksList.Contains(zoneCuller))
                {
                    DrawSceneChunkOverviewGizmos(zoneCuller, "NOT IN A SCENE CHUNK!");
                }
            }
        }

        private static void DrawSceneChunkOverviewGizmos(ZoneCuller zoneCuller, string sceneChunkText)
        {
            BoxCollider boxCollider = null;
            SphereCollider sphereCollider = null;
            CapsuleCollider capsuleCollider = null;
            MeshCollider meshCollider = null;
            Gizmos.matrix = zoneCuller.transform.localToWorldMatrix;
            Collider zoneCullerCol = zoneCuller.GetComponent<Collider>();
            Vector3 zoneCenter = Vector3.zero;
            if (zoneCullerCol != null && zoneCullerCol is BoxCollider)
            {
                boxCollider = (BoxCollider)zoneCullerCol;
            }
            else if (zoneCullerCol != null && zoneCullerCol is SphereCollider)
            {
                sphereCollider = (SphereCollider)zoneCullerCol;
            }
            else if (zoneCullerCol != null && zoneCullerCol is CapsuleCollider)
            {
                capsuleCollider = (CapsuleCollider)zoneCullerCol;
            }
            else if (zoneCullerCol != null && zoneCullerCol is MeshCollider)
            {
                meshCollider = (MeshCollider)zoneCullerCol;
            }

            if (boxCollider && boxCollider.isTrigger == true)
            {
                zoneCenter = boxCollider.center;
            }
            else if (sphereCollider && sphereCollider.isTrigger == true)
            {
                zoneCenter = sphereCollider.center;
            }
            else if (capsuleCollider && capsuleCollider.isTrigger == true)
            {
                zoneCenter = capsuleCollider.center;
            }
            else if (meshCollider && meshCollider.isTrigger == true)
            {
                Transform[] zonePosList =
                {
                    zoneCullerCol.transform
                };
                zoneCenter = zoneCullerCol.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            Gizmos.color = sceneChunkColor;
            if (boxCollider && boxCollider.enabled && boxCollider.isTrigger)
            {
                Gizmos.DrawWireCube(zoneCenter, Vector3.Scale(zoneCuller.transform.lossyScale, boxCollider.size) * 0.99f);
                Gizmos.color = sceneChunkColorFade;
                Gizmos.DrawCube(zoneCenter, Vector3.Scale(zoneCuller.transform.lossyScale, boxCollider.size));
            }
            else if (sphereCollider && sphereCollider.enabled && sphereCollider.isTrigger)
            {
                Gizmos.DrawWireSphere(zoneCenter, sphereCollider.radius * 0.99f);
                Gizmos.color = sceneChunkColorFade;
                Gizmos.DrawSphere(zoneCenter, sphereCollider.radius);
            }

            if (capsuleCollider && capsuleCollider.enabled && capsuleCollider.isTrigger)
            {
                GameObject capsulePrimitive;
                if (!capsuleCollider.GetComponentInChildren<MeshFilter>())
                {
                    capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                    capsulePrimitive.name = "CapsuleZoneGizmo of " + capsuleCollider.name;
                    Object.DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                    Object.DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                    capsulePrimitive.transform.parent = capsuleCollider.transform;
                }
                else
                {
                    capsulePrimitive = capsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                }

                capsulePrimitive.transform.position = capsuleCollider.transform.position;
                capsulePrimitive.transform.rotation = capsuleCollider.transform.rotation;
                capsulePrimitive.transform.localScale = new Vector3(capsuleCollider.radius * 2, capsuleCollider.height / 2, capsuleCollider.radius * 2);
                Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                Gizmos.DrawWireMesh(mesh, zoneCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale * 0.99f);
                Gizmos.color = sceneChunkColorFade;
                Gizmos.DrawMesh(mesh, zoneCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
            }
            else if (meshCollider && meshCollider.isTrigger)
            {
                Mesh mesh = meshCollider.sharedMesh;
                Gizmos.color = sceneChunkColorFade;
                Gizmos.DrawMesh(mesh, zoneCenter);
            }

            Gizmos.color = sceneChunkTextColor;
            if (Camera.current != null)
            {
                DrawGizmoHelper.DrawText(sceneChunkText, Camera.current.transform.up + new Vector3(0f, 0.5f, 0f) + zoneCenter);
            }
        }

        static Vector3 FindCenterOfSelection(Transform[] transformList)
        {
            if (transformList == null || transformList.Length == 0)
            {
                return Vector3.zero;
            }

            if (transformList.Length == 1)
            {
                return transformList[0].position;
            }

            float minX = Mathf.Infinity;
            float minY = Mathf.Infinity;
            float minZ = Mathf.Infinity;
            float maxX = -Mathf.Infinity;
            float maxY = -Mathf.Infinity;
            float maxZ = -Mathf.Infinity;
            foreach (Transform transformObj in transformList)
            {
                if (transformObj.position.x < minX)
                {
                    minX = transformObj.position.x;
                }

                if (transformObj.position.y < minY)
                {
                    minY = transformObj.position.y;
                }

                if (transformObj.position.z < minZ)
                {
                    minZ = transformObj.position.z;
                }

                if (transformObj.position.x > maxX)
                {
                    maxX = transformObj.position.x;
                }

                if (transformObj.position.y > maxY)
                {
                    maxY = transformObj.position.y;
                }

                if (transformObj.position.z > maxZ)
                {
                    maxZ = transformObj.position.z;
                }
            }

            return new Vector3((minX + maxX) / 2.0f, (minY + maxY) / 2.0f, (minZ + maxZ) / 2.0f);
        }
    }
}
#endif
