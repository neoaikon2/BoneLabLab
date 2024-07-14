#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using SLZ.Marrow.Zones;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(SceneChunk))]
    public class SceneChunkEditor : Editor
    {
        static private Color sceneChunkColor = new Color(0.5f, 0f, 1f, 0.8f);
        static private Color sceneChunkColorFade = new Color(0.5f, 0f, 1f, 0.05f);
        List<ZoneCuller> zoneCullersList;
        List<ZoneCuller> zoneCullersInSceneChunksList;
        SceneChunk script;
        [DrawGizmo(GizmoType.Selected)]
        static void DrawSelectedSceneChunkGizmo(SceneChunk sceneChunk, GizmoType gizmoType)
        {
            DrawSelectedSceneChunk(sceneChunk);
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.Selected)]
        static void DrawPickableSelectedSceneChunkGizmo(SceneChunk sceneChunk, GizmoType gizmoType)
        {
            DrawSelectedSceneChunk(sceneChunk);
        }

        public virtual void OnEnable()
        {
            script = (SceneChunk)target;
            zoneCullersList = Object.FindObjectsOfType<ZoneCuller>().ToList();
            zoneCullersInSceneChunksList = new List<ZoneCuller>();
            foreach (SceneChunk sceneChunk in Object.FindObjectsOfType<SceneChunk>())
            {
                foreach (ZoneCuller zoneCuller in sceneChunk.zoneCullers)
                {
                    if (zoneCuller != null && !zoneCullersInSceneChunksList.Contains(zoneCuller))
                    {
                        zoneCullersInSceneChunksList.Add(zoneCuller);
                    }
                }
            }
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("03f2fc96c9ed7e74db7465a8c67312a8");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement validationFeedback = tree.Q<VisualElement>("validationFeedback");
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
            };
            Button marrowDocsButton = tree.Q<Button>("marrowDocsButton");
            marrowDocsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/SceneChunk");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }

        private void OnSceneGUI()
        {
            if (SceneChunk.showZoneCullerHandles)
            {
                foreach (ZoneCuller zoneCuller in zoneCullersList)
                {
                    BoxCollider boxCollider = null;
                    SphereCollider sphereCollider = null;
                    CapsuleCollider capsuleCollider = null;
                    MeshCollider meshCollider = null;
                    Collider selectedZoneCol = zoneCuller.GetComponent<Collider>();
                    Vector3 zoneCenter = Vector3.zero;
                    if (selectedZoneCol != null && selectedZoneCol is BoxCollider)
                    {
                        boxCollider = (BoxCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is SphereCollider)
                    {
                        sphereCollider = (SphereCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is CapsuleCollider)
                    {
                        capsuleCollider = (CapsuleCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is MeshCollider)
                    {
                        meshCollider = (MeshCollider)selectedZoneCol;
                    }

                    if (boxCollider && boxCollider.isTrigger == true)
                    {
                        zoneCenter = selectedZoneCol.transform.TransformPoint(boxCollider.center);
                    }
                    else if (sphereCollider && sphereCollider.isTrigger == true)
                    {
                        zoneCenter = selectedZoneCol.transform.TransformPoint(sphereCollider.center);
                    }
                    else if (capsuleCollider && capsuleCollider.isTrigger == true)
                    {
                        zoneCenter = selectedZoneCol.transform.TransformPoint(capsuleCollider.center);
                    }
                    else if (meshCollider && meshCollider.isTrigger == true)
                    {
                        Transform[] zonePosList =
                        {
                            selectedZoneCol.transform
                        };
                        zoneCenter = FindCenterOfSelection(zonePosList);
                    }

                    if (!script.zoneCullers.Contains(zoneCuller))
                    {
                        if (zoneCuller != null)
                        {
                            if (!zoneCullersInSceneChunksList.Contains(zoneCuller))
                            {
                                GUIStyle scHandleStyleAdd = new GUIStyle();
                                scHandleStyleAdd.normal.textColor = Color.magenta;
                                Handles.color = Color.magenta;
                                bool addZoneCullerHandle = Handles.Button(zoneCenter + new Vector3(0f, -0.5f, 0f), Quaternion.identity, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, Handles.SphereHandleCap);
                                Handles.Label(zoneCenter + new Vector3(0.25f, -0.5f, 0f), "Add to Chunk", scHandleStyleAdd);
                                if (addZoneCullerHandle)
                                {
                                    List<ZoneCuller> zoneCullerList = script.zoneCullers.ToList();
                                    zoneCullerList.Add(zoneCuller);
                                    script.zoneCullers = zoneCullerList.ToArray();
                                    zoneCullersInSceneChunksList.Add(zoneCuller);
                                    Debug.Log("Added ZC: " + zoneCuller.name + " to SceneChunk: " + script.name);
                                }
                            }
                            else
                            {
                                GUIStyle scHandleStyleExists = new GUIStyle();
                                scHandleStyleExists.normal.textColor = Color.gray;
                                Handles.Label(zoneCenter + new Vector3(0.25f, -0.5f, 0f), "Already in Chunk", scHandleStyleExists);
                            }
                        }
                    }
                    else
                    {
                        GUIStyle scHandleStyleRem = new GUIStyle();
                        scHandleStyleRem.normal.textColor = Color.red;
                        Handles.color = Color.red;
                        bool delZoneCullerHandle = Handles.Button(zoneCenter + new Vector3(0f, -0.5f, 0f), Quaternion.identity, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, Handles.SphereHandleCap);
                        Handles.Label(zoneCenter + new Vector3(0.25f, -0.5f, 0f), "Rem from Chunk", scHandleStyleRem);
                        if (delZoneCullerHandle)
                        {
                            List<ZoneCuller> zoneCullerList = script.zoneCullers.ToList();
                            zoneCullerList.Remove(zoneCuller);
                            script.zoneCullers = zoneCullerList.ToArray();
                            zoneCullersInSceneChunksList.Remove(zoneCuller);
                            Debug.Log("Removed ZC: " + zoneCuller.name + " from SceneChunk: " + script.name);
                        }
                    }
                }
            }
        }

        static void DrawSelectedSceneChunk(SceneChunk sceneChunk)
        {
            foreach (ZoneCuller zoneCuller in sceneChunk.zoneCullers)
            {
                if (zoneCuller != null)
                {
                    BoxCollider boxCollider = null;
                    SphereCollider sphereCollider = null;
                    CapsuleCollider capsuleCollider = null;
                    MeshCollider meshCollider = null;
                    Gizmos.matrix = zoneCuller.transform.localToWorldMatrix;
                    Collider selectedZoneCol = zoneCuller.GetComponent<Collider>();
                    Vector3 zoneCenter = Vector3.zero;
                    if (selectedZoneCol != null && selectedZoneCol is BoxCollider)
                    {
                        boxCollider = (BoxCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is SphereCollider)
                    {
                        sphereCollider = (SphereCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is CapsuleCollider)
                    {
                        capsuleCollider = (CapsuleCollider)selectedZoneCol;
                    }
                    else if (selectedZoneCol != null && selectedZoneCol is MeshCollider)
                    {
                        meshCollider = (MeshCollider)selectedZoneCol;
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
                            selectedZoneCol.transform
                        };
                        zoneCenter = zoneCuller.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                    }

                    Gizmos.color = sceneChunkColor;
                    if (boxCollider && boxCollider.enabled && boxCollider.isTrigger)
                    {
                        Gizmos.DrawWireCube(zoneCenter, Vector3.Scale(zoneCuller.transform.lossyScale, boxCollider.size) * 0.95f);
                    }
                    else if (sphereCollider && sphereCollider.enabled && sphereCollider.isTrigger)
                    {
                        Gizmos.DrawWireSphere(zoneCenter, sphereCollider.radius * 0.99f);
                    }
                    else if (capsuleCollider && capsuleCollider.enabled && capsuleCollider.isTrigger)
                    {
                        GameObject capsulePrimitive;
                        if (!capsuleCollider.GetComponentInChildren<MeshFilter>())
                        {
                            capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            capsulePrimitive.name = "CapsuleZoneGizmo of " + capsuleCollider.name;
                            DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                            DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
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
                    }
                    else if (meshCollider && meshCollider.isTrigger)
                    {
                        Mesh mesh = meshCollider.sharedMesh;
                        Gizmos.color = sceneChunkColorFade;
                        Gizmos.DrawWireMesh(mesh, zoneCenter);
                    }
                }
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
