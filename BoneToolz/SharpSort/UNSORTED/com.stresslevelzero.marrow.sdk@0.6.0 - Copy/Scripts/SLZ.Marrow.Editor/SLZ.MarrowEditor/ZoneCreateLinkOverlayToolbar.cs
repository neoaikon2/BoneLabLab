#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.EditorTools;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.Overlays;
using UnityEditor.UIElements;
using SLZ.Marrow.Warehouse;
using System;
using SLZ.Marrow.Zones;
using System.IO;
using UnityEditor.SceneManagement;
 
using SLZ.Marrow.Utilities;
using SLZ.Marrow;

namespace SLZ.MarrowEditor
{
    [Overlay(typeof(SceneView), id: ID_OVERLAY_ZONECREATELINK, displayName: "Zone Creation and Linking")]
    public class ZoneCreateLinkOverlayToolbar : Overlay
    {
        private const string ID_OVERLAY_ZONECREATELINK = "zone-createlink-overlay-toolbar";
        private string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("93048615e736ff44a94f45cc2c11f911");
        private string zoneIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Zone_Icons");
        ToolbarToggle zoneCreateToolbarToggle;
        ToolbarToggle zoneLinkToolbarToggle;
        Toggle zoneLinkingHandlesToggle;
        ToolbarToggle sceneChunkToolbarToggle;
        ToolbarToggle zoneConfigToolbarToggle;
        VisualElement zoneCreateContainer;
        VisualElement zoneEditContainer;
        VisualElement zoneLinkContainer;
        VisualElement sceneChunkContainer;
        VisualElement zoneConfigContainer;
        Vector3 zoneBoundsInset = new Vector3(0.1f, 0.1f, 0.1f);
        static Vector3 zoneBoundsInsetMenu = new Vector3(0.1f, 0.1f, 0.1f);
        TagQuery playerTagQuery;
        LayerMask layerCollideAllowed = ~0;
        public override VisualElement CreatePanelContent()
        {
            SceneVisibilityManager svm = SceneVisibilityManager.instance;
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement rootVisualElement = new VisualElement();
            rootVisualElement.Add(tree);
            zoneCreateToolbarToggle = rootVisualElement.Q<ToolbarToggle>("zoneCreateToolbarToggle");
            zoneLinkToolbarToggle = rootVisualElement.Q<ToolbarToggle>("zoneLinkToolbarToggle");
            sceneChunkToolbarToggle = rootVisualElement.Q<ToolbarToggle>("sceneChunkToolbarToggle");
            zoneConfigToolbarToggle = rootVisualElement.Q<ToolbarToggle>("zoneConfigToolbarToggle");
            Image zoneConfigIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_settingsConfigurationa.png")) as Texture2D
            };
            if (zoneConfigIconImage != null)
            {
                zoneConfigToolbarToggle.label = "";
            }

