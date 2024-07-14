#if UNITY_EDITOR
using SLZ.Marrow.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using SLZ.Marrow.Zones;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor.Zones
{
    [CustomEditor(typeof(Zone))]
    [CanEditMultipleObjects]
    public class ZoneGizmosEditor : Editor
    {
        Zone script;
        static private Color sceneChunkColor = new Color(0.5f, 0f, 1f, 0.8f);
        List<GameObject> selectedZoneLinkObjs = new List<GameObject>();
        List<ZoneLink> selectedZoneLinks;
        List<ZoneLink> allZoneLinksList = new List<ZoneLink>();
        static List<ZoneLink> selectedZoneLinksStatic = new List<ZoneLink>();
        public virtual void OnEnable()
        {
            script = (Zone)target;
            selectedZoneLinkObjs = Selection.gameObjects.ToList();
            selectedZoneLinks = new List<ZoneLink>();
            selectedZoneLinksStatic = new List<ZoneLink>();
            foreach (GameObject selectedGO in selectedZoneLinkObjs)
            {
                ZoneLink selZL = selectedGO.GetComponent<ZoneLink>();
                if (selZL != null && !selectedZoneLinks.Contains(selZL))
                {
                    selectedZoneLinks.Add(selZL);
                    selectedZoneLinksStatic.Add(selZL);
                }
            }

            allZoneLinksList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
        }

        private void OnDisable()
        {
            selectedZoneLinksStatic.Clear();
        }

        public override VisualElement CreateInspectorGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("5a921979574c8e5499595875c5826d84");
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement validationFeedback = tree.Q<VisualElement>("validationFeedback");
            IMGUIContainer imguiValidationContainer = tree.Q<IMGUIContainer>("imguiValidationContainer");
            imguiValidationContainer.onGUIHandler = () =>
            {
                Collider zoneCol = script.GetComponent<Collider>();
                BoxCollider boxCollider = null;
                SphereCollider sphereCollider = null;
                CapsuleCollider capsuleCollider = null;
                MeshCollider meshCollider = null;
                if (zoneCol is BoxCollider)
                {
                    boxCollider = (BoxCollider)zoneCol;
                }
                else if (zoneCol is SphereCollider)
                {
                    sphereCollider = (SphereCollider)zoneCol;
                }
                else if (zoneCol is CapsuleCollider)
                {
                    capsuleCollider = (CapsuleCollider)zoneCol;
                }
                else if (zoneCol is MeshCollider)
                {
                    meshCollider = (MeshCollider)zoneCol;
                }

                bool zoneHasTrigger = false;
                bool zoneHasCollider = false;
                if (boxCollider != null)
                {
                    zoneHasCollider = true;
                    if (boxCollider.isTrigger == true)
                    {
                        zoneHasTrigger = true;
                    }
                }

                if (sphereCollider != null)
                {
                    zoneHasCollider = true;
                    if (sphereCollider.isTrigger == true)
                    {
                        zoneHasTrigger = true;
                    }
                }

                if (capsuleCollider != null)
                {
                    zoneHasCollider = true;
                    if (capsuleCollider.isTrigger == true)
                    {
                        zoneHasTrigger = true;
                    }
                }

                if (meshCollider != null)
                {
                    zoneHasCollider = true;
                    if (meshCollider.isTrigger == true)
                    {
                        zoneHasTrigger = true;
                    }
                }

                if (!zoneHasCollider)
                {
                    EditorGUILayout.HelpBox("The Zone MUST have a Box, Sphere, Capsule or Mesh collider.", MessageType.Error);
                }

                if (!zoneHasTrigger)
                {
                    EditorGUILayout.HelpBox("The Zone's trigger MUST be enabled.", MessageType.Error);
                }
            };
            Button marrowDocsButton = tree.Q<Button>("marrowDocsButton");
            marrowDocsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Zones");
            };
            IMGUIContainer imguiInspector = tree.Q<IMGUIContainer>("imguiInspector");
            imguiInspector.onGUIHandler = () =>
            {
                DrawDefaultInspector();
            };
            return tree;
        }

        [DrawGizmo(GizmoType.Selected)]
        static void DrawSelectedZoneGizmo(Zone zone, GizmoType gizmoType)
        {
            if (!Zone.gizmoZonelabMode && MarrowSDKPreferences.gizmoShowZoneGizmos)
            {
                DrawSelectedZone(zone);
            }
        }

        [DrawGizmo(GizmoType.NonSelected)]
        static void DrawNonSelectedZoneGizmo(Zone zone, GizmoType gizmoType)
        {
            if (!Zone.gizmoZonelabMode && MarrowSDKPreferences.gizmoShowZoneGizmos)
            {
                DrawNonSelectedZone(zone);
            }
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.Selected)]
        static void DrawPickableSelectedZoneGizmo(Zone zone, GizmoType gizmoType)
        {
            if (MarrowSDKPreferences.gizmoShowZoneGizmos)
            {
                if (Zone.gizmoZonelabMode || Zone.gizmoZonelabItemMode)
                {
                    DrawSelectedZone(zone);
                }

                Draw1x1ZoneBox(zone);
            }
        }

        [DrawGizmo(GizmoType.Pickable | GizmoType.NonSelected)]
        static void DrawPickableNonSelectedZoneGizmo(Zone zone, GizmoType gizmoType)
        {
            if (MarrowSDKPreferences.gizmoShowZoneGizmos)
            {
                if (Zone.gizmoZonelabMode || Zone.gizmoZonelabItemMode)
                {
                    DrawNonSelectedPickableZone(zone);
                }

                Draw1x1ZoneBox(zone);
            }
        }

        static void Draw1x1ZoneBox(Zone zone)
        {
            if (!MarrowSDKPreferences.gizmoShowZonePickableCube)
                return;
            Gizmos.matrix = zone.transform.localToWorldMatrix;
            Vector3 zoneCenter = Vector3.zero;
            Vector3 zoneSize = Vector3.one;
            ZoneLink zoneLink = zone.GetComponent<ZoneLink>();
            BoxCollider boxCollider = null;
            SphereCollider sphereCollider = null;
            CapsuleCollider capsuleCollider = null;
            MeshCollider meshCollider = null;
            Collider zoneCol = zone.GetComponent<Collider>();
            if (zoneCol is BoxCollider)
            {
                boxCollider = (BoxCollider)zoneCol;
            }
            else if (zoneCol is SphereCollider)
            {
                sphereCollider = (SphereCollider)zoneCol;
            }
            else if (zoneCol is CapsuleCollider)
            {
                capsuleCollider = (CapsuleCollider)zoneCol;
            }
            else if (zoneCol is MeshCollider)
            {
                meshCollider = (MeshCollider)zoneCol;
            }

            bool zoneHasTrigger = false;
            bool zoneHasCollider = false;
            if (boxCollider != null)
            {
                zoneHasCollider = true;
                zoneCenter = boxCollider.center;
                if (boxCollider.isTrigger == true)
                {
                    zoneHasTrigger = true;
                }
            }

            if (sphereCollider != null)
            {
                zoneHasCollider = true;
                zoneCenter = sphereCollider.center;
                if (sphereCollider.isTrigger == true)
                {
                    zoneHasTrigger = true;
                }
            }

            if (capsuleCollider != null)
            {
                zoneHasCollider = true;
                zoneCenter = capsuleCollider.center;
                if (capsuleCollider.isTrigger == true)
                {
                    zoneHasTrigger = true;
                }
            }

            if (meshCollider != null)
            {
                zoneHasCollider = true;
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                if (meshCollider.isTrigger == true)
                {
                    zoneHasTrigger = true;
                }
            }

            if (zoneHasCollider == false)
            {
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            if (boxCollider && boxCollider.isTrigger == true)
            {
                zoneCenter = boxCollider.center;
            }

            if (sphereCollider && sphereCollider.isTrigger == true)
            {
                zoneCenter = sphereCollider.center;
            }

            if (capsuleCollider && capsuleCollider.isTrigger == true)
            {
                zoneCenter = capsuleCollider.center;
            }

            if (meshCollider && meshCollider.isTrigger == true)
            {
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            if (!zoneHasCollider)
            {
                Gizmos.color = new Color(1f, 0f, 0f, 1f);
                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
                {
                    DrawGizmoHelper.DrawText("ZONE MUST HAVE A COLLIDER", zone.transform.position + new Vector3(0f, 0.5f, 0f));
                }

                Gizmos.color = new Color(1f, 1f, 1f, 1f);
            }

            if (!zoneHasTrigger)
            {
                Gizmos.color = new Color(1f, 0f, 0f, 1f);
                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
                {
                    DrawGizmoHelper.DrawText(zone.name + " MUST BE A TRIGGER", zoneCenter + new Vector3(0f, 0.75f, 0f));
                }

                Gizmos.color = new Color(1f, 1f, 1f, 1f);
            }

            if (boxCollider && boxCollider.enabled && boxCollider.isTrigger)
            {
                zoneSize = boxCollider.size;
            }
            else if (sphereCollider && sphereCollider.enabled && sphereCollider.isTrigger)
            {
                zoneSize = new Vector3(sphereCollider.radius, sphereCollider.radius, sphereCollider.radius);
            }
            else if (capsuleCollider && capsuleCollider.enabled && capsuleCollider.isTrigger)
            {
                zoneSize = new Vector3(capsuleCollider.radius, capsuleCollider.radius, capsuleCollider.radius);
            }
            else if (meshCollider && meshCollider.isTrigger)
            {
                MeshFilter meshFilter = zone.GetComponent<MeshFilter>();
                if (meshFilter != null)
                {
                    Bounds zoneMeshBounds = meshFilter.sharedMesh.bounds;
                    zoneSize = zoneMeshBounds.extents;
                }
            }

            if (zoneLink)
            {
                if (zoneSize.x > 2f && zoneSize.y > 2f && zoneSize.z > 2f)
                {
                    Gizmos.color = new Color(0.5f, 0.5f, 0.5f, MarrowSDKPreferences.gizmoZoneOpacity);
                    Gizmos.DrawCube(zoneCenter, Vector3.one);
                    Gizmos.color = new Color(0, 0.75f, 0, 0.5f);
                    Gizmos.DrawWireCube(zoneCenter, Vector3.one + Vector3.one * 0.01f);
                }
                else
                {
                    Gizmos.color = new Color(0.5f, 0.5f, 0.5f, MarrowSDKPreferences.gizmoZoneOpacity);
                    Gizmos.DrawCube(zoneCenter, new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.1f);
                    Gizmos.color = new Color(0, 0.75f, 0, 0.5f);
                    Gizmos.DrawWireCube(zoneCenter, new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.1f + new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.01f);
                }
            }
            else
            {
                if (zoneSize.x > 1f && zoneSize.y > 1f && zoneSize.z > 1f)
                {
                    Gizmos.color = new Color(0.8f, 0.4f, 0f, MarrowSDKPreferences.gizmoZoneOpacity);
                    Gizmos.DrawCube(zoneCenter, Vector3.one);
                    Gizmos.color = new Color(0.8f, 0.8f, 0f, 0.5f);
                    Gizmos.DrawWireCube(zoneCenter, Vector3.one + Vector3.one * 0.01f);
                }
                else
                {
                    Gizmos.color = new Color(0.8f, 0.4f, 0f, MarrowSDKPreferences.gizmoZoneOpacity);
                    Gizmos.DrawCube(zoneCenter, new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.1f);
                    Gizmos.color = new Color(0.8f, 0.8f, 0f, 0.5f);
                    Gizmos.DrawWireCube(zoneCenter, new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.1f + new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.01f);
                }
            }
        }

        static void DrawSelectedZone(Zone zone)
        {
            ZoneLink zLink = zone.GetComponent<ZoneLink>();
            Collider zoneCol = zone.GetComponent<Collider>();
            BoxCollider boxCollider = null;
            SphereCollider sphereCollider = null;
            CapsuleCollider capsuleCollider = null;
            MeshCollider meshCollider = null;
            Gizmos.matrix = zone.transform.localToWorldMatrix;
            Vector3 zoneCenter = Vector3.zero;
            if (zoneCol is BoxCollider)
            {
                boxCollider = (BoxCollider)zoneCol;
                zoneCenter = boxCollider.center;
            }
            else if (zoneCol is SphereCollider)
            {
                sphereCollider = (SphereCollider)zoneCol;
                zoneCenter = sphereCollider.center;
            }
            else if (zoneCol is CapsuleCollider)
            {
                capsuleCollider = (CapsuleCollider)zoneCol;
                zoneCenter = capsuleCollider.center;
            }
            else if (zoneCol is MeshCollider)
            {
                meshCollider = (MeshCollider)zoneCol;
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            if (boxCollider && boxCollider.enabled && boxCollider.isTrigger)
            {
                Gizmos.color = new Color(0f, 0.75f, 0f, MarrowSDKPreferences.gizmoZoneOpacity);
                Gizmos.DrawCube(zoneCenter, boxCollider.size);
            }
            else if (sphereCollider && sphereCollider.enabled && sphereCollider.isTrigger)
            {
                Gizmos.color = new Color(0f, 0.75f, 0f, MarrowSDKPreferences.gizmoZoneOpacity);
                Gizmos.DrawSphere(zoneCenter, sphereCollider.radius);
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
                Gizmos.color = new Color(0, 0.75f, 0, MarrowSDKPreferences.gizmoZoneOpacity);
                Gizmos.DrawMesh(mesh, zoneCenter, Quaternion.identity, capsulePrimitive.transform.localScale);
            }
            else if (meshCollider && meshCollider.isTrigger)
            {
                Mesh mesh = meshCollider.sharedMesh;
                Gizmos.color = new Color(0, 0.75f, 0, MarrowSDKPreferences.gizmoZoneOpacity);
                Gizmos.DrawMesh(mesh, zoneCenter);
            }

            if (MarrowSDKPreferences.gizmoShowZoneNames && Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
            {
                Gizmos.color = Color.white;
                DrawGizmoHelper.DrawText(zone.gameObject.name, zoneCenter + Camera.current.transform.up);
            }

            if (MarrowSDKPreferences.gizmoZoneActivators && zLink != null)
            {
                Gizmos.color = new Color(1f, 1f, 1f, 1f);
                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
                {
                    string activatorsString = "Activators: ";
                    foreach (SLZ.Marrow.Warehouse.TagQuery marrowTag in zLink.activatorTags.Tags)
                    {
                        if (marrowTag != null && marrowTag.BoneTag != null && marrowTag.BoneTag.DataCard != null)
                        {
                            activatorsString += marrowTag.BoneTag.DataCard.Title + ", ";
                        }
                    }

                    if (activatorsString == "Activators: ")
                    {
                        activatorsString += "None";
                    }
                    else
                    {
                        activatorsString = activatorsString.Remove(activatorsString.Length - 2);
                    }

                    Gizmos.color = Color.yellow;
                    DrawGizmoHelper.DrawText(activatorsString, zoneCenter + Camera.current.transform.up + new Vector3(0f, -0.5f, 0f));
                }
            }

            if (MarrowSDKPreferences.gizmoShowZoneLinks && zLink != null && zLink.zoneLinks != null && Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange * 2)
            {
                bool zoneIsLinkedToSelected = false;
                if (zLink.zoneLinks == null || zLink.zoneLinks.Length == 0)
                {
                    return;
                }

                foreach (ZoneLink zonelink in zLink.zoneLinks)
                {
                    if (zonelink != null)
                    {
                        Collider zoneLinkCol = zonelink.GetComponent<Collider>();
                        BoxCollider linkBoxCollider = null;
                        SphereCollider linkSphereCollider = null;
                        CapsuleCollider linkCapsuleCollider = null;
                        MeshCollider linkMeshCollider = null;
                        Vector3 zonelinkCenter = Vector3.zero;
                        if (zoneLinkCol is BoxCollider)
                        {
                            linkBoxCollider = (BoxCollider)zoneLinkCol;
                            zonelinkCenter = zone.transform.InverseTransformPoint(zonelink.transform.TransformPoint(linkBoxCollider.center));
                        }
                        else if (zoneLinkCol is SphereCollider)
                        {
                            linkSphereCollider = (SphereCollider)zoneLinkCol;
                            zonelinkCenter = zone.transform.InverseTransformPoint(zonelink.transform.TransformPoint(linkSphereCollider.center));
                        }
                        else if (zoneLinkCol is CapsuleCollider)
                        {
                            linkCapsuleCollider = (CapsuleCollider)zoneLinkCol;
                            zonelinkCenter = zone.transform.InverseTransformPoint(zonelink.transform.TransformPoint(linkCapsuleCollider.center));
                        }
                        else if (zoneLinkCol is MeshCollider)
                        {
                            linkMeshCollider = (MeshCollider)zoneLinkCol;
                            Transform[] zonePosList =
                            {
                                zonelink.transform
                            };
                            zonelinkCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                        }

                        foreach (ZoneLink selectedZoneLink in selectedZoneLinksStatic)
                        {
                            if (selectedZoneLink == zonelink)
                            {
                                zoneIsLinkedToSelected = true;
                            }
                        }

                        if (MarrowSDKPreferences.gizmoZoneLinkLines && zoneIsLinkedToSelected)
                        {
                            Gizmos.color = new Color(0f, 0.75f, 1f, 0.75f);
                            Gizmos.DrawSphere(zoneCenter, 0.25f);
                            Gizmos.DrawLine(zoneCenter, zonelinkCenter);
                        }
                    }
                }
            }

            if (MarrowSDKPreferences.gizmoSceneChunkGizmos && Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
            {
                ZoneCuller selectedZoneCuller = zone.GetComponent<ZoneCuller>();
                ZoneChunkLoader selectedZoneChunkLoader = zone.GetComponent<ZoneChunkLoader>();
                if (selectedZoneCuller != null && selectedZoneChunkLoader != null && selectedZoneChunkLoader.chunks != null)
                {
                    foreach (SceneChunk sceneChunk in selectedZoneChunkLoader.chunks)
                    {
                        if (sceneChunk != null && selectedZoneChunkLoader.chunks != null)
                        {
                            foreach (ZoneCuller zoneCuller in sceneChunk.zoneCullers)
                            {
                                if (zoneCuller != null && sceneChunk.zoneCullers.Contains(selectedZoneCuller))
                                {
                                    Gizmos.matrix = zoneCuller.transform.localToWorldMatrix;
                                    Collider zcZoneCol = zoneCuller.GetComponent<Collider>();
                                    BoxCollider zcBoxCollider = null;
                                    SphereCollider zcSphereCollider = null;
                                    CapsuleCollider zcCapsuleCollider = null;
                                    MeshCollider zcMeshCollider = null;
                                    Vector3 zcZoneCenter = Vector3.zero;
                                    Vector3 zoneSize = Vector3.one;
                                    if (zcZoneCol is BoxCollider)
                                    {
                                        zcBoxCollider = (BoxCollider)zcZoneCol;
                                        zcZoneCenter = zcBoxCollider.center;
                                        zoneSize = zcBoxCollider.size;
                                    }
                                    else if (zcZoneCol is SphereCollider)
                                    {
                                        zcSphereCollider = (SphereCollider)zcZoneCol;
                                        zcZoneCenter = zcSphereCollider.center;
                                        zoneSize = new Vector3(zcSphereCollider.radius, zcSphereCollider.radius, zcSphereCollider.radius);
                                    }
                                    else if (zcZoneCol is CapsuleCollider)
                                    {
                                        zcCapsuleCollider = (CapsuleCollider)zcZoneCol;
                                        zcZoneCenter = zcCapsuleCollider.center;
                                        zoneSize = new Vector3(zcCapsuleCollider.radius, zcCapsuleCollider.radius, zcCapsuleCollider.radius);
                                    }
                                    else if (zcZoneCol is MeshCollider)
                                    {
                                        zcMeshCollider = (MeshCollider)zcZoneCol;
                                        Transform[] zonePosList =
                                        {
                                            zoneCuller.transform
                                        };
                                        zcZoneCenter = zoneCuller.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                                        MeshFilter meshFilter = zoneCuller.GetComponent<MeshFilter>();
                                        if (meshFilter != null)
                                        {
                                            Bounds zoneMeshBounds = meshFilter.sharedMesh.bounds;
                                            zoneSize = zoneMeshBounds.extents;
                                        }
                                    }

                                    Gizmos.color = sceneChunkColor;
                                    if (zoneCuller != null)
                                    {
                                        if (zoneSize.x > 2f && zoneSize.y > 2f && zoneSize.z > 2f)
                                        {
                                            Gizmos.DrawWireCube(zcZoneCenter, new Vector3(1.2f, 1.2f, 1.2f));
                                        }
                                        else
                                        {
                                            Gizmos.DrawWireCube(zcZoneCenter, new Vector3(zoneSize.x, zoneSize.y, zoneSize.z) * 0.1f);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void DrawNonSelectedZone(Zone zone)
        {
            if (!MarrowSDKPreferences.gizmoShowZoneGizmos)
            {
                return;
            }

            BoxCollider linkBoxCollider = null;
            SphereCollider linkSphereCollider = null;
            CapsuleCollider linkCapsuleCollider = null;
            MeshCollider linkMeshCollider = null;
            Vector3 zonelinkCenter = Vector3.zero;
            Vector3 zonelinkCenterWorld = Vector3.zero;
            Gizmos.matrix = zone.transform.localToWorldMatrix;
            Collider zoneCol = zone.GetComponent<Collider>();
            ZoneLink zonelink = zone.GetComponent<ZoneLink>();
            if (zoneCol is BoxCollider)
            {
                linkBoxCollider = (BoxCollider)zoneCol;
            }
            else if (zoneCol is SphereCollider)
            {
                linkSphereCollider = (SphereCollider)zoneCol;
            }
            else if (zoneCol is CapsuleCollider)
            {
                linkCapsuleCollider = (CapsuleCollider)zoneCol;
            }
            else if (zoneCol is MeshCollider)
            {
                linkMeshCollider = (MeshCollider)zoneCol;
            }

            if (linkBoxCollider && linkBoxCollider.isTrigger == true)
            {
                zonelinkCenter = linkBoxCollider.center;
            }
            else if (linkSphereCollider && linkSphereCollider.isTrigger == true)
            {
                zonelinkCenter = linkSphereCollider.center;
            }
            else if (linkCapsuleCollider && linkCapsuleCollider.isTrigger == true)
            {
                zonelinkCenter = linkCapsuleCollider.center;
            }
            else if (linkMeshCollider && linkMeshCollider.isTrigger == true)
            {
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zonelinkCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            zonelinkCenterWorld = zone.transform.TransformPoint(zonelinkCenter);
            if (zonelink != null)
            {
                if (zonelink.zoneLinks == null)
                {
                    zonelink.zoneLinks = new List<ZoneLink>().ToArray();
                }

                bool zoneIsLinkedToSelected = false;
                foreach (ZoneLink zLink in zonelink.zoneLinks)
                {
                    if (zLink != null)
                    {
                        foreach (ZoneLink selectedZoneLink in selectedZoneLinksStatic)
                        {
                            if (selectedZoneLink == zLink)
                            {
                                zoneIsLinkedToSelected = true;
                                BoxCollider selectedBoxCol = null;
                                SphereCollider selectedSphereCol = null;
                                CapsuleCollider selectedCapsuleCol = null;
                                MeshCollider selectedMeshCol = null;
                                Collider selectedZoneCol = selectedZoneLink.GetComponent<Collider>();
                                Vector3 selectedZoneCenter = Vector3.zero;
                                if (selectedZoneCol != null && selectedZoneCol is BoxCollider)
                                {
                                    selectedBoxCol = (BoxCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedBoxCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is SphereCollider)
                                {
                                    selectedSphereCol = (SphereCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedSphereCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is CapsuleCollider)
                                {
                                    selectedCapsuleCol = (CapsuleCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedCapsuleCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is MeshCollider)
                                {
                                    selectedMeshCol = (MeshCollider)selectedZoneCol;
                                    Transform[] zonePosList =
                                    {
                                        selectedZoneLink.transform
                                    };
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                                }

                                if (MarrowSDKPreferences.gizmoZoneLinkLines && MarrowSDKPreferences.gizmoShowZoneLinks)
                                {
                                    Gizmos.color = new Color(0f, 0.75f, 1f, 0.75f);
                                    Gizmos.DrawSphere(zonelinkCenter, 0.25f);
                                    Gizmos.DrawLine(zonelinkCenter, selectedZoneCenter);
                                }
                            }
                        }
                    }
                }

                if (zoneIsLinkedToSelected && MarrowSDKPreferences.gizmoShowZoneLinks)
                {
                    if (linkBoxCollider && linkBoxCollider.enabled)
                    {
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireCube(zonelinkCenter, linkBoxCollider.size);
                        Gizmos.color = new Color(0f, 0f, 0.25f, MarrowSDKPreferences.gizmoZoneOpacity * 0.75f);
                        Gizmos.DrawCube(zonelinkCenter, linkBoxCollider.size);
                    }
                    else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                    {
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                        Gizmos.color = new Color(0f, 0f, 0.25f, MarrowSDKPreferences.gizmoZoneOpacity * 0.75f);
                        Gizmos.DrawSphere(zonelinkCenter, linkSphereCollider.radius);
                    }

                    if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                    {
                        GameObject capsulePrimitive;
                        if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                        {
                            capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                            DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                            DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                            capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                        }
                        else
                        {
                            capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                        }

                        capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                        capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                        capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                        Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                        Gizmos.color = new Color(0f, 0f, 1f, 0.25f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.localScale);
                        Gizmos.color = new Color(0f, 0f, 0.25f, MarrowSDKPreferences.gizmoZoneOpacity * 0.75f);
                        Gizmos.DrawMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.localScale);
                    }
                    else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                    {
                        Mesh mesh = linkMeshCollider.sharedMesh;
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                        Gizmos.color = new Color(0, 0f, 0.25f, MarrowSDKPreferences.gizmoZoneOpacity);
                        Gizmos.DrawMesh(mesh, zonelinkCenter);
                    }
                }
                else
                {
                    if (linkBoxCollider && linkBoxCollider.enabled && linkBoxCollider.isTrigger)
                    {
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireCube(zonelinkCenter, linkBoxCollider.size);
                    }
                    else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                    {
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                    }
                    else if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                    {
                        GameObject capsulePrimitive;
                        if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                        {
                            capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                            DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                            DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                            capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                        }
                        else
                        {
                            capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                        }

                        capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                        capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                        capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                        Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.localScale);
                    }
                    else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                    {
                        Mesh mesh = linkMeshCollider.sharedMesh;
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                    }
                }
            }
            else
            {
                if (linkBoxCollider && linkBoxCollider.enabled && linkBoxCollider.isTrigger)
                {
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireCube(zonelinkCenter, linkBoxCollider.size);
                }
                else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                {
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                }
                else if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                {
                    GameObject capsulePrimitive;
                    if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                    {
                        capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                        capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                        DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                        DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                        capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                    }
                    else
                    {
                        capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                    }

                    capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                    capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                    capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                    Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.localScale);
                }
                else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                {
                    Mesh mesh = linkMeshCollider.sharedMesh;
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                }
            }

            if (MarrowSDKPreferences.gizmoShowZoneNames)
            {
                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
                {
                    Gizmos.color = Color.gray;
                    DrawGizmoHelper.DrawText(zone.gameObject.name, zonelinkCenter + Camera.current.transform.up);
                }
            }
        }

        static void DrawNonSelectedPickableZone(Zone zone)
        {
            Color zonePickableColor = Color.yellow;
            zonePickableColor.a = MarrowSDKPreferences.gizmoZoneOpacity * 0.75f;
            BoxCollider linkBoxCollider = null;
            SphereCollider linkSphereCollider = null;
            CapsuleCollider linkCapsuleCollider = null;
            MeshCollider linkMeshCollider = null;
            Gizmos.matrix = zone.transform.localToWorldMatrix;
            Vector3 zonelinkCenter = Vector3.zero;
            Collider zoneCol = zone.GetComponent<Collider>();
            ZoneLink zonelink = zone.GetComponent<ZoneLink>();
            if (zoneCol is BoxCollider)
            {
                linkBoxCollider = (BoxCollider)zoneCol;
            }
            else if (zoneCol is SphereCollider)
            {
                linkSphereCollider = (SphereCollider)zoneCol;
            }
            else if (zoneCol is CapsuleCollider)
            {
                linkCapsuleCollider = (CapsuleCollider)zoneCol;
            }
            else if (zoneCol is MeshCollider)
            {
                linkMeshCollider = (MeshCollider)zoneCol;
            }

            if (linkBoxCollider && linkBoxCollider.isTrigger == true)
            {
                zonelinkCenter = linkBoxCollider.center;
            }
            else if (linkSphereCollider && linkSphereCollider.isTrigger == true)
            {
                zonelinkCenter = linkSphereCollider.center;
            }
            else if (linkCapsuleCollider && linkCapsuleCollider.isTrigger == true)
            {
                zonelinkCenter = linkCapsuleCollider.center;
            }
            else if (linkMeshCollider && linkMeshCollider.isTrigger == true)
            {
                Transform[] zonePosList =
                {
                    zone.transform
                };
                zonelinkCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
            }

            if (zonelink != null)
            {
                if (zonelink.zoneLinks == null)
                {
                    zonelink.zoneLinks = new List<ZoneLink>().ToArray();
                }

                bool zoneIsLinkedToSelected = false;
                foreach (ZoneLink zLink in zonelink.zoneLinks)
                {
                    if (zLink != null)
                    {
                        foreach (ZoneLink selectedZoneLink in selectedZoneLinksStatic)
                        {
                            if (selectedZoneLink == zLink)
                            {
                                zoneIsLinkedToSelected = true;
                                BoxCollider selectedBoxCol = null;
                                SphereCollider selectedSphereCol = null;
                                CapsuleCollider selectedCapsuleCol = null;
                                MeshCollider selectedMeshCol = null;
                                Collider selectedZoneCol = selectedZoneLink.GetComponent<Collider>();
                                Vector3 selectedZoneCenter = Vector3.zero;
                                if (selectedZoneCol != null && selectedZoneCol is BoxCollider)
                                {
                                    selectedBoxCol = (BoxCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedBoxCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is SphereCollider)
                                {
                                    selectedSphereCol = (SphereCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedSphereCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is CapsuleCollider)
                                {
                                    selectedCapsuleCol = (CapsuleCollider)selectedZoneCol;
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(selectedZoneLink.transform.TransformPoint(selectedCapsuleCol.center));
                                }
                                else if (selectedZoneCol != null && selectedZoneCol is MeshCollider)
                                {
                                    selectedMeshCol = (MeshCollider)selectedZoneCol;
                                    Transform[] zonePosList =
                                    {
                                        selectedZoneLink.transform
                                    };
                                    selectedZoneCenter = zone.transform.InverseTransformPoint(FindCenterOfSelection(zonePosList));
                                }

                                if (MarrowSDKPreferences.gizmoZoneLinkLines)
                                {
                                    Gizmos.color = new Color(0f, 0.75f, 1f, 0.75f);
                                    Gizmos.DrawSphere(zonelinkCenter, 0.25f);
                                    Gizmos.DrawLine(zonelinkCenter, selectedZoneCenter);
                                }
                            }
                        }
                    }
                }

                if (zoneIsLinkedToSelected)
                {
                    if (linkBoxCollider && linkBoxCollider.enabled)
                    {
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireCube(zonelinkCenter, Vector3.Scale(zonelink.transform.lossyScale, linkBoxCollider.size));
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawCube(zonelinkCenter, Vector3.Scale(zonelink.transform.lossyScale, linkBoxCollider.size));
                    }
                    else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                    {
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawSphere(zonelinkCenter, linkSphereCollider.radius);
                    }

                    if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                    {
                        GameObject capsulePrimitive;
                        if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                        {
                            capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                            DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                            DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                            capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                        }
                        else
                        {
                            capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                        }

                        capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                        capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                        capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                        Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                        Gizmos.color = new Color(0f, 0f, 1f, 0.25f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                    }
                    else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                    {
                        Mesh mesh = linkMeshCollider.sharedMesh;
                        Gizmos.color = new Color(0f, 0f, 1f, 0.5f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawMesh(mesh, zonelinkCenter);
                    }
                }
                else
                {
                    if (linkBoxCollider && linkBoxCollider.enabled && linkBoxCollider.isTrigger)
                    {
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireCube(zonelinkCenter, Vector3.Scale(zone.transform.lossyScale, linkBoxCollider.size));
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawCube(zonelinkCenter, Vector3.Scale(zone.transform.lossyScale, linkBoxCollider.size));
                    }
                    else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                    {
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawSphere(zonelinkCenter, linkSphereCollider.radius);
                    }
                    else if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                    {
                        GameObject capsulePrimitive;
                        if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                        {
                            capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                            DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                            DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                            capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                        }
                        else
                        {
                            capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                        }

                        capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                        capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                        capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                        Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                    }
                    else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                    {
                        Mesh mesh = linkMeshCollider.sharedMesh;
                        Gizmos.color = new Color(1, 1, 1, 0.05f);
                        Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                        Gizmos.color = zonePickableColor;
                        Gizmos.DrawMesh(mesh, zonelinkCenter);
                    }
                }
            }
            else
            {
                if (linkBoxCollider && linkBoxCollider.enabled && linkBoxCollider.isTrigger)
                {
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireCube(zonelinkCenter, Vector3.Scale(zone.transform.lossyScale, linkBoxCollider.size));
                    Gizmos.color = zonePickableColor;
                    Gizmos.DrawCube(zonelinkCenter, Vector3.Scale(zone.transform.lossyScale, linkBoxCollider.size));
                }
                else if (linkSphereCollider && linkSphereCollider.enabled && linkSphereCollider.isTrigger)
                {
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireSphere(zonelinkCenter, linkSphereCollider.radius);
                    Gizmos.color = zonePickableColor;
                    Gizmos.DrawSphere(zonelinkCenter, linkSphereCollider.radius);
                }
                else if (linkCapsuleCollider && linkCapsuleCollider.enabled && linkCapsuleCollider.isTrigger)
                {
                    GameObject capsulePrimitive;
                    if (!linkCapsuleCollider.GetComponentInChildren<MeshFilter>())
                    {
                        capsulePrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                        capsulePrimitive.name = "CapsuleZoneGizmo of " + linkCapsuleCollider.name;
                        DestroyImmediate(capsulePrimitive.GetComponent<CapsuleCollider>());
                        DestroyImmediate(capsulePrimitive.GetComponent<MeshRenderer>());
                        capsulePrimitive.transform.parent = linkCapsuleCollider.transform;
                    }
                    else
                    {
                        capsulePrimitive = linkCapsuleCollider.GetComponentInChildren<MeshFilter>().gameObject;
                    }

                    capsulePrimitive.transform.position = linkCapsuleCollider.transform.position;
                    capsulePrimitive.transform.rotation = linkCapsuleCollider.transform.rotation;
                    capsulePrimitive.transform.localScale = new Vector3(linkCapsuleCollider.radius * 2, linkCapsuleCollider.height / 2, linkCapsuleCollider.radius * 2);
                    Mesh mesh = capsulePrimitive.GetComponent<MeshFilter>().sharedMesh;
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                    Gizmos.color = zonePickableColor;
                    Gizmos.DrawMesh(mesh, zonelinkCenter, Quaternion.identity, capsulePrimitive.transform.lossyScale);
                }
                else if (linkMeshCollider && linkMeshCollider.enabled && linkMeshCollider.isTrigger)
                {
                    Mesh mesh = linkMeshCollider.sharedMesh;
                    Gizmos.color = new Color(1, 1, 1, 0.05f);
                    Gizmos.DrawWireMesh(mesh, zonelinkCenter);
                    Gizmos.color = zonePickableColor;
                    Gizmos.DrawMesh(mesh, zonelinkCenter);
                }
            }

            if (MarrowSDKPreferences.gizmoShowZoneNames)
            {
                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zone.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < MarrowSDKPreferences.gizmoShowZoneLabelsRange)
                {
                    Gizmos.color = Color.white;
                    DrawGizmoHelper.DrawText(zone.gameObject.name, zonelinkCenter + Camera.current.transform.up);
                }
            }
        }

        private void OnSceneGUI()
        {
            if (Zone.gizmoZoneLinkHandles)
            {
                ShowZoneLinkHandles();
            }
        }

        private void ShowZoneLinkHandles()
        {
            foreach (ZoneLink zoneLink in allZoneLinksList)
            {
                if (selectedZoneLinks.Contains(zoneLink))
                {
                    continue;
                }

                if (Camera.current != null && Camera.current == SceneView.lastActiveSceneView.camera && Vector3.Dot(zoneLink.transform.position - Camera.current.transform.position, Camera.current.transform.forward) < Zone.gizmoZoneLinkHandlesRange)
                {
                    BoxCollider boxCollider = null;
                    SphereCollider sphereCollider = null;
                    CapsuleCollider capsuleCollider = null;
                    MeshCollider meshCollider = null;
                    Collider zoneCol = zoneLink.GetComponent<Collider>();
                    if (zoneCol != null && zoneCol is BoxCollider)
                    {
                        boxCollider = (BoxCollider)zoneCol;
                    }
                    else if (zoneCol != null && zoneCol is SphereCollider)
                    {
                        sphereCollider = (SphereCollider)zoneCol;
                    }
                    else if (zoneCol != null && zoneCol is CapsuleCollider)
                    {
                        capsuleCollider = (CapsuleCollider)zoneCol;
                    }
                    else if (zoneCol != null && zoneCol is MeshCollider)
                    {
                        meshCollider = (MeshCollider)zoneCol;
                    }

                    Vector3 zoneCenter = Vector3.zero;
                    if (boxCollider && boxCollider.isTrigger == true)
                    {
                        zoneCenter = zoneLink.transform.TransformPoint(boxCollider.center);
                    }
                    else if (sphereCollider && sphereCollider.isTrigger == true)
                    {
                        zoneCenter = zoneLink.transform.TransformPoint(sphereCollider.center);
                    }
                    else if (capsuleCollider && capsuleCollider.isTrigger == true)
                    {
                        zoneCenter = zoneLink.transform.TransformPoint(capsuleCollider.center);
                    }
                    else if (meshCollider && meshCollider.isTrigger == true)
                    {
                        Transform[] zonePosList =
                        {
                            zoneLink.transform
                        };
                        zoneCenter = FindCenterOfSelection(zonePosList);
                    }

                    foreach (ZoneLink selectedZoneLink in selectedZoneLinks)
                    {
                        if (selectedZoneLink.zoneLinks == null)
                        {
                            selectedZoneLink.zoneLinks = new List<ZoneLink>().ToArray();
                        }

                        if (selectedZoneLink != null && zoneLink != null && selectedZoneLink.zoneLinks != null)
                        {
                            Vector3 selectedZoneCenter = Vector3.zero;
                            BoxCollider selectedBoxCollider = null;
                            SphereCollider selectedSphereCollider = null;
                            CapsuleCollider selectedCapsuleCollider = null;
                            MeshCollider selectedMeshCollider = null;
                            Collider selectedZoneCol = selectedZoneLink.GetComponent<Collider>();
                            if (selectedZoneCol != null && selectedZoneCol is BoxCollider)
                            {
                                selectedBoxCollider = (BoxCollider)selectedZoneCol;
                            }
                            else if (selectedZoneCol != null && selectedZoneCol is SphereCollider)
                            {
                                selectedSphereCollider = (SphereCollider)selectedZoneCol;
                            }
                            else if (selectedZoneCol != null && selectedZoneCol is CapsuleCollider)
                            {
                                selectedCapsuleCollider = (CapsuleCollider)selectedZoneCol;
                            }
                            else if (selectedZoneCol != null && selectedZoneCol is MeshCollider)
                            {
                                selectedMeshCollider = (MeshCollider)selectedZoneCol;
                            }

                            if (selectedBoxCollider && selectedBoxCollider.isTrigger == true)
                            {
                                selectedZoneCenter = selectedZoneLink.transform.TransformPoint(selectedBoxCollider.center);
                            }
                            else if (selectedSphereCollider && selectedSphereCollider.isTrigger == true)
                            {
                                selectedZoneCenter = selectedZoneLink.transform.TransformPoint(selectedSphereCollider.center);
                            }
                            else if (selectedCapsuleCollider && selectedCapsuleCollider.isTrigger == true)
                            {
                                selectedZoneCenter = selectedZoneLink.transform.TransformPoint(selectedCapsuleCollider.center);
                            }
                            else if (selectedMeshCollider && selectedMeshCollider.isTrigger == true)
                            {
                                Transform[] zonePosList =
                                {
                                    selectedZoneLink.transform
                                };
                                selectedZoneCenter = FindCenterOfSelection(zonePosList);
                            }

                            Vector3 zoneLinkDirection = selectedZoneCenter - zoneCenter;
                            if (!selectedZoneLink.zoneLinks.Contains(zoneLink))
                            {
                                Handles.color = Color.cyan;
                                GUIStyle linkHandleStyle = new GUIStyle();
                                linkHandleStyle.normal.textColor = Color.cyan;
                                bool addZoneLinkHandle = Handles.Button(zoneCenter + new Vector3(0f, -0.5f, 0f), Quaternion.identity, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, HandleUtility.GetHandleSize(zoneCenter) * 0.25f, Handles.SphereHandleCap);
                                Handles.Label(zoneCenter + new Vector3(0.5f, -0.5f, 0f), "Add Link", linkHandleStyle);
                                if (addZoneLinkHandle)
                                {
                                    foreach (ZoneLink selZL in selectedZoneLinks)
                                    {
                                        AddZoneLink(zoneLink, selZL);
                                    }

                                    foreach (ZoneLink zoneLinkInList in allZoneLinksList)
                                    {
                                        foreach (ZoneLink zl in zoneLinkInList.zoneLinks)
                                        {
                                            List<ZoneLink> linksOfZoneLink = zl.zoneLinks.ToList();
                                            if (!linksOfZoneLink.Contains(zoneLinkInList))
                                            {
                                                Debug.Log($"ONE WAY LINK FOUND: {zl.name} does not contain {zoneLinkInList.name} but {zoneLinkInList.name} contains {zl.name}. Forcing 2-way link.");
                                                linksOfZoneLink.Add(zoneLinkInList);
                                                zl.zoneLinks = linksOfZoneLink.ToArray();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Vector3 breakLinkHandlePoint = (zoneCenter) + (zoneLinkDirection * 0.1f);
                                Handles.color = Color.red;
                                GUIStyle linkHandleStyle = new GUIStyle();
                                linkHandleStyle.normal.textColor = Color.red;
                                bool delZoneLinkHandle = Handles.Button(breakLinkHandlePoint, Quaternion.identity, HandleUtility.GetHandleSize(breakLinkHandlePoint) * 0.15f, HandleUtility.GetHandleSize(breakLinkHandlePoint) * 0.15f, Handles.CubeHandleCap);
                                Handles.Label(breakLinkHandlePoint + new Vector3(0f, -0.5f, 0f), "Break Link", linkHandleStyle);
                                Handles.DrawLine(selectedZoneCenter, zoneCenter);
                                if (delZoneLinkHandle)
                                {
                                    foreach (ZoneLink selZL in selectedZoneLinks)
                                    {
                                        BreakZoneLink(zoneLink, selZL);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void AddZoneLink(ZoneLink zoneLink, ZoneLink selZL)
        {
            List<ZoneLink> selZoneLinkList = selZL.zoneLinks.ToList();
            if (!selZoneLinkList.Contains(zoneLink))
            {
                Undo.RecordObject(selZL, "Added ZoneLink between " + selZL.name + " and " + zoneLink.name);
                selZoneLinkList.Add(zoneLink);
                selZL.zoneLinks = selZoneLinkList.ToArray();
            }

            List<ZoneLink> addedZoneLink = zoneLink.zoneLinks.ToList();
            if (!addedZoneLink.Contains(selZL))
            {
                Undo.RecordObject(zoneLink, "Added ZoneLink between " + zoneLink.name + " and " + selZL.name);
                addedZoneLink.Add(selZL);
                zoneLink.zoneLinks = addedZoneLink.ToArray();
            }

            Debug.Log("Added 2-way ZL: " + zoneLink.name + " linked to Selected: " + selZL.name);
        }

        private void BreakZoneLink(ZoneLink zonelink, ZoneLink zLink)
        {
            List<ZoneLink> zoneLinkList = zonelink.zoneLinks.ToList();
            if (zoneLinkList.Contains(zLink))
            {
                Undo.RecordObject(zonelink, "Link broken between " + zLink.name + " and " + zonelink.name);
                zoneLinkList.Remove(zLink);
                zonelink.zoneLinks = zoneLinkList.ToArray();
            }

            List<ZoneLink> thisZoneLinkList = zLink.zoneLinks.ToList();
            if (thisZoneLinkList.Contains(zonelink))
            {
                Undo.RecordObject(zLink, "Link broken between " + zonelink.name + " and " + zLink.name);
                thisZoneLinkList.Remove(zonelink);
                zLink.zoneLinks = thisZoneLinkList.ToArray();
            }

            Debug.Log("Removed ZL: " + zonelink.name + " from Selected: " + zLink.name);
            List<ZoneLink> zoneList = FindObjectsOfType<ZoneLink>().ToList();
            List<ZoneLink> linkedZoneNoEmpties = new List<ZoneLink>();
            foreach (var zlink in zoneList)
            {
                linkedZoneNoEmpties.Clear();
                if (zlink.zoneLinks != null)
                {
                    foreach (var linkedZone in zlink.zoneLinks)
                    {
                        if (linkedZone != null && !linkedZoneNoEmpties.Contains(linkedZone) && linkedZone != zlink)
                        {
                            linkedZoneNoEmpties.Add(linkedZone);
                        }
                    }

                    zlink.zoneLinks = linkedZoneNoEmpties.ToArray();
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