            zoneConfigToolbarToggle.Add(zoneConfigIconImage);
            zoneConfigIconImage.StretchToParentSize();
            zoneCreateContainer = rootVisualElement.Q<VisualElement>("zoneCreateContainer");
            zoneEditContainer = rootVisualElement.Q<VisualElement>("zoneEditContainer");
            zoneLinkContainer = rootVisualElement.Q<VisualElement>("zoneLinkContainer");
            sceneChunkContainer = rootVisualElement.Q<VisualElement>("sceneChunkContainer");
            zoneConfigContainer = rootVisualElement.Q<VisualElement>("zoneConfigContainer");
            Toggle zonelabModeToggle = rootVisualElement.Q<Toggle>("zonelabModeToggle");
            Image zonelabModeIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ZoneLabMode_32x32a.png")) as Texture2D
            };
            zonelabModeToggle.Add(zonelabModeIconImage);
            zonelabModeIconImage.StretchToParentSize();
            zoneCreateToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                if (zoneCreateToolbarToggle.value)
                {
                    zoneLinkToolbarToggle.SetValueWithoutNotify(false);
                    zoneLinkContainer.style.display = DisplayStyle.None;
                    sceneChunkToolbarToggle.SetValueWithoutNotify(false);
                    sceneChunkContainer.style.display = DisplayStyle.None;
                    zoneConfigToolbarToggle.SetValueWithoutNotify(false);
                    zoneConfigContainer.style.display = DisplayStyle.None;
                    ZoneCreateEditSelectionContext(zonelabModeIconImage);
                    zoneLinkingHandlesToggle.value = false;
                }
            });
            zoneLinkToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                if (zoneLinkToolbarToggle.value)
                {
                    zoneCreateToolbarToggle.SetValueWithoutNotify(false);
                    zoneCreateContainer.style.display = DisplayStyle.None;
                    zoneEditContainer.style.display = DisplayStyle.None;
                    zoneLinkContainer.style.display = DisplayStyle.Flex;
                    sceneChunkToolbarToggle.SetValueWithoutNotify(false);
                    sceneChunkContainer.style.display = DisplayStyle.None;
                    zoneConfigToolbarToggle.SetValueWithoutNotify(false);
                    zoneConfigContainer.style.display = DisplayStyle.None;
                    zonelabModeIconImage.style.left = 124;
                    zoneLinkingHandlesToggle.value = true;
                }
            });
            sceneChunkToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                if (sceneChunkToolbarToggle.value)
                {
                    zoneCreateToolbarToggle.SetValueWithoutNotify(false);
                    zoneCreateContainer.style.display = DisplayStyle.None;
                    zoneEditContainer.style.display = DisplayStyle.None;
                    zoneLinkToolbarToggle.SetValueWithoutNotify(false);
                    zoneLinkContainer.style.display = DisplayStyle.None;
                    zoneConfigToolbarToggle.SetValueWithoutNotify(false);
                    zoneConfigContainer.style.display = DisplayStyle.None;
                    sceneChunkContainer.style.display = DisplayStyle.Flex;
                    zonelabModeIconImage.style.left = -49;
                    zoneLinkingHandlesToggle.value = false;
                }
            });
            zoneConfigToolbarToggle.RegisterValueChangedCallback(evt =>
            {
                if (zoneConfigToolbarToggle.value)
                {
                    zoneCreateToolbarToggle.SetValueWithoutNotify(false);
                    zoneCreateContainer.style.display = DisplayStyle.None;
                    zoneEditContainer.style.display = DisplayStyle.None;
                    zoneLinkToolbarToggle.SetValueWithoutNotify(false);
                    zoneLinkContainer.style.display = DisplayStyle.None;
                    sceneChunkToolbarToggle.SetValueWithoutNotify(false);
                    sceneChunkContainer.style.display = DisplayStyle.None;
                    zoneConfigContainer.style.display = DisplayStyle.Flex;
                    zonelabModeIconImage.style.left = -2;
                    zoneLinkingHandlesToggle.value = false;
                }
            });
            zonelabModeToggle.RegisterValueChangedCallback(evt =>
            {
                if (zonelabModeToggle.value)
                {
                    List<GameObject> nonZoneGameObjects = new List<GameObject>();
                    nonZoneGameObjects.Clear();
                    foreach (GameObject gameObj in UnityEngine.Object.FindObjectsOfType<GameObject>())
                    {
                        if (!gameObj.GetComponent<Zone>() && !gameObj.GetComponent<ZoneItem>())
                        {
                            nonZoneGameObjects.Add(gameObj);
                        }
                    }

                    EnableZonelabMode(svm, zonelabModeToggle, nonZoneGameObjects);
                }
                else
                {
                    DisableZonelabMode(svm, zonelabModeToggle);
                }
            });
            ToggleToolbarDefaults();
            Selection.selectionChanged += () =>
            {
                if (zoneCreateToolbarToggle.value)
                {
                    ZoneCreateEditSelectionContext(zonelabModeIconImage);
                }
            };
            Vector3Field zoneCreateBoundsInset = rootVisualElement.Q<Vector3Field>("zoneCreateBoundsInset");
            Vector3Field zoneEditBoundsInset = rootVisualElement.Q<Vector3Field>("zoneEditBoundsInset");
            zoneCreateBoundsInset.RegisterValueChangedCallback(evt =>
            {
                zoneEditBoundsInset.value = zoneCreateBoundsInset.value;
                zoneBoundsInset = zoneCreateBoundsInset.value;
                zoneBoundsInsetMenu = zoneBoundsInset;
            });
            zoneEditBoundsInset.RegisterValueChangedCallback(evt =>
            {
                zoneCreateBoundsInset.value = zoneEditBoundsInset.value;
                zoneBoundsInset = zoneCreateBoundsInset.value;
                zoneBoundsInsetMenu = zoneBoundsInset;
            });
            Button createZoneFromGeoButton = rootVisualElement.Q<Button>("createZoneFromGeoButton");
            Image createZoneFromGeoIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_GeoBounds_32x32.png")) as Texture2D
            };
            if (createZoneFromGeoIconImage != null)
            {
                createZoneFromGeoButton.tooltip = createZoneFromGeoButton.text + ": " + createZoneFromGeoButton.tooltip;
                createZoneFromGeoButton.text = "";
            }

            createZoneFromGeoButton.Add(createZoneFromGeoIconImage);
            createZoneFromGeoIconImage.StretchToParentSize();
            createZoneFromGeoButton.clickable.clicked += () =>
            {
                CreateZoneFromGeoOnClick();
            };
            Button createZoneFromSelectedGeoDimensions = rootVisualElement.Q<Button>("createZoneFromSelectedGeoDimensions");
            Image createZoneFromSelectedGeoDimensionsIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_GeoDimensions_32x32.png")) as Texture2D
            };
            if (createZoneFromSelectedGeoDimensionsIconImage != null)
            {
                createZoneFromSelectedGeoDimensions.tooltip = createZoneFromSelectedGeoDimensions.text + ": " + createZoneFromSelectedGeoDimensions.tooltip;
                createZoneFromSelectedGeoDimensions.text = "";
            }

            createZoneFromSelectedGeoDimensions.Add(createZoneFromSelectedGeoDimensionsIconImage);
            createZoneFromSelectedGeoDimensionsIconImage.StretchToParentSize();
            createZoneFromSelectedGeoDimensions.clickable.clicked += () =>
            {
                CreateZoneFromSelectedGeoDimensionsOnClick();
            };
            Button createZoneEncapsulatesGeoButton = rootVisualElement.Q<Button>("createZoneEncapsulatesGeoButton");
            Image createZoneEncapsulatesGeoIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_EncapsulateChildren_32x32.png")) as Texture2D
            };
            if (createZoneEncapsulatesGeoIconImage != null)
            {
                createZoneEncapsulatesGeoButton.tooltip = createZoneEncapsulatesGeoButton.text + ": " + createZoneEncapsulatesGeoButton.tooltip;
                createZoneEncapsulatesGeoButton.text = "";
            }

            createZoneEncapsulatesGeoButton.Add(createZoneEncapsulatesGeoIconImage);
            createZoneEncapsulatesGeoIconImage.StretchToParentSize();
            createZoneEncapsulatesGeoButton.clickable.clicked += () =>
            {
                CreateZoneEncapsulatesGeoOnClick();
            };
            Button createDefaultZoneButton = rootVisualElement.Q<Button>("createDefaultZoneButton");
            Image createDefaultZoneIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_Create1x1x1_32x32.png")) as Texture2D
            };
            if (createDefaultZoneIconImage != null)
            {
                createDefaultZoneButton.tooltip = createDefaultZoneButton.text + ": " + createDefaultZoneButton.tooltip;
                createDefaultZoneButton.text = "";
            }

            createDefaultZoneButton.Add(createDefaultZoneIconImage);
            createDefaultZoneIconImage.StretchToParentSize();
            createDefaultZoneButton.clickable.clicked += () =>
            {
                CreateDefaultZoneOnClick();
            };
            Button resizeZoneToGeoAndZonesButton = rootVisualElement.Q<Button>("resizeZoneToGeoAndZonesButton");
            Image resizeZoneToGeoAndZonesIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_FitToNeighbors_32x32.png")) as Texture2D
            };
            if (resizeZoneToGeoAndZonesIconImage != null)
            {
                resizeZoneToGeoAndZonesButton.tooltip = resizeZoneToGeoAndZonesButton.text + ": " + resizeZoneToGeoAndZonesButton.tooltip;
                resizeZoneToGeoAndZonesButton.text = "";
            }

            resizeZoneToGeoAndZonesButton.Add(resizeZoneToGeoAndZonesIconImage);
            resizeZoneToGeoAndZonesIconImage.StretchToParentSize();
            resizeZoneToGeoAndZonesButton.clickable.clicked += () =>
            {
                ResizeZoneToGeoAndZoneNeighborsOnClick();
            };
            Button toggleColliderEditMode = rootVisualElement.Q<Button>("toggleColliderEditMode");
            Image toggleColliderEditModeIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ManualCollider_32x32.png")) as Texture2D
            };
            if (toggleColliderEditModeIconImage != null)
            {
                toggleColliderEditMode.tooltip = toggleColliderEditMode.text + ": " + toggleColliderEditMode.tooltip;
                toggleColliderEditMode.text = "";
            }

            toggleColliderEditMode.Add(toggleColliderEditModeIconImage);
            toggleColliderEditModeIconImage.StretchToParentSize();
            toggleColliderEditMode.clickable.clicked += () =>
            {
                ToggleColliderEditModeOnClick();
            };
            Button splitColliderXAxisButton = rootVisualElement.Q<Button>("splitColliderXAxisButton");
            Image splitColliderXAxisIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_SplitX_32x32.png")) as Texture2D
            };
            if (splitColliderXAxisIconImage != null)
            {
                splitColliderXAxisButton.tooltip = splitColliderXAxisButton.text + ": " + splitColliderXAxisButton.tooltip;
                splitColliderXAxisButton.text = "";
            }

            splitColliderXAxisButton.Add(splitColliderXAxisIconImage);
            splitColliderXAxisIconImage.StretchToParentSize();
            splitColliderXAxisButton.clickable.clicked += () =>
            {
                SplitColliderXAxisOnClick();
            };
            Button splitColliderYAxisButton = rootVisualElement.Q<Button>("splitColliderYAxisButton");
            Image splitColliderYAxisIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_SplitY_32x32.png")) as Texture2D
            };
            if (splitColliderYAxisIconImage != null)
            {
                splitColliderYAxisButton.tooltip = splitColliderYAxisButton.text + ": " + splitColliderYAxisButton.tooltip;
                splitColliderYAxisButton.text = "";
            }

            splitColliderYAxisButton.Add(splitColliderYAxisIconImage);
            splitColliderYAxisIconImage.StretchToParentSize();
            splitColliderYAxisButton.clickable.clicked += () =>
            {
                SplitColliderYAxisOnClick();
            };
            Button splitColliderZAxisButton = rootVisualElement.Q<Button>("splitColliderZAxisButton");
            Image splitColliderZAxisIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_SplitZ_32x32.png")) as Texture2D
            };
            if (splitColliderZAxisIconImage != null)
            {
                splitColliderZAxisButton.tooltip = splitColliderZAxisButton.text + ": " + splitColliderZAxisButton.tooltip;
                splitColliderZAxisButton.text = "";
            }

            splitColliderZAxisButton.Add(splitColliderZAxisIconImage);
            splitColliderZAxisIconImage.StretchToParentSize();
            splitColliderZAxisButton.clickable.clicked += () =>
            {
                SplitColliderZAxisOnClick();
            };
            Button resizeZoneToXPosButton = rootVisualElement.Q<Button>("resizeZoneToXPosButton");
            Image resizeZoneToXPosIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_+X_32x16.png")) as Texture2D
            };
            if (resizeZoneToXPosIconImage != null)
            {
                resizeZoneToXPosButton.tooltip = resizeZoneToXPosButton.text + ": " + resizeZoneToXPosButton.tooltip;
                resizeZoneToXPosButton.text = "";
            }

            resizeZoneToXPosButton.Add(resizeZoneToXPosIconImage);
            resizeZoneToXPosIconImage.StretchToParentSize();
            resizeZoneToXPosButton.clickable.clicked += () =>
            {
                ResizeZoneToXPosOnClick();
            };
            Button resizeZoneToXNegButton = rootVisualElement.Q<Button>("resizeZoneToXNegButton");
            Image resizeZoneToXNegIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_-X_32x16.png")) as Texture2D
            };
            if (resizeZoneToXNegIconImage != null)
            {
                resizeZoneToXNegButton.tooltip = resizeZoneToXNegButton.text + ": " + resizeZoneToXNegButton.tooltip;
                resizeZoneToXNegButton.text = "";
            }

            resizeZoneToXNegButton.Add(resizeZoneToXNegIconImage);
            resizeZoneToXNegIconImage.StretchToParentSize();
            resizeZoneToXNegButton.clickable.clicked += () =>
            {
                ResizeZoneToXNegOnClick();
            };
            Button resizeZoneToYPosButton = rootVisualElement.Q<Button>("resizeZoneToYPosButton");
            Image resizeZoneToYPosIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_+Y_32x16.png")) as Texture2D
            };
            if (resizeZoneToYPosIconImage != null)
            {
                resizeZoneToYPosButton.tooltip = resizeZoneToYPosButton.text + ": " + resizeZoneToYPosButton.tooltip;
                resizeZoneToYPosButton.text = "";
            }

            resizeZoneToYPosButton.Add(resizeZoneToYPosIconImage);
            resizeZoneToYPosIconImage.StretchToParentSize();
            resizeZoneToYPosButton.clickable.clicked += () =>
            {
                ResizeZoneToYPosOnClick();
            };
            Button resizeZoneToYNegButton = rootVisualElement.Q<Button>("resizeZoneToYNegButton");
            Image resizeZoneToYNegIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_-Y_32x16.png")) as Texture2D
            };
            if (resizeZoneToYNegIconImage != null)
            {
                resizeZoneToYNegButton.tooltip = resizeZoneToYNegButton.text + ": " + resizeZoneToYNegButton.tooltip;
                resizeZoneToYNegButton.text = "";
            }

            resizeZoneToYNegButton.Add(resizeZoneToYNegIconImage);
            resizeZoneToYNegIconImage.StretchToParentSize();
            resizeZoneToYNegButton.clickable.clicked += () =>
            {
                ResizeZoneToYNegOnClick();
            };
            Button resizeZoneToZPosButton = rootVisualElement.Q<Button>("resizeZoneToZPosButton");
            Image resizeZoneToZPosIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_+Z_32x16.png")) as Texture2D
            };
            if (resizeZoneToZPosIconImage != null)
            {
                resizeZoneToZPosButton.tooltip = resizeZoneToZPosButton.text + ": " + resizeZoneToZPosButton.tooltip;
                resizeZoneToZPosButton.text = "";
            }

            resizeZoneToZPosButton.Add(resizeZoneToZPosIconImage);
            resizeZoneToZPosIconImage.StretchToParentSize();
            resizeZoneToZPosButton.clickable.clicked += () =>
            {
                ResizeZoneToZPosOnClick();
            };
            Button resizeZoneToZNegButton = rootVisualElement.Q<Button>("resizeZoneToZNegButton");
            Image resizeZoneToZNegIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_-Z_32x16.png")) as Texture2D
            };
            if (resizeZoneToZNegIconImage != null)
            {
                resizeZoneToZNegButton.tooltip = resizeZoneToZNegButton.text + ": " + resizeZoneToZNegButton.tooltip;
                resizeZoneToZNegButton.text = "";
            }

            resizeZoneToZNegButton.Add(resizeZoneToZNegIconImage);
            resizeZoneToZNegIconImage.StretchToParentSize();
            resizeZoneToZNegButton.clickable.clicked += () =>
            {
                ResizeZoneToZNegOnClick();
            };
            Button resetZoneXButton = rootVisualElement.Q<Button>("resetZoneXButton");
            Image resetZoneXIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ResetX.png")) as Texture2D
            };
            if (resetZoneXIconImage != null)
            {
                resetZoneXButton.tooltip = resetZoneXButton.text + ": " + resetZoneXButton.tooltip;
                resetZoneXButton.text = "";
            }

            resetZoneXButton.Add(resetZoneXIconImage);
            resetZoneXIconImage.StretchToParentSize();
            resetZoneXButton.clickable.clicked += () =>
            {
                ResetZoneXAxisOnClick();
            };
            Button resetZoneYButton = rootVisualElement.Q<Button>("resetZoneYButton");
            Image resetZoneYIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ResetY.png")) as Texture2D
            };
            if (resetZoneYIconImage != null)
            {
                resetZoneYButton.tooltip = resetZoneYButton.text + ": " + resetZoneYButton.tooltip;
                resetZoneYButton.text = "";
            }

            resetZoneYButton.Add(resetZoneYIconImage);
            resetZoneYIconImage.StretchToParentSize();
            resetZoneYButton.clickable.clicked += () =>
            {
                ResetZoneYAxisOnClick();
            };
            Button resetZoneZButton = rootVisualElement.Q<Button>("resetZoneZButton");
            Image resetZoneZIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ResetZ.png")) as Texture2D
            };
            if (resetZoneZIconImage != null)
            {
                resetZoneZButton.tooltip = resetZoneZButton.text + ": " + resetZoneZButton.tooltip;
                resetZoneZButton.text = "";
            }

            resetZoneZButton.Add(resetZoneZIconImage);
            resetZoneZIconImage.StretchToParentSize();
            resetZoneZButton.clickable.clicked += () =>
            {
                ResetZoneZAxisOnClick();
            };
            Button resetZoneAllButton = rootVisualElement.Q<Button>("resetZoneAllButton");
            Image resetZoneAllIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_ResetXYZ.png")) as Texture2D
            };
            if (resetZoneAllIconImage != null)
            {
                resetZoneAllButton.tooltip = resetZoneAllButton.text + ": " + resetZoneAllButton.tooltip;
                resetZoneAllButton.text = "";
            }

            resetZoneAllButton.Add(resetZoneAllIconImage);
            resetZoneAllIconImage.StretchToParentSize();
            resetZoneAllButton.clickable.clicked += () =>
            {
                ResetZoneAllAxesOnClick();
            };
            TextField sceneChunkSceneNameField = rootVisualElement.Q<TextField>("sceneChunkSceneNameField");
            sceneChunkSceneNameField.RegisterValueChangedCallback(evt =>
            {
                char[] invalidPathChars = Path.GetInvalidFileNameChars();
                if (sceneChunkSceneNameField.value.Trim().Length > 0)
                {
                    foreach (char c in invalidPathChars)
                    {
                        if (sceneChunkSceneNameField.value.Contains(c))
                        {
                            Debug.Log("Removed invalid filename char: " + c.ToString());
                            sceneChunkSceneNameField.value = sceneChunkSceneNameField.value.Replace(c.ToString(), String.Empty);
                        }
                    }
                }
            });
            TextField sceneChunkScenePathField = rootVisualElement.Q<TextField>("sceneChunkScenePathField");
            string readonlyTextFieldPath = "Path unknown, save at least one scene...";
            sceneChunkScenePathField.RegisterValueChangedCallback(evt =>
            {
                sceneChunkScenePathField.value = readonlyTextFieldPath;
            });
            if (EditorSceneManager.GetSceneAt(0) != null && EditorSceneManager.GetSceneAt(0).path != null && EditorSceneManager.GetSceneAt(0).path != "")
            {
                readonlyTextFieldPath = EditorSceneManager.GetSceneAt(0).path.Substring(0, EditorSceneManager.GetSceneAt(0).path.LastIndexOf('/'));
                sceneChunkScenePathField.value = readonlyTextFieldPath;
            }

            Button sceneChunkFilePathButton = rootVisualElement.Q<Button>("sceneChunkFilePathButton");
            sceneChunkFilePathButton.clickable.clicked += () =>
            {
                readonlyTextFieldPath = SceneChunkFilePathOnClick().Replace(Application.dataPath.ToString(), "Assets");
                sceneChunkScenePathField.value = readonlyTextFieldPath;
            };
            Button createSceneChunkFromSelectedButton = rootVisualElement.Q<Button>("createSceneChunkFromSelectedButton");
            createSceneChunkFromSelectedButton.clickable.clicked += () =>
            {
                CreateSceneFromSelectedGOsOnClick(sceneChunkSceneNameField.value, sceneChunkScenePathField.value);
            };
            Toggle showZonePickableCubeToggle = rootVisualElement.Q<Toggle>("showZonePickableCubeToggle");
            showZonePickableCubeToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZonePickableCubeToggle.value)
                {
                    MarrowSDKPreferences.gizmoShowZonePickableCube = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoShowZonePickableCube = false;
                }

                EditorPrefs.SetBool("gizmoShowZonePickableCube", MarrowSDKPreferences.gizmoShowZonePickableCube);
            });
            Toggle showZoneLinksToggle = rootVisualElement.Q<Toggle>("showZoneLinksToggle");
            showZoneLinksToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneLinksToggle.value)
                {
                    MarrowSDKPreferences.gizmoShowZoneLinks = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoShowZoneLinks = false;
                }

                EditorPrefs.SetBool("gizmoShowZoneLinks", MarrowSDKPreferences.gizmoShowZoneLinks);
            });
            Toggle showZoneNamesToggle = rootVisualElement.Q<Toggle>("showZoneNamesToggle");
            showZoneNamesToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneNamesToggle.value)
                {
                    MarrowSDKPreferences.gizmoShowZoneNames = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoShowZoneNames = false;
                }

                EditorPrefs.SetBool("gizmoShowZoneNames", MarrowSDKPreferences.gizmoShowZoneNames);
            });
            Toggle showSceneChunkGizmosToggle = rootVisualElement.Q<Toggle>("showSceneChunkGizmosToggle");
            showSceneChunkGizmosToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showSceneChunkGizmosToggle.value)
                {
                    MarrowSDKPreferences.gizmoSceneChunkGizmos = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoSceneChunkGizmos = false;
                }

                EditorPrefs.SetBool("gizmoSceneChunkGizmos", MarrowSDKPreferences.gizmoSceneChunkGizmos);
            });
            Toggle showZoneItemGizmosToggle = rootVisualElement.Q<Toggle>("showZoneItemGizmosToggle");
            showZoneItemGizmosToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneItemGizmosToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneItemGizmos = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneItemGizmos = false;
                }

                EditorPrefs.SetBool("gizmoZoneItemGizmos", MarrowSDKPreferences.gizmoZoneItemGizmos);
            });
            Slider zoneOpacitySlider = rootVisualElement.Q<Slider>("zoneOpacitySlider");
            zoneOpacitySlider.RegisterValueChangedCallback((evt) =>
            {
                MarrowSDKPreferences.gizmoZoneOpacity = zoneOpacitySlider.value;
                EditorPrefs.SetFloat("gizmoZoneOpacity", zoneOpacitySlider.value);
            });
            Slider zoneLinkItemOpacitySlider = rootVisualElement.Q<Slider>("zoneLinkItemOpacitySlider");
            zoneLinkItemOpacitySlider.RegisterValueChangedCallback((evt) =>
            {
                MarrowSDKPreferences.gizmoZoneLinkItemOpacity = zoneLinkItemOpacitySlider.value;
                EditorPrefs.SetFloat("gizmoZoneLinkItemOpacity", MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
            });
            Slider zoneLabelsRangeSlider = rootVisualElement.Q<Slider>("zoneLabelsRangeSlider");
            zoneLabelsRangeSlider.RegisterValueChangedCallback((evt) =>
            {
                MarrowSDKPreferences.gizmoShowZoneLabelsRange = zoneLabelsRangeSlider.value;
                EditorPrefs.SetFloat("gizmoShowZoneLabelsRange", MarrowSDKPreferences.gizmoShowZoneLabelsRange);
            });
            Toggle showActivatorsToggle = rootVisualElement.Q<Toggle>("showActivatorsToggle");
            showActivatorsToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showActivatorsToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneActivators = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneActivators = false;
                }

                EditorPrefs.SetBool("gizmoZoneActivators", MarrowSDKPreferences.gizmoZoneActivators);
            });
            Toggle showZoneMusicToggle = rootVisualElement.Q<Toggle>("showZoneMusicToggle");
            showZoneMusicToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneMusicToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneMusic = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneMusic = false;
                }

                EditorPrefs.SetBool("gizmoZoneMusic", MarrowSDKPreferences.gizmoZoneMusic);
            });
            Toggle showZoneAmbienceToggle = rootVisualElement.Q<Toggle>("showZoneAmbienceToggle");
            showZoneAmbienceToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneAmbienceToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneAmbience = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneAmbience = false;
                }

                EditorPrefs.SetBool("gizmoZoneAmbience", MarrowSDKPreferences.gizmoZoneAmbience);
            });
            Toggle showZoneLinkLinesToggle = rootVisualElement.Q<Toggle>("showZoneLinkLinesToggle");
            showZoneLinkLinesToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneLinkLinesToggle.value)
                {
                    MarrowSDKPreferences.gizmoZoneLinkLines = true;
                }
                else
                {
                    MarrowSDKPreferences.gizmoZoneLinkLines = false;
                }

                EditorPrefs.SetBool("gizmoZoneLinkLines", MarrowSDKPreferences.gizmoZoneLinkLines);
            });
            Toggle showZoneGizmosToggle = rootVisualElement.Q<Toggle>("showZoneGizmosToggle");
            showZoneGizmosToggle.RegisterValueChangedCallback((evt) =>
            {
                if (showZoneGizmosToggle.value)
                {
                    MarrowSDKPreferences.gizmoShowZoneGizmos = true;
                    showZonePickableCubeToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZonePickableCube);
                    showZoneLinksToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneLinks);
                    showZoneNamesToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneNames);
                    showActivatorsToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneActivators);
                    showActivatorsToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneActivators);
                    showZoneMusicToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneMusic);
                    showZoneAmbienceToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneAmbience);
                    showZoneLinkLinesToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneLinkLines);
                    showSceneChunkGizmosToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoSceneChunkGizmos);
                    showZoneItemGizmosToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneItemGizmos);
                    zoneOpacitySlider.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneOpacity);
                    zoneLinkItemOpacitySlider.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
                }
                else
                {
                    MarrowSDKPreferences.gizmoShowZoneGizmos = false;
                    showZonePickableCubeToggle.value = false;
                    showZoneLinksToggle.value = false;
                    showZoneNamesToggle.value = false;
                    showActivatorsToggle.value = false;
                    showZoneMusicToggle.value = false;
                    showZoneAmbienceToggle.value = false;
                    showZoneLinkLinesToggle.value = false;
                    showSceneChunkGizmosToggle.value = false;
                    showZoneItemGizmosToggle.value = false;
                    showActivatorsToggle.value = false;
                    zoneOpacitySlider.value = 0f;
                    zoneLinkItemOpacitySlider.value = 0f;
                }
            });
            TextField zonesParentNameTextField = rootVisualElement.Q<TextField>("zonesParentNameTextField");
            Button zonesParentNameSetButton = rootVisualElement.Q<Button>("zonesParentNameSetButton");
            zonesParentNameSetButton.clickable.clicked += () =>
            {
                if (zonesParentNameTextField.value.Trim().Length > 0)
                {
                    if (GameObject.Find(zonesParentNameTextField.value))
                    {
                        MarrowSDKPreferences.zonesParentHolderName = zonesParentNameTextField.value;
                    }

                    if (GameObject.Find(MarrowSDKPreferences.zonesParentHolderName))
                    {
                        if (zonesParentNameTextField.value != MarrowSDKPreferences.zonesParentHolderName)
                        {
                            GameObject.Find(MarrowSDKPreferences.zonesParentHolderName).name = zonesParentNameTextField.value;
                            MarrowSDKPreferences.zonesParentHolderName = zonesParentNameTextField.value;
                        }
                    }
                    else
                    {
                        if (!GameObject.Find(zonesParentNameTextField.value))
                        {
                            GameObject zoneHolderParent = new GameObject(zonesParentNameTextField.value);
                            MarrowSDKPreferences.zonesParentHolderName = zonesParentNameTextField.value;
                        }
                    }

                    EditorPrefs.SetString("zonesParentHolderName", MarrowSDKPreferences.zonesParentHolderName);
                }
            };
            Button zoneGizmoDefaultsButton = rootVisualElement.Q<Button>("zoneGizmoDefaultsButton");
            zoneGizmoDefaultsButton.clickable.clicked += () =>
            {
                showZonePickableCubeToggle.value = true;
                showZoneLinksToggle.value = true;
                showZoneNamesToggle.value = true;
                showActivatorsToggle.value = true;
                showZoneMusicToggle.value = true;
                showZoneAmbienceToggle.value = true;
                showZoneLinkLinesToggle.value = true;
                showSceneChunkGizmosToggle.value = true;
                showZoneItemGizmosToggle.value = true;
                showActivatorsToggle.value = true;
                zoneOpacitySlider.value = 0.05f;
                zoneLinkItemOpacitySlider.value = 0.85f;
                showZoneGizmosToggle.value = true;
            };
            zoneLinkingHandlesToggle = rootVisualElement.Q<Toggle>("zoneLinkingHandlesToggle");
            zoneLinkingHandlesToggle.RegisterValueChangedCallback((evt) =>
            {
                if (zoneLinkingHandlesToggle.value)
                {
                    Zone.gizmoZoneLinkHandles = true;
                }
                else
                {
                    Zone.gizmoZoneLinkHandles = false;
                }
            });
            SliderInt zoneLinkingHandlesRangeSlider = rootVisualElement.Q<SliderInt>("zoneLinkingHandlesRangeSlider");
            zoneLinkingHandlesRangeSlider.RegisterValueChangedCallback((evt) =>
            {
                Zone.gizmoZoneLinkHandlesRange = zoneLinkingHandlesRangeSlider.value;
            });
            Button addLinkedZonesToSelectionButton = rootVisualElement.Q<Button>("addLinkedZonesToSelectionButton");
            Image addLinkedZonesToSelectionIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_SelectLinked.png")) as Texture2D
            };
            if (addLinkedZonesToSelectionIconImage != null)
            {
                addLinkedZonesToSelectionButton.tooltip = addLinkedZonesToSelectionButton.text + ": " + addLinkedZonesToSelectionButton.tooltip;
                addLinkedZonesToSelectionButton.text = "";
            }

            addLinkedZonesToSelectionButton.Add(addLinkedZonesToSelectionIconImage);
            addLinkedZonesToSelectionIconImage.StretchToParentSize();
            addLinkedZonesToSelectionButton.clickable.clicked += () =>
            {
                AddLinkedZonesToSelectionOnClick();
            };
            Button linkSelectedToEachOtherButton = rootVisualElement.Q<Button>("linkSelectedToEachOtherButton");
            Image linkSelectedToEachOtherIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_OverwriteLinks_32x32.png")) as Texture2D
            };
            if (linkSelectedToEachOtherIconImage != null)
            {
                linkSelectedToEachOtherButton.tooltip = linkSelectedToEachOtherButton.text + ": " + linkSelectedToEachOtherButton.tooltip;
                linkSelectedToEachOtherButton.text = "";
            }

            linkSelectedToEachOtherButton.Add(linkSelectedToEachOtherIconImage);
            linkSelectedToEachOtherIconImage.StretchToParentSize();
            linkSelectedToEachOtherButton.clickable.clicked += () =>
            {
                LinkSelectedZonesToEachOtherOnClick();
            };
            Button addSelectedZonesToLinkedButton = rootVisualElement.Q<Button>("addSelectedZonesToLinkedButton");
            Image addSelectedZonesToLinkedIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_AddLinks_32x32.png")) as Texture2D
            };
            if (addSelectedZonesToLinkedIconImage != null)
            {
                addSelectedZonesToLinkedButton.tooltip = addSelectedZonesToLinkedButton.text + ": " + addSelectedZonesToLinkedButton.tooltip;
                addSelectedZonesToLinkedButton.text = "";
            }

            addSelectedZonesToLinkedButton.Add(addSelectedZonesToLinkedIconImage);
            addSelectedZonesToLinkedIconImage.StretchToParentSize();
            addSelectedZonesToLinkedButton.clickable.clicked += () =>
            {
                AddSelectedZonesToLinkedZonesOnClick();
            };
            Button removeSelectedLinksButton = rootVisualElement.Q<Button>("removeSelectedLinksButton");
            Image removeSelectedLinksIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_DeleteLinks_32x32.png")) as Texture2D
            };
            if (removeSelectedLinksIconImage != null)
            {
                removeSelectedLinksButton.tooltip = removeSelectedLinksButton.text + ": " + removeSelectedLinksButton.tooltip;
                removeSelectedLinksButton.text = "";
            }

            removeSelectedLinksButton.Add(removeSelectedLinksIconImage);
            removeSelectedLinksIconImage.StretchToParentSize();
            removeSelectedLinksButton.clickable.clicked += () =>
            {
                RemoveSelectedLinksOnClick();
            };
            Button removeEmptyLinksButton = rootVisualElement.Q<Button>("removeEmptyLinksButton");
            Image removeEmptyLinksIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_FixEmpty.png")) as Texture2D
            };
            if (removeEmptyLinksIconImage != null)
            {
                removeEmptyLinksButton.tooltip = removeEmptyLinksButton.text + ": " + removeEmptyLinksButton.tooltip;
                removeEmptyLinksButton.text = "";
            }

            removeEmptyLinksButton.Add(removeEmptyLinksIconImage);
            removeEmptyLinksIconImage.StretchToParentSize();
            removeEmptyLinksButton.clickable.clicked += () =>
            {
                RemoveEmptyOrDupLinksOnClick();
            };
            Button sortLinkedZonesButton = rootVisualElement.Q<Button>("sortLinkedZonesButton");
            Image sortLinkedZonesIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_SortLinked_32x32.png")) as Texture2D
            };
            if (sortLinkedZonesIconImage != null)
            {
                sortLinkedZonesButton.tooltip = sortLinkedZonesButton.text + ": " + sortLinkedZonesButton.tooltip;
                sortLinkedZonesButton.text = "";
            }

            sortLinkedZonesButton.Add(sortLinkedZonesIconImage);
            sortLinkedZonesIconImage.StretchToParentSize();
            sortLinkedZonesButton.clickable.clicked += () =>
            {
                SortLinkedZonesByNameOnClick();
            };
            zonelabModeIconImage.style.left = 124;
            Zone.gizmoZoneLinkHandlesRange = zoneLinkingHandlesRangeSlider.value;
            zoneBoundsInset = zoneCreateBoundsInset.value;
            zoneBoundsInsetMenu = zoneBoundsInset;
            MarrowSDKPreferences.gizmoShowZoneGizmos = EditorPrefs.GetBool("gizmoShowZoneGizmos", true);
            showZoneGizmosToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneGizmos);
            MarrowSDKPreferences.gizmoShowZonePickableCube = EditorPrefs.GetBool("gizmoShowZonePickableCube", true);
            showZonePickableCubeToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZonePickableCube);
            MarrowSDKPreferences.gizmoShowZoneLinks = EditorPrefs.GetBool("gizmoShowZoneLinks", true);
            showZoneLinksToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneLinks);
            MarrowSDKPreferences.gizmoShowZoneNames = EditorPrefs.GetBool("gizmoShowZoneNames", true);
            showZoneNamesToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneNames);
            MarrowSDKPreferences.gizmoZoneActivators = EditorPrefs.GetBool("gizmoZoneActivators", true);
            showActivatorsToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneActivators);
            MarrowSDKPreferences.gizmoZoneLinkLines = EditorPrefs.GetBool("gizmoZoneLinkLines", true);
            showZoneLinkLinesToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneLinkLines);
            MarrowSDKPreferences.gizmoSceneChunkGizmos = EditorPrefs.GetBool("gizmoSceneChunkGizmos", true);
            showSceneChunkGizmosToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoSceneChunkGizmos);
            MarrowSDKPreferences.gizmoZoneItemGizmos = EditorPrefs.GetBool("gizmoZoneItemGizmos", true);
            showZoneItemGizmosToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneItemGizmos);
            MarrowSDKPreferences.gizmoZoneMusic = EditorPrefs.GetBool("gizmoZoneMusic", true);
            showZoneMusicToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneMusic);
            MarrowSDKPreferences.gizmoZoneAmbience = EditorPrefs.GetBool("gizmoZoneAmbience", true);
            showZoneAmbienceToggle.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneAmbience);
            MarrowSDKPreferences.gizmoZoneOpacity = EditorPrefs.GetFloat("gizmoZoneOpacity", 0.05f);
            zoneOpacitySlider.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneOpacity);
            MarrowSDKPreferences.gizmoShowZoneLabelsRange = EditorPrefs.GetFloat("gizmoShowZoneLabelsRange", 0.05f);
            zoneLabelsRangeSlider.SetValueWithoutNotify(MarrowSDKPreferences.gizmoShowZoneLabelsRange);
            MarrowSDKPreferences.gizmoZoneLinkItemOpacity = EditorPrefs.GetFloat("gizmoZoneLinkItemOpacity", 0.05f);
            zoneLinkItemOpacitySlider.SetValueWithoutNotify(MarrowSDKPreferences.gizmoZoneLinkItemOpacity);
            MarrowSDKPreferences.zonesParentHolderName = EditorPrefs.GetString("zonesParentHolderName", "ZONES");
            if (MarrowSDKPreferences.zonesParentHolderName != null && MarrowSDKPreferences.zonesParentHolderName.Length > 0)
            {
                zonesParentNameTextField.SetValueWithoutNotify(MarrowSDKPreferences.zonesParentHolderName);
            }
            else
            {
                EditorPrefs.SetString("zonesParentHolderName", "ZONES");
                MarrowSDKPreferences.zonesParentHolderName = "ZONES";
                zonesParentNameTextField.SetValueWithoutNotify("ZONES");
            }

            DisableZonelabMode(svm, zonelabModeToggle);
            return rootVisualElement;
        }

        private void ZoneCreateEditSelectionContext(Image zonelabModeIconImage)
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            if (selectedGOs != null && selectedGOs.Count > 0)
            {
                foreach (GameObject zoneGo in selectedGOs)
                {
                    if (zoneGo.GetComponent<Zone>() != null)
                    {
                        zoneEditContainer.style.display = DisplayStyle.Flex;
                        zoneCreateContainer.style.display = DisplayStyle.None;
                        zonelabModeIconImage.style.left = 32;
                    }
                    else
                    {
                        zoneEditContainer.style.display = DisplayStyle.None;
                        zoneCreateContainer.style.display = DisplayStyle.Flex;
                        zonelabModeIconImage.style.left = 124;
                    }
                }
            }
            else
            {
                zoneEditContainer.style.display = DisplayStyle.None;
                zoneCreateContainer.style.display = DisplayStyle.Flex;
                zonelabModeIconImage.style.left = 124;
            }
        }

        private void EnableZonelabMode(SceneVisibilityManager svm, Toggle zonelabModeToggle, List<GameObject> nonZoneGameObjects)
        {
            zonelabModeToggle.text = "";
            zonelabModeToggle.tooltip = "Only Zones & ZoneItems are Selectable in Scene";
            svm.DisablePicking(nonZoneGameObjects.ToArray(), false);
            Zone.gizmoZonelabMode = true;
        }

        private void DisableZonelabMode(SceneVisibilityManager svm, Toggle zonelabModeToggle)
        {
            zonelabModeToggle.text = "";
            zonelabModeToggle.tooltip = "All objects are selectable";
            svm.EnableAllPicking();
            Zone.gizmoZonelabMode = false;
        }

        private void ToggleToolbarDefaults()
        {
            zoneCreateToolbarToggle.value = true;
            zoneCreateContainer.style.display = DisplayStyle.Flex;
            zoneLinkToolbarToggle.value = false;
            zoneEditContainer.style.display = DisplayStyle.None;
            zoneLinkContainer.style.display = DisplayStyle.None;
            sceneChunkToolbarToggle.value = false;
            sceneChunkContainer.style.display = DisplayStyle.None;
            zoneConfigToolbarToggle.value = false;
            zoneConfigContainer.style.display = DisplayStyle.None;
        }

        private void ResizeZoneToXPosOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone +X Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float xSize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.right, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            xSize = hit.distance - zoneBoundsInset.x;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.red, 5f);
                            break;
                        }
                    }

                    if (xSize > 0f)
                    {
                        float origXSize = box.size.x;
                        box.size = new Vector3((xSize != 0) ? xSize + (box.size.x / 2) : box.size.x, box.size.y, box.size.z);
                        box.transform.position += new Vector3((xSize / 2) - (origXSize / 4), 0, 0);
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the +X direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResizeZoneToXNegOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone -X Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float xSize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.left, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            xSize = hit.distance - zoneBoundsInset.x;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.red, 5f);
                            break;
                        }
                    }

                    if (xSize > 0f)
                    {
                        float origXSize = box.size.x;
                        box.size = new Vector3((xSize != 0) ? xSize + (box.size.x / 2) : box.size.x, box.size.y, box.size.z);
                        box.transform.position += new Vector3(-(xSize / 2) + (origXSize / 4), 0, 0);
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the -X direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResizeZoneToYPosOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone +Y Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float ySize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.up, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            ySize = hit.distance - zoneBoundsInset.y;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.green, 5f);
                            break;
                        }
                    }

                    if (ySize > 0f)
                    {
                        float origYSize = box.size.y;
                        box.size = new Vector3(box.size.x, (ySize != 0) ? ySize + (box.size.y / 2) : box.size.y, box.size.z);
                        box.transform.position += new Vector3(0, (ySize / 2) - (origYSize / 4), 0);
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the +Y direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResizeZoneToYNegOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone -Y Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float ySize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.down, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            ySize = hit.distance - zoneBoundsInset.y;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.green, 5f);
                            break;
                        }
                    }

                    if (ySize > 0f)
                    {
                        float origYSize = box.size.y;
                        box.size = new Vector3(box.size.x, (ySize != 0) ? ySize + (box.size.y / 2) : box.size.y, box.size.z);
                        box.transform.position += new Vector3(0, -(ySize / 2) + (origYSize / 4), 0);
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the -Y direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResizeZoneToZPosOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone +Z Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float zSize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.forward, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            zSize = hit.distance - zoneBoundsInset.z;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.blue, 5f);
                            break;
                        }
                    }

                    if (zSize > 0f)
                    {
                        float origZSize = box.size.z;
                        box.size = new Vector3(box.size.x, box.size.y, (zSize != 0) ? zSize + (box.size.z / 2) : box.size.z);
                        box.transform.position += new Vector3(0, 0, (zSize / 2) - (origZSize / 4));
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the +Z direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResizeZoneToZNegOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Set Zone -Z Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    float zSize = 0f;
                    RaycastHit[] orderedHits;
                    orderedHits = Physics.RaycastAll(box.transform.position, Vector3.back, 50f, layerCollideAllowed, QueryTriggerInteraction.Collide).OrderBy(h => h.distance).ToArray();
                    foreach (RaycastHit hit in orderedHits)
                    {
                        if (hit.collider.GetComponent<ZoneLink>() || hit.collider.gameObject.isStatic)
                        {
                            zSize = hit.distance - zoneBoundsInset.z;
                            Debug.DrawRay(box.transform.position, hit.point - box.transform.position, Color.blue, 5f);
                            break;
                        }
                    }

                    if (zSize > 0f)
                    {
                        float origZSize = box.size.z;
                        box.size = new Vector3(box.size.x, box.size.y, (zSize != 0) ? zSize + (box.size.z / 2) : box.size.z);
                        box.transform.position += new Vector3(0, 0, -(zSize / 2) + (origZSize / 4));
                        box.center = Vector3.zero;
                    }
                    else
                    {
                        Debug.Log("No Static Geo or Zone neighbors in the -Z direction, resize cancelled.");
                    }
                }
            }
        }

        private void ResetZoneXAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Reset Zone X Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    box.size = new Vector3(1, box.size.y, box.size.z);
                    box.transform.position = zoneGo.transform.TransformPoint(box.center);
                    box.center = Vector3.zero;
                    box.size -= new Vector3(zoneBoundsInset.x, 0, 0);
                }
            }
        }

        private void ResetZoneYAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Reset Zone Y Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    box.size = new Vector3(box.size.x, 1, box.size.z);
                    box.transform.position = zoneGo.transform.TransformPoint(box.center);
                    box.center = Vector3.zero;
                    box.size -= new Vector3(0, zoneBoundsInset.y, 0);
                }
            }
        }

        private void ResetZoneZAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Reset Zone Z Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    box.size = new Vector3(box.size.x, box.size.y, 1);
                    box.transform.position = zoneGo.transform.TransformPoint(box.center);
                    box.center = Vector3.zero;
                    box.size -= new Vector3(0, 0, zoneBoundsInset.z);
                }
            }
        }

        private void ResetZoneAllAxesOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    Undo.RecordObject(box, "Reset All Zone Bounds");
                    Undo.RecordObject(box.transform, "Set Zone Transform");
                    box.size = Vector3.one;
                    box.transform.position = zoneGo.transform.TransformPoint(box.center);
                    box.center = Vector3.zero;
                    box.size -= zoneBoundsInset;
                }
            }
        }

        private void ResizeZoneToGeoAndZoneNeighborsOnClick()
        {
            ResizeZoneToXPosOnClick();
            ResizeZoneToXNegOnClick();
            ResizeZoneToYPosOnClick();
            ResizeZoneToYNegOnClick();
            ResizeZoneToZPosOnClick();
            ResizeZoneToZNegOnClick();
        }

        private void SplitColliderXAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> selectedGOsWithBoxCols = new List<GameObject>();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    if (box != null)
                    {
                        selectedGOsWithBoxCols.Add(zoneGo);
                    }
                }
            }

            foreach (GameObject go in selectedGOsWithBoxCols)
            {
                BoxCollider box = go.GetComponent<BoxCollider>();
                Undo.RecordObject(box, "Orig Zone Before Split");
                GameObject tempParentGO = new GameObject(go.name + "TEMP PARENT");
                if (go.transform.parent != null)
                {
                    tempParentGO.transform.parent = go.transform.parent;
                }
                else
                {
                    tempParentGO.transform.parent = null;
                }

                tempParentGO.transform.SetSiblingIndex(go.transform.GetSiblingIndex() + 1);
                tempParentGO.transform.position = go.transform.position;
                tempParentGO.transform.rotation = go.transform.rotation;
                SimpleTransform tempParentOrigTransform = new SimpleTransform(tempParentGO.transform);
                go.transform.parent = tempParentGO.transform;
                go.transform.rotation = Quaternion.Inverse(tempParentOrigTransform.rotation) * tempParentOrigTransform.rotation;
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = go.transform.position;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE SPLIT X of " + go.name;
                cloneGO.transform.parent = tempParentGO.transform;
                BoxCollider boxCol = null;
                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.isTrigger = true;
                        boxCol.size = new Vector3(box.size.x / 2, box.size.y, box.size.z);
                        boxCol.transform.position = new Vector3(box.transform.position.x + box.size.x / 2, box.transform.position.y, box.transform.position.z);
                        boxCol.center = new Vector3(0f, box.center.y, box.center.z);
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                Undo.RecordObject(box, "Orig Zone Resize from Split");
                box.size = new Vector3(box.size.x / 2, box.size.y, box.size.z);
                box.center += new Vector3(-box.size.x / 2, 0f, 0f);
                boxCol.transform.position += new Vector3(box.center.x, 0f, 0f);
                tempParentGO.transform.rotation *= tempParentOrigTransform.rotation;
                if (tempParentGO.transform.parent != null)
                {
                    go.transform.parent = tempParentGO.transform.parent;
                    cloneGO.transform.parent = tempParentGO.transform.parent;
                }
                else
                {
                    go.transform.parent = null;
                    cloneGO.transform.parent = null;
                }

                go.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                cloneGO.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                UnityEngine.Object.DestroyImmediate(tempParentGO);
                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                if (cloneGO)
                {
                    Undo.RegisterCreatedObjectUndo(cloneGO, "Zone created from Split");
                }
                else
                {
                    Debug.Log("Error: Could not create Zone Split for " + go.name);
                }
            }

            Selection.objects = createdZones.ToArray();
        }

        private void SplitColliderYAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> selectedGOsWithBoxCols = new List<GameObject>();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    if (box != null)
                    {
                        selectedGOsWithBoxCols.Add(zoneGo);
                    }
                }
            }

            foreach (GameObject go in selectedGOsWithBoxCols)
            {
                BoxCollider box = go.GetComponent<BoxCollider>();
                Undo.RecordObject(box, "Orig Zone Before Split");
                GameObject tempParentGO = new GameObject(go.name + "TEMP PARENT");
                if (go.transform.parent != null)
                {
                    tempParentGO.transform.parent = go.transform.parent;
                }
                else
                {
                    tempParentGO.transform.parent = null;
                }

                tempParentGO.transform.SetSiblingIndex(go.transform.GetSiblingIndex() + 1);
                tempParentGO.transform.position = go.transform.position;
                tempParentGO.transform.rotation = go.transform.rotation;
                SimpleTransform tempParentOrigTransform = new SimpleTransform(tempParentGO.transform);
                go.transform.parent = tempParentGO.transform;
                go.transform.rotation = Quaternion.Inverse(tempParentOrigTransform.rotation) * tempParentOrigTransform.rotation;
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = go.transform.position;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE SPLIT Y of " + go.name;
                cloneGO.transform.parent = tempParentGO.transform;
                BoxCollider boxCol = null;
                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.isTrigger = true;
                        boxCol.size = new Vector3(box.size.x, box.size.y / 2, box.size.z);
                        boxCol.transform.position = new Vector3(box.transform.position.x, box.transform.position.y + box.size.y / 2, box.transform.position.z);
                        boxCol.center = new Vector3(box.center.x, 0f, box.center.z);
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                Undo.RecordObject(box, "Orig Zone Resize from Split");
                box.size = new Vector3(box.size.x, box.size.y / 2, box.size.z);
                box.center += new Vector3(0f, -box.size.y / 2, 0f);
                boxCol.transform.position += new Vector3(0f, box.center.y, 0f);
                tempParentGO.transform.rotation *= tempParentOrigTransform.rotation;
                if (tempParentGO.transform.parent != null)
                {
                    go.transform.parent = tempParentGO.transform.parent;
                    cloneGO.transform.parent = tempParentGO.transform.parent;
                }
                else
                {
                    go.transform.parent = null;
                    cloneGO.transform.parent = null;
                }

                go.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                cloneGO.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                UnityEngine.Object.DestroyImmediate(tempParentGO);
                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                if (cloneGO)
                {
                    Undo.RegisterCreatedObjectUndo(cloneGO, "Zone created from Split");
                }
                else
                {
                    Debug.Log("Error: Could not create Zone Split for " + go.name);
                }
            }

            Selection.objects = createdZones.ToArray();
        }

        private void SplitColliderZAxisOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> selectedGOsWithBoxCols = new List<GameObject>();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            foreach (GameObject zoneGo in selectedGOs)
            {
                if (zoneGo.GetComponent<Zone>() != null)
                {
                    BoxCollider box = zoneGo.GetComponent<BoxCollider>();
                    if (box != null)
                    {
                        selectedGOsWithBoxCols.Add(zoneGo);
                    }
                }
            }

            foreach (GameObject go in selectedGOsWithBoxCols)
            {
                BoxCollider box = go.GetComponent<BoxCollider>();
                Undo.RecordObject(box, "Orig Zone Before Split");
                GameObject tempParentGO = new GameObject(go.name + "TEMP PARENT");
                if (go.transform.parent != null)
                {
                    tempParentGO.transform.parent = go.transform.parent;
                }
                else
                {
                    tempParentGO.transform.parent = null;
                }

                tempParentGO.transform.SetSiblingIndex(go.transform.GetSiblingIndex() + 1);
                tempParentGO.transform.position = go.transform.position;
                tempParentGO.transform.rotation = go.transform.rotation;
                SimpleTransform tempParentOrigTransform = new SimpleTransform(tempParentGO.transform);
                go.transform.parent = tempParentGO.transform;
                go.transform.rotation = Quaternion.Inverse(tempParentOrigTransform.rotation) * tempParentOrigTransform.rotation;
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = go.transform.position;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE SPLIT Z of " + go.name;
                cloneGO.transform.parent = tempParentGO.transform;
                BoxCollider boxCol = null;
                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.isTrigger = true;
                        boxCol.size = new Vector3(box.size.x, box.size.y, box.size.z / 2);
                        boxCol.transform.position = new Vector3(box.transform.position.x, box.transform.position.y, box.transform.position.z + box.size.z / 2);
                        boxCol.center = new Vector3(box.center.x, box.center.y, 0f);
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                Undo.RecordObject(box, "Orig Zone Resize from Split");
                box.size = new Vector3(box.size.x, box.size.y, box.size.z / 2);
                box.center += new Vector3(0f, 0f, -box.size.z / 2);
                boxCol.transform.position += new Vector3(0f, 0f, box.center.z);
                tempParentGO.transform.rotation *= tempParentOrigTransform.rotation;
                if (tempParentGO.transform.parent != null)
                {
                    go.transform.parent = tempParentGO.transform.parent;
                    cloneGO.transform.parent = tempParentGO.transform.parent;
                }
                else
                {
                    go.transform.parent = null;
                    cloneGO.transform.parent = null;
                }

                go.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                cloneGO.transform.SetSiblingIndex(tempParentGO.transform.GetSiblingIndex() + 1);
                UnityEngine.Object.DestroyImmediate(tempParentGO);
                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                if (cloneGO)
                {
                    Undo.RegisterCreatedObjectUndo(cloneGO, "Zone created from Split");
                }
                else
                {
                    Debug.Log("Error: Could not create Zone Split for " + go.name);
                }
            }

            Selection.objects = createdZones.ToArray();
        }

        private void ToggleColliderEditModeOnClick()
        {
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            if (selectedGOs.Any(x => x.GetComponent<BoxCollider>() != null) && ToolManager.activeToolType.ToString() != "UnityEditor.BoxPrimitiveColliderTool")
            {
                ToolManager.SetActiveTool(Assembly.Load("UnityEditor").GetType("UnityEditor.BoxPrimitiveColliderTool"));
            }
            else
            {
                ToolManager.RestorePreviousPersistentTool();
            }
        }

        private void CreateZoneFromSelectedGeoDimensionsOnClick()
        {
            GameObject zonesHolderParent = GameObject.Find(MarrowSDKPreferences.zonesParentHolderName);
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            GameObject tempParentGO = new GameObject(selectedGOs[0].name + " and neighbors");
            foreach (GameObject go in selectedGOs)
            {
                GameObject clonedSelected = UnityEngine.Object.Instantiate(go);
                clonedSelected.transform.position = go.transform.position;
                clonedSelected.transform.rotation = go.transform.rotation;
                clonedSelected.transform.parent = tempParentGO.transform;
            }

            Renderer[] rends = tempParentGO.GetComponentsInChildren<Renderer>();
            Bounds selectedGOBounds = rends[0].bounds;
            foreach (Renderer rend in rends)
            {
                selectedGOBounds = selectedGOBounds.GrowBounds(rend.bounds);
            }

            GameObject cloneGO = new GameObject();
            cloneGO.transform.position = tempParentGO.transform.position;
            cloneGO.transform.rotation = Quaternion.identity;
            cloneGO.name = "ZONE of " + tempParentGO.name;
            if (zonesHolderParent)
            {
                cloneGO.transform.parent = zonesHolderParent.transform;
            }

            cloneGO.AddComponent<BoxCollider>();
            BoxCollider boxCol = cloneGO.GetComponent<BoxCollider>();
            boxCol.size = selectedGOBounds.size;
            boxCol.center = selectedGOBounds.center;
            boxCol.size -= zoneBoundsInset;
            boxCol.isTrigger = true;
            if (!cloneGO.GetComponent<Zone>())
            {
                cloneGO.AddComponent<Zone>();
                ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                zoneLink.activatorTags.Tags.Add(playerTagQuery);
                cloneGO.AddComponent<ZoneCuller>();
                cloneGO.layer = 29;
                if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                {
                    cloneGO.AddComponent<ZoneChunkLoader>();
                }
            }

            UnityEngine.Object.DestroyImmediate(tempParentGO);
            cloneGO.transform.position = cloneGO.transform.TransformPoint(boxCol.center);
            boxCol.center = Vector3.zero;
            if (!createdZones.Contains(cloneGO))
            {
                createdZones.Add(cloneGO);
            }

            Selection.objects = createdZones.ToArray();
            Undo.RegisterCreatedObjectUndo(cloneGO, "Zone created from Geo Dimensions");
        }

        private void CreateZoneEncapsulatesGeoOnClick()
        {
            GameObject zonesHolderParent = GameObject.Find(MarrowSDKPreferences.zonesParentHolderName);
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            foreach (GameObject go in selectedGOs)
            {
                Renderer[] rends = go.GetComponentsInChildren<Renderer>();
                Bounds selectedGOBounds = rends[0].bounds;
                foreach (Renderer rend in rends)
                {
                    selectedGOBounds = selectedGOBounds.GrowBounds(rend.bounds);
                }

                GameObject cloneGO = new GameObject();
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE of " + go.name;
                BoxCollider boxCol = cloneGO.AddComponent<BoxCollider>();
                cloneGO.transform.position = selectedGOBounds.center;
                boxCol.size = selectedGOBounds.size;
                boxCol.center = Vector3.zero;
                boxCol.size -= zoneBoundsInset;
                boxCol.isTrigger = true;
                if (zonesHolderParent)
                {
                    cloneGO.transform.parent = zonesHolderParent.transform;
                }

                if (!cloneGO.GetComponent<Zone>())
                {
                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                Selection.objects = createdZones.ToArray();
            }
        }

        private void CreateZoneFromGeoOnClick()
        {
            GameObject zonesHolderParent = GameObject.Find(MarrowSDKPreferences.zonesParentHolderName);
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            BoxCollider boxCol;
            foreach (GameObject go in selectedGOs)
            {
                if (go.GetComponent<MeshRenderer>() != null && go.GetComponent<MeshFilter>() != null)
                {
                    bool hasConvexMeshTrigger = false;
                    if (go.GetComponent<MeshCollider>() != null && go.GetComponent<MeshCollider>().convex && go.GetComponent<MeshCollider>().isTrigger)
                    {
                        hasConvexMeshTrigger = true;
                    }

                    GameObject cloneGO = null;
                    Quaternion origRotation = go.transform.rotation;
                    if (hasConvexMeshTrigger)
                    {
                        cloneGO = UnityEngine.Object.Instantiate(go, go.transform.position, go.transform.rotation);
                    }
                    else
                    {
                        cloneGO = UnityEngine.Object.Instantiate(go, go.transform.position, Quaternion.identity);
                    }

                    cloneGO.name = "ZONE of " + go.name;
                    if (zonesHolderParent)
                    {
                        cloneGO.transform.parent = zonesHolderParent.transform;
                    }

                    for (int i = cloneGO.transform.childCount - 1; i >= 0; i--)
                    {
                        UnityEngine.Object.DestroyImmediate(cloneGO.transform.GetChild(i).gameObject);
                    }

                    foreach (BoxCollider box in cloneGO.GetComponents<BoxCollider>())
                    {
                        UnityEngine.Object.DestroyImmediate(box);
                    }

                    if (!hasConvexMeshTrigger)
                    {
                        boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.isTrigger = true;
                        boxCol.size -= zoneBoundsInset;
                    }

                    foreach (Component component in cloneGO.GetComponents<Component>())
                    {
                        if (GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(cloneGO) > 0)
                        {
                            GameObjectUtility.RemoveMonoBehavioursWithMissingScript(cloneGO);
                        }

                        if (hasConvexMeshTrigger)
                        {
                            cloneGO.GetComponent<MeshRenderer>().enabled = false;
                        }
                        else
                        {
                            if (component != null && component.GetType() != typeof(BoxCollider) && component.GetType() != typeof(Transform) && component.GetType() != typeof(Zone) && component.GetType() != typeof(MeshRenderer) && component.GetType() != typeof(MeshFilter))
                            {
                                try
                                {
                                    UnityEngine.Object.DestroyImmediate(component);
                                }
                                catch
                                {
                                }
                            }
                        }
                    }

                    if (cloneGO.GetComponent<MeshFilter>() != null || cloneGO.GetComponent<MeshRenderer>() != null)
                    {
                        try
                        {
                            MeshFilter meshFilter = cloneGO.GetComponent<MeshFilter>();
                            UnityEngine.Object.DestroyImmediate(meshFilter);
                            MeshRenderer meshRend = cloneGO.GetComponent<MeshRenderer>();
                            UnityEngine.Object.DestroyImmediate(meshRend);
                        }
                        catch
                        {
                        }
                    }

                    if (!cloneGO.GetComponent<Zone>())
                    {
                        cloneGO.AddComponent<Zone>();
                        ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                        zoneLink.activatorTags.Tags.Add(playerTagQuery);
                        cloneGO.AddComponent<ZoneCuller>();
                        cloneGO.layer = 29;
                        if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                        {
                            cloneGO.AddComponent<ZoneChunkLoader>();
                        }
                    }

                    if (hasConvexMeshTrigger)
                    {
                        if (cloneGO.GetComponent<BoxCollider>())
                        {
                            cloneGO.GetComponent<BoxCollider>().enabled = false;
                        }
                    }
                    else
                    {
                        cloneGO.transform.rotation = origRotation;
                    }

                    Undo.RegisterCreatedObjectUndo(cloneGO, "Zone created from Geo");
                    if (!createdZones.Contains(cloneGO))
                    {
                        createdZones.Add(cloneGO);
                    }
                }
            }

            Selection.objects = createdZones.ToArray();
        }

        [MenuItem("GameObject/MarrowSDK/Default Zone", priority = 4)]
        private static void CreateDefaultZoneMenu(MenuCommand menuCommand)
        {
            GameObject zonesHolderParent = GameObject.Find(MarrowSDKPreferences.zonesParentHolderName);
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> createdZones = new List<GameObject>();
            TagQuery playerTagQuery = new TagQuery();
            BoneTagReference btRef = new BoneTagReference(MarrowSettings.RuntimeInstance.PlayerTag.Barcode);
            playerTagQuery.BoneTag = btRef;
            foreach (GameObject go in selectedGOs)
            {
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = go.transform.position;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE of " + go.name;
                if (zonesHolderParent)
                {
                    cloneGO.transform.parent = zonesHolderParent.transform;
                }

                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        BoxCollider boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.size -= zoneBoundsInsetMenu;
                        boxCol.isTrigger = true;
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                Undo.RegisterCreatedObjectUndo(cloneGO, "Default Zone Created");
            }

            if (selectedGOs == null || selectedGOs.Count == 0)
            {
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = Vector3.zero;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE Default";
                if (zonesHolderParent)
                {
                    cloneGO.transform.parent = zonesHolderParent.transform;
                }

                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        BoxCollider boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.size -= zoneBoundsInsetMenu;
                        boxCol.isTrigger = true;
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                Undo.RegisterCreatedObjectUndo(cloneGO, "Default Zone Created");
                Debug.Log($"Default Zone created at origin with Inset {zoneBoundsInsetMenu}.");
            }

            Selection.objects = createdZones.ToArray();
            bool overlayShown = false;
            bool overlayCollapsed = false;
            ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => overlayShown = instance.displayed);
            ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => overlayCollapsed = instance.collapsed);
            if (overlayShown == false)
            {
                if (UnityEngine.Object.FindObjectsOfType<Zone>().Length == 1)
                {
                    ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                    ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
                }
            }

            if (overlayCollapsed == true)
            {
                if (UnityEngine.Object.FindObjectsOfType<Zone>().Length == 1)
                {
                    ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
                }
            }
        }

        private void CreateDefaultZoneOnClick()
        {
            GameObject zonesHolderParent = GameObject.Find(MarrowSDKPreferences.zonesParentHolderName);
            List<GameObject> selectedGOs = Selection.gameObjects.ToList();
            List<GameObject> createdZones = new List<GameObject>();
            if (playerTagQuery == null)
            {
                playerTagQuery = GetPlayerTagQuery();
            }

            foreach (GameObject go in selectedGOs)
            {
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = go.transform.position;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE of " + go.name;
                if (zonesHolderParent)
                {
                    cloneGO.transform.parent = zonesHolderParent.transform;
                }

                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        BoxCollider boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.size -= zoneBoundsInset;
                        boxCol.isTrigger = true;
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                Undo.RegisterCreatedObjectUndo(cloneGO, "Default Zone Created");
            }

            if (selectedGOs == null || selectedGOs.Count == 0)
            {
                GameObject cloneGO = new GameObject();
                cloneGO.transform.position = Vector3.zero;
                cloneGO.transform.rotation = Quaternion.identity;
                cloneGO.name = "ZONE Default";
                if (zonesHolderParent)
                {
                    cloneGO.transform.parent = zonesHolderParent.transform;
                }

                if (!cloneGO.GetComponent<Zone>())
                {
                    if (!cloneGO.GetComponent<BoxCollider>())
                    {
                        BoxCollider boxCol = cloneGO.AddComponent<BoxCollider>();
                        boxCol.size -= zoneBoundsInset;
                        boxCol.isTrigger = true;
                    }

                    cloneGO.AddComponent<Zone>();
                    ZoneLink zoneLink = cloneGO.AddComponent<ZoneLink>();
                    zoneLink.activatorTags.Tags.Add(playerTagQuery);
                    cloneGO.AddComponent<ZoneCuller>();
                    cloneGO.layer = 29;
                    if (GameObject.FindObjectOfType(typeof(SceneChunk)) != null)
                    {
                        cloneGO.AddComponent<ZoneChunkLoader>();
                    }
                }

                if (!createdZones.Contains(cloneGO))
                {
                    createdZones.Add(cloneGO);
                }

                Undo.RegisterCreatedObjectUndo(cloneGO, "Default Zone Created");
                Debug.Log($"Default Zone created at origin with Inset {zoneBoundsInset}.");
            }

            Selection.objects = createdZones.ToArray();
        }

        private void ConnectChildAudioToZone(Zone zone)
        {
            ZoneLink parentZoneLink = zone.GetComponent<ZoneLink>();
            foreach (ZoneMusic zoneMusic in zone.GetComponentsInChildren<ZoneMusic>())
            {
                SetZoneMusicZoneLink(zoneMusic, parentZoneLink);
            }

            foreach (ZoneAmbience zoneAmbience in zone.GetComponentsInChildren<ZoneAmbience>())
            {
                SetZoneAmbienceZoneLink(zoneAmbience, parentZoneLink);
            }
        }

        private static void ConnectChildAudioToZoneMenu(Zone zone)
        {
            ZoneLink parentZoneLink = zone.GetComponent<ZoneLink>();
            foreach (ZoneMusic zoneMusic in zone.GetComponentsInChildren<ZoneMusic>())
            {
                SetZoneMusicZoneLinkMenu(zoneMusic, parentZoneLink);
            }

            foreach (ZoneAmbience zoneAmbience in zone.GetComponentsInChildren<ZoneAmbience>())
            {
                SetZoneAmbienceZoneLinkMenu(zoneAmbience, parentZoneLink);
            }
        }

        private static void SetZoneMusicZoneLinkMenu(ZoneMusic zoneMusicChild, ZoneLink parentZoneLink)
        {
            Type type = zoneMusicChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneMusicChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneMusicChild, parentZoneLink);
            }
        }

        private static void SetZoneAmbienceZoneLinkMenu(ZoneAmbience zoneAmbienceChild, ZoneLink parentZoneLink)
        {
            Type type = zoneAmbienceChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneAmbienceChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneAmbienceChild, parentZoneLink);
            }
        }

        private void SetZoneMusicZoneLink(ZoneMusic zoneMusicChild, ZoneLink parentZoneLink)
        {
            Type type = zoneMusicChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneMusicChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneMusicChild, parentZoneLink);
            }
        }

        private void SetZoneAmbienceZoneLink(ZoneAmbience zoneAmbienceChild, ZoneLink parentZoneLink)
        {
            Type type = zoneAmbienceChild.GetType();
            FieldInfo fieldInfo = null;
            while (fieldInfo == null && type != null)
            {
                fieldInfo = type.GetField("_zoneLink", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                type = type.BaseType;
            }

            if (fieldInfo == null)
            {
                throw new ArgumentOutOfRangeException("propName", "Field _zoneLink was not found in Type " + zoneAmbienceChild.GetType().FullName);
            }

            if (parentZoneLink != null)
            {
                fieldInfo.SetValue(zoneAmbienceChild, parentZoneLink);
            }
        }

        private TagQuery GetPlayerTagQuery()
        {
            var playerTagQuery = new TagQuery();
            BoneTagReference btRef = new BoneTagReference(MarrowSettings.RuntimeInstance.PlayerTag.Barcode);
            playerTagQuery.BoneTag = btRef;
            return playerTagQuery;
        }

        private void SortLinkedZonesByNameOnClick()
        {
            List<ZoneLink> zoneList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
            foreach (var zone in zoneList)
            {
                Undo.RecordObject(zone, "Sort Zone ZoneLinks");
                IComparer linkedZoneNameSorter = new ZoneLinkNameSorter();
                System.Array.Sort(zone.zoneLinks, linkedZoneNameSorter);
            }
        }

        private void RemoveEmptyOrDupLinksOnClick()
        {
            List<ZoneLink> zoneList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
            List<ZoneLink> linkedZoneNoEmpties = new List<ZoneLink>();
            foreach (var zone in zoneList)
            {
                linkedZoneNoEmpties.Clear();
                if (zone.zoneLinks != null)
                {
                    foreach (var linkedZone in zone.zoneLinks)
                    {
                        if (linkedZone != null && !linkedZoneNoEmpties.Contains(linkedZone) && linkedZone != zone)
                        {
                            linkedZoneNoEmpties.Add(linkedZone);
                        }
                    }

                    Undo.RecordObject(zone, "Cull Dup/Empty Zone ZoneLinks");
                    zone.zoneLinks = linkedZoneNoEmpties.ToArray();
                }
            }

            foreach (ZoneLink zoneLink in zoneList)
            {
                foreach (ZoneLink zl in zoneLink.zoneLinks)
                {
                    List<ZoneLink> linksOfZoneLink = zl.zoneLinks.ToList();
                    if (!linksOfZoneLink.Contains(zoneLink))
                    {
                        Debug.Log($"ONE WAY LINK FOUND: {zl.name} does not contain {zoneLink.name} but {zoneLink.name} contains {zl.name}. Forcing 2-way link.");
                        linksOfZoneLink.Add(zoneLink);
                        zl.zoneLinks = linksOfZoneLink.ToArray();
                    }
                }
            }
        }

        private static void RemoveEmptyOrDupLinksMenu()
        {
            List<ZoneLink> zoneList = UnityEngine.Object.FindObjectsOfType<ZoneLink>().ToList();
            List<ZoneLink> linkedZoneNoEmpties = new List<ZoneLink>();
            foreach (var zone in zoneList)
            {
                linkedZoneNoEmpties.Clear();
                if (zone.zoneLinks != null)
                {
                    foreach (var linkedZone in zone.zoneLinks)
                    {
                        if (linkedZone != null && !linkedZoneNoEmpties.Contains(linkedZone) && linkedZone != zone)
                        {
                            linkedZoneNoEmpties.Add(linkedZone);
                        }
                    }

                    Undo.RecordObject(zone, "Cull Dup/Empty Zone ZoneLinks");
                    zone.zoneLinks = linkedZoneNoEmpties.ToArray();
                }
            }

            foreach (ZoneLink zoneLink in zoneList)
            {
                foreach (ZoneLink zl in zoneLink.zoneLinks)
                {
                    List<ZoneLink> linksOfZoneLink = zl.zoneLinks.ToList();
                    if (!linksOfZoneLink.Contains(zoneLink))
                    {
                        Debug.Log($"ONE WAY LINK FOUND: {zl.name} does not contain {zoneLink.name} but {zoneLink.name} contains {zl.name}. Forcing 2-way link.");
                        linksOfZoneLink.Add(zoneLink);
                        zl.zoneLinks = linksOfZoneLink.ToArray();
                    }
                }
            }
        }

        private void AddSelectedZonesToLinkedZonesOnClick()
        {
            GameObject[] zoneGOs = Selection.gameObjects.ToArray();
            List<ZoneLink> selectedZones = new List<ZoneLink>();
            foreach (GameObject go in zoneGOs)
            {
                if (go.GetComponent<ZoneLink>() && !selectedZones.Contains(go.GetComponent<ZoneLink>()))
                {
                    selectedZones.Add(go.GetComponent<ZoneLink>());
                }
            }

            foreach (var zone in selectedZones)
            {
                List<ZoneLink> linkedZonesList = new List<ZoneLink>();
                if (zone.zoneLinks != null)
                {
                    linkedZonesList = zone.zoneLinks.ToList();
                }

                linkedZonesList.AddRange(selectedZones);
                if (linkedZonesList.Contains(zone))
                {
                    linkedZonesList.Remove(zone);
                }

                Undo.RecordObject(zone, "Update Zone ZoneLinks");
                zone.zoneLinks = linkedZonesList.ToArray();
            }

            foreach (GameObject go in zoneGOs)
            {
                var selectedZone = go.GetComponent<ZoneLink>();
                var linkedZones = selectedZone.zoneLinks.ToList();
                if (selectedZone.zoneLinks != null && linkedZones.Contains(selectedZone))
                {
                    linkedZones.Remove(selectedZone);
                }

                selectedZone.zoneLinks = linkedZones.ToArray();
            }

            RemoveEmptyOrDupLinksOnClick();
        }

        private void LinkSelectedZonesToEachOtherOnClick()
        {
            GameObject[] zoneGOs = Selection.gameObjects.ToArray();
            var zones = new List<ZoneLink>();
            foreach (GameObject go in zoneGOs)
            {
                zones.Add(go.GetComponent<ZoneLink>());
            }

            foreach (var zone in zones)
            {
                var linkedZones = new List<ZoneLink>();
                foreach (var refZone in zones)
                {
                    if (zone == refZone)
                        continue;
                    linkedZones.Add(refZone);
                }

                Undo.RecordObject(zone, "Update Zone ZoneLinks");
                zone.zoneLinks = linkedZones.ToArray();
                EditorUtility.SetDirty(zone);
            }
        }

        private void AddLinkedZonesToSelectionOnClick()
        {
            GameObject[] zoneGOs = Selection.gameObjects.ToArray();
            var zones = new List<ZoneLink>();
            List<GameObject> newGOSelectionList = new List<GameObject>();
            foreach (GameObject go in zoneGOs)
            {
                zones.Add(go.GetComponent<ZoneLink>());
                newGOSelectionList.Add(go);
            }

            foreach (var zone in zones)
            {
                foreach (var linkedZone in zone.zoneLinks)
                {
                    if (!newGOSelectionList.Contains(linkedZone.gameObject))
                    {
                        newGOSelectionList.Add(linkedZone.gameObject);
                    }
                }
            }

            Selection.objects = newGOSelectionList.ToArray();
        }

        private void RemoveSelectedLinksOnClick()
        {
            GameObject[] zoneGOs = Selection.gameObjects.ToArray();
            var selZoneLinks = new List<ZoneLink>();
            foreach (GameObject go in zoneGOs)
            {
                selZoneLinks.Add(go.GetComponent<ZoneLink>());
            }

            foreach (var selZoneLink in selZoneLinks)
            {
                var zoneLinksList = selZoneLink.zoneLinks.ToList();
                foreach (ZoneLink selzLink in selZoneLinks)
                {
                    if (zoneLinksList.Contains(selzLink))
                    {
                        zoneLinksList.Remove(selzLink);
                    }

                    Undo.RecordObject(selZoneLink, "Update Zone ZoneLinks");
                    selZoneLink.zoneLinks = zoneLinksList.ToArray();
                }

                RemoveEmptyOrDupLinksOnClick();
            }
        }

        private void CreateSceneFromSelectedGOsOnClick(string sceneFilename, string scenePath)
        {
            bool sceneAlreadyExists = false;
            List<GameObject> selectedObjects = Selection.gameObjects.ToList();
            for (int s = 0; s < EditorSceneManager.sceneCount; s++)
            {
                if (EditorSceneManager.GetSceneAt(s).name == sceneFilename)
                {
                    sceneAlreadyExists = true;
                }
            }

            if (EditorSceneManager.GetSceneAt(0) != null && sceneAlreadyExists == false)
            {
                char[] invalidPathChars = Path.GetInvalidPathChars();
                if (sceneFilename.Trim().Length > 0)
                {
                    foreach (char c in invalidPathChars)
                    {
                        if (sceneFilename.Contains(c))
                        {
                            sceneFilename = sceneFilename.Replace(c.ToString(), String.Empty);
                        }
                    }

                    var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Additive);
                    newScene.name = sceneFilename;
                    EditorSceneManager.SaveScene(newScene, scenePath + "/" + sceneFilename + ".unity");
                    Debug.Log("Scene Saved at " + scenePath + "/" + sceneFilename + ".unity");
                    List<GameObject> rootObjectsInSel = new List<GameObject>();
                    for (int g = 0; g < selectedObjects.Count; g++)
                    {
                        GameObject selectedObj = selectedObjects[g];
                        bool isChildOfSelected = false;
                        foreach (GameObject checkSelectedObj in Selection.objects)
                        {
                            if (checkSelectedObj != selectedObj && selectedObj.transform.IsChildOf(checkSelectedObj.transform))
                            {
                                isChildOfSelected = true;
                            }
                        }

                        if (isChildOfSelected == false && !rootObjectsInSel.Contains(selectedObj))
                        {
                            rootObjectsInSel.Add(selectedObj);
                        }
                    }

                    for (int r = 0; r < rootObjectsInSel.Count; r++)
                    {
                        Undo.RecordObject(rootObjectsInSel[r], "SceneChunk Move");
                        Undo.RecordObject(rootObjectsInSel[r].transform, "SceneChunk Move Transform");
                        EditorSceneManager.MoveGameObjectToScene(rootObjectsInSel[r], newScene);
                    }

                    EditorSceneManager.SetActiveScene(EditorSceneManager.GetSceneAt(0));
                    string sceneGUID = AssetDatabase.AssetPathToGUID(newScene.path);
                    if (sceneGUID != "" || sceneGUID != null)
                    {
                        GameObject sceneChunkHolderParent = GameObject.Find("SCENECHUNKS");
                        if (sceneChunkHolderParent == null)
                        {
                            sceneChunkHolderParent = new GameObject("SCENECHUNKS");
                        }

                        GameObject newSceneChunkObj = new GameObject(newScene.name + " SceneChunk");
                        SceneChunk newSceneChunk = newSceneChunkObj.AddComponent<SceneChunk>();
                        MarrowScene newMarrowScene = new MarrowScene(sceneGUID);
                        newSceneChunk.transform.parent = sceneChunkHolderParent.transform;
                        if (newMarrowScene != null)
                        {
                            List<MarrowScene> newMarrowSceneList = new List<MarrowScene>
                            {
                                newMarrowScene
                            };
                            newSceneChunk.sceneLayers = newMarrowSceneList.ToArray();
                        }

                        Selection.activeGameObject = newSceneChunkObj;
                        SceneChunk.showZoneCullerHandles = true;
                    }
                }
            }
        }

        private string SceneChunkFilePathOnClick()
        {
            string defaultPathNoFile = EditorSceneManager.GetSceneAt(0).path.Substring(0, EditorSceneManager.GetSceneAt(0).path.LastIndexOf('/'));
            string[] sceneFileFilters =
            {
                "Unity",
                "unity"
            };
            string newFilePath = EditorUtility.OpenFolderPanel("Path to Save Additive Scenes", defaultPathNoFile, "");
            return newFilePath;
        }

        public class ZoneLinkNameSorter : IComparer
        {
            int IComparer.Compare(System.Object x, System.Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(((ZoneLink)x).name, ((ZoneLink)y).name));
            }
        }

        private static List<ZoneCreateLinkOverlayToolbar> instances = new List<ZoneCreateLinkOverlayToolbar>();
        public override void OnCreated()
        {
            instances.Add(this);
        }

        public override void OnWillBeDestroyed()
        {
            instances.Remove(this);
        }

        public static void DoWithInstances(Action<ZoneCreateLinkOverlayToolbar> doWithInstance)
        {
            foreach (var instance in instances)
            {
                doWithInstance(instance);
            }
        }
    }

    public static class BoundsExtension
    {
        public static Bounds GrowBounds(this Bounds a, Bounds b)
        {
            Vector3 max = Vector3.Max(a.max, b.max);
            Vector3 min = Vector3.Min(a.min, b.min);
            a = new Bounds((max + min) * 0.5f, max - min);
            return a;
        }
    }
}
#endif
