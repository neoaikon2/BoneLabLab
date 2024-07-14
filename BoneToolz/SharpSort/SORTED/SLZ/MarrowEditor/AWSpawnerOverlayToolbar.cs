#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEditor;
using UnityEditor.Overlays;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UIElements.Image;
using Object = UnityEngine.Object;

namespace SLZ.MarrowEditor
{
    [Icon(AW_ICON)]
    [Overlay(typeof(SceneView), id: ID_OVERLAY_AWSPAWNABLE, displayName: "AW Spawner")]
    public class AWSpawnerOverlayToolbar : Overlay
    {
        private const string ID_OVERLAY_AWSPAWNABLE = "aw-spawnable-overlay-toolbar";
        private const string COLLAPSED_TOOLTIP = "Select a Spawnable and Drag it into the Scene";
        private const string EXPANDED_TOOLTIP = "Select a Spawnable";
        private const string PREFAB_PATH = "Assets/Prefabs/Crate Spawner (Template).prefab";
        private const string AW_ICON = "Packages/com.stresslevelzero.marrow.sdk/Editor/Assets/Icons/Warehouse/crate-ball";
        private string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("dbfc5de6760262742b53757740b68b9f");
        private SpawnableCrate currentCrate = null;
        GameObject spawnablePrefab = null;
        Toggle spawnableShowPreviewsToggle;
        Toggle spawnableGridModeToggle;
        Toggle awOverlaySettingsToggle;
        private string zoneIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Zone_Icons");
        public override VisualElement CreatePanelContent()
        {
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            VisualElement rootVisualElement = new VisualElement();
            rootVisualElement.Add(tree);
            Label dragSpawnableLabel = rootVisualElement.Q<Label>("dragSpawnableLabel");
            Button initializeOverlayButton = new Button();
            VisualElement awSpawnerParentContainer = rootVisualElement.Q<VisualElement>("awSpawnerParentContainer");
            VisualElement awOverlaySettingsContainer = rootVisualElement.Q<VisualElement>("awOverlaySettingsContainer");
            VisualElement spawnablesListParentContainer = rootVisualElement.Q<VisualElement>("spawnablesListParentContainer");
            VisualElement dragSpawnablePreviewContainer = rootVisualElement.Q<VisualElement>("dragSpawnablePreviewContainer");
            VisualElement dragSpawnableImageContainer = rootVisualElement.Q<VisualElement>("dragSpawnableImageContainer");
            VisualElement spawnablesListContainer = rootVisualElement.Q<VisualElement>("spawnablesListContainer");
            ScrollView spawnablesGridScrollView = rootVisualElement.Q<ScrollView>("spawnablesGridScrollView");
            ToolbarSearchField spawnablesSearchField = rootVisualElement.Q<ToolbarSearchField>("spawnablesSearchField");
            ListView spawnablesListView = rootVisualElement.Q<ListView>("spawnablesListView");
            spawnableShowPreviewsToggle = rootVisualElement.Q<Toggle>("spawnableShowPreviewsToggle");
            awOverlaySettingsToggle = rootVisualElement.Q<Toggle>("awOverlaySettingsToggle");
            spawnableGridModeToggle = rootVisualElement.Q<Toggle>("spawnableGridModeToggle");
            Toggle spawnableShowBitsToggle = rootVisualElement.Q<Toggle>("spawnableShowBitsToggle");
            Image awSettingsIconImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(zoneIconPath, "Icon_marrow_settingsConfigurationa.png")) as Texture2D
            };
            if (awSettingsIconImage != null)
            {
                awOverlaySettingsToggle.label = "";
            }

            awOverlaySettingsToggle.Add(awSettingsIconImage);
            awSettingsIconImage.StretchToParentSize();
            SliderInt awImageSizeSlider = rootVisualElement.Q<SliderInt>("awImageSizeSlider");
            SliderInt awGridSceneHorizPercentSlider = rootVisualElement.Q<SliderInt>("awGridSceneHorizPercentSlider");
            SliderInt awGridSceneVertPercentSlider = rootVisualElement.Q<SliderInt>("awGridSceneVertPercentSlider");
            SliderInt awListSceneVertPercentSlider = rootVisualElement.Q<SliderInt>("awListSceneVertPercentSlider");
            Button awSettingsApplyButton = rootVisualElement.Q<Button>("awSettingsApplyButton");
            List<SpawnableCrate> spawnableCratesList = new List<SpawnableCrate>();
            AssetWarehouse.OnReady(() =>
            {
                List<Pallet> AWPalletsList = AssetWarehouse.Instance.GetPallets();
                if (MarrowSDKPreferences.awSpawnerGridMode == true)
                {
                    spawnablesGridScrollView.style.display = DisplayStyle.Flex;
                    spawnablesListView.style.display = DisplayStyle.None;
                    dragSpawnableLabel.style.display = DisplayStyle.None;
                    CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                }
                else
                {
                    spawnablesGridScrollView.style.display = DisplayStyle.None;
                    spawnablesListView.style.display = DisplayStyle.Flex;
                    dragSpawnableLabel.style.display = DisplayStyle.Flex;
                    CreateSpawnableCratesList(AWPalletsList, spawnableCratesList, spawnablesListView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                }

                spawnablesSearchField.RegisterValueChangedCallback(evt =>
                {
                    ScannableQueryEngine.scanQuerySearchErrorCount = 0;
                    if (MarrowSDKPreferences.awSpawnerGridMode == true)
                    {
                        CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                        dragSpawnableLabel.style.display = DisplayStyle.None;
                    }
                    else
                    {
                        CreateSpawnableCratesList(AWPalletsList, spawnableCratesList, spawnablesListView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                        dragSpawnableLabel.style.display = DisplayStyle.Flex;
                    }
                });
            });
            spawnableShowPreviewsToggle.value = MarrowSDKPreferences.awSpawnerOverlayPreviews;
            spawnableGridModeToggle.value = MarrowSDKPreferences.awSpawnerGridMode;
            awImageSizeSlider.value = MarrowSDKPreferences.awSpawnerImageSize;
            awGridSceneHorizPercentSlider.value = MarrowSDKPreferences.awSpawnerGridSceneHorizPercent;
            awGridSceneVertPercentSlider.value = MarrowSDKPreferences.awSpawnerGridSceneVertPercent;
            awListSceneVertPercentSlider.value = MarrowSDKPreferences.awSpawnerListSceneVertPercent;
            initializeOverlayButton.text = "Initialize Overlay";
            initializeOverlayButton.clickable.clicked += InitializeOverlay;
            awSettingsApplyButton.clickable.clicked += AWSettingsApplyButtonOnClick;
            if (MarrowSDKPreferences.awSpawnerGridMode == true)
            {
                dragSpawnableLabel.style.visibility = Visibility.Hidden;
            }
            else
            {
                dragSpawnableLabel.style.visibility = Visibility.Visible;
                if (this.collapsed)
                {
                    dragSpawnableLabel.style.paddingTop = 5;
                    dragSpawnableLabel.style.paddingBottom = 5;
                    if (currentCrate)
                    {
                        dragSpawnableLabel.text = "Drag To Scene";
                    }
                    else
                    {
                        dragSpawnableLabel.text = "Select Spawnable";
                    }

                    dragSpawnableLabel.tooltip = COLLAPSED_TOOLTIP;
                }
                else
                {
                    dragSpawnableLabel.style.paddingTop = 5;
                    dragSpawnableLabel.style.paddingBottom = 5;
                    dragSpawnableLabel.text = "Select AW\nSpawnable";
                    dragSpawnableLabel.tooltip = EXPANDED_TOOLTIP;
                }
            }

            Texture2D spawnableIcon = EditorGUIUtility.Load(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-ball.png")) as Texture2D;
            Image dragSpawnableTexture = new Image();
            dragSpawnableImageContainer.Add(dragSpawnableTexture);
            if (this.collapsed)
            {
                dragSpawnableTexture.image = spawnableIcon;
                dragSpawnableTexture.tooltip = COLLAPSED_TOOLTIP;
            }
            else
            {
                dragSpawnableTexture.image = spawnableIcon;
                dragSpawnableTexture.tooltip = EXPANDED_TOOLTIP;
            }

            dragSpawnableTexture.RegisterCallback<MouseDownEvent>(evt =>
            {
                DragAndDrop.PrepareStartDrag();
                if (spawnablePrefab != null)
                {
                    DragAndDrop.StartDrag("Dragging");
                    DragAndDrop.objectReferences = new Object[]
                    {
                        spawnablePrefab
                    };
                }
            });
            dragSpawnableTexture.RegisterCallback<DragUpdatedEvent>(evt =>
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                if (spawnablePrefab != null && currentCrate != null && spawnablePrefab.GetComponent<CrateSpawner>() && spawnablePrefab.name != "Crate Spawner (" + currentCrate.name.ToString() + ")")
                {
                    spawnablePrefab.name = "Crate Spawner (" + currentCrate.name.ToString() + ")";
                    spawnablePrefab.GetComponent<CrateSpawner>().spawnableCrateReference = new SpawnableCrateReference(currentCrate.Barcode);
                    spawnablePrefab.GetComponent<MeshFilter>().sharedMesh = currentCrate.PreviewMesh.EditorAsset;
                }
            });
            dragSpawnableLabel.RegisterCallback<MouseDownEvent>(evt =>
            {
                DragAndDrop.PrepareStartDrag();
                if (spawnablePrefab != null && currentCrate != null)
                {
                    DragAndDrop.StartDrag("Dragging");
                    DragAndDrop.objectReferences = new Object[]
                    {
                        spawnablePrefab
                    };
                }
            });
            dragSpawnableLabel.RegisterCallback<DragUpdatedEvent>(evt =>
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                if (spawnablePrefab != null && currentCrate != null && spawnablePrefab.GetComponent<CrateSpawner>() && spawnablePrefab.name != "Crate Spawner (" + currentCrate.name.ToString() + ")")
                {
                    spawnablePrefab.name = "Spawnable Placer (" + currentCrate.name.ToString() + ")";
                    spawnablePrefab.GetComponent<CrateSpawner>().spawnableCrateReference = new SpawnableCrateReference(currentCrate.Barcode);
                    spawnablePrefab.GetComponent<MeshFilter>().sharedMesh = currentCrate.PreviewMesh.EditorAsset;
                    PrefabUtility.RevertObjectOverride(spawnablePrefab, InteractionMode.AutomatedAction);
                }
            });
            rootVisualElement.Add(initializeOverlayButton);
            if (this.collapsed && currentCrate != null)
            {
                SetOverlayContents(dragSpawnableLabel, dragSpawnableTexture);
                this.collapsed = false;
                this.collapsed = true;
            }

            CheckOverlayPrefabInit(dragSpawnableLabel, dragSpawnableTexture, initializeOverlayButton, spawnablesListContainer);
            spawnablesListView.onSelectionChange += selectedObjects =>
            {
                SpawnableCrate selectedSpawnable = (SpawnableCrate)selectedObjects.First();
                CheckOverlayPrefabInit(dragSpawnableLabel, dragSpawnableTexture, initializeOverlayButton, spawnablesListContainer);
                if (File.Exists(PREFAB_PATH) && spawnablePrefab == null)
                {
                    SetSpawnablePrefab();
                }

                if (selectedSpawnable != null && spawnablePrefab != null)
                {
                    if (selectedSpawnable is SpawnableCrate)
                    {
                        SpawnableCrate crateObj = selectedSpawnable;
                        currentCrate = crateObj;
                        dragSpawnableLabel.tooltip = "Click here and drag into the Scene to create a Crate Spawner for [" + crateObj.name.ToString() + "]";
                        dragSpawnableTexture.tooltip = "Click here and drag into the Scene to create a Crate Spawner for [" + crateObj.name.ToString() + "]";
                        SetOverlayContents(dragSpawnableLabel, dragSpawnableTexture);
                    }
                }
            };
            spawnableShowPreviewsToggle.RegisterValueChangedCallback(evt =>
            {
                if (spawnableShowPreviewsToggle.value == true)
                {
                    MarrowSDKPreferences.awSpawnerOverlayPreviews = true;
                }
                else
                {
                    MarrowSDKPreferences.awSpawnerOverlayPreviews = false;
                }

                if (this.collapsed)
                {
                    this.collapsed = false;
                    this.collapsed = true;
                }
                else
                {
                    this.collapsed = true;
                    this.collapsed = false;
                }
            });
            spawnableGridModeToggle.RegisterValueChangedCallback(evt =>
            {
                if (spawnableGridModeToggle.value == true)
                {
                    MarrowSDKPreferences.awSpawnerOverlayPreviews = true;
                    MarrowSDKPreferences.awSpawnerGridMode = true;
                }
                else
                {
                    MarrowSDKPreferences.awSpawnerGridMode = false;
                }

                if (this.collapsed)
                {
                    this.collapsed = false;
                    this.collapsed = true;
                }
                else
                {
                    this.collapsed = true;
                    this.collapsed = false;
                }
            });
            awOverlaySettingsToggle.RegisterValueChangedCallback(evt =>
            {
                if (awOverlaySettingsToggle.value == true)
                {
                    awOverlaySettingsContainer.style.display = DisplayStyle.Flex;
                }
                else
                {
                    awOverlaySettingsContainer.style.display = DisplayStyle.None;
                }
            });
            awImageSizeSlider.RegisterValueChangedCallback(evt =>
            {
                MarrowSDKPreferences.awSpawnerImageSize = awImageSizeSlider.value;
            });
            awGridSceneHorizPercentSlider.RegisterValueChangedCallback(evt =>
            {
                MarrowSDKPreferences.awSpawnerGridSceneHorizPercent = awGridSceneHorizPercentSlider.value;
            });
            awGridSceneVertPercentSlider.RegisterValueChangedCallback(evt =>
            {
                MarrowSDKPreferences.awSpawnerGridSceneVertPercent = awGridSceneVertPercentSlider.value;
            });
            awListSceneVertPercentSlider.RegisterValueChangedCallback(evt =>
            {
                MarrowSDKPreferences.awSpawnerListSceneVertPercent = awListSceneVertPercentSlider.value;
            });
            if (MarrowSDKPreferences.awSpawnerGridMode == true)
            {
                spawnablesGridScrollView.style.maxWidth = Screen.width * MarrowSDKPreferences.awSpawnerGridSceneHorizPercent / 100;
                spawnablesGridScrollView.style.maxHeight = Screen.height * MarrowSDKPreferences.awSpawnerGridSceneVertPercent / 100;
                dragSpawnablePreviewContainer.style.display = DisplayStyle.None;
                if (MarrowSDKPreferences.awSpawnerOverlayPreviews == true)
                {
                    spawnableShowPreviewsToggle.SetValueWithoutNotify(true);
                }
                else
                {
                    spawnableShowPreviewsToggle.SetValueWithoutNotify(false);
                }

                spawnableGridModeToggle.SetValueWithoutNotify(true);
            }
            else
            {
                if (MarrowSDKPreferences.awSpawnerOverlayPreviews == true)
                {
                    dragSpawnablePreviewContainer.style.display = DisplayStyle.None;
                    spawnablesListView.style.maxHeight = Screen.height * MarrowSDKPreferences.awSpawnerListSceneVertPercent / 100;
                    spawnablesListView.fixedItemHeight = MarrowSDKPreferences.awSpawnerImageSize + 16;
                    spawnableShowPreviewsToggle.SetValueWithoutNotify(true);
                }
                else
                {
                    dragSpawnablePreviewContainer.style.display = DisplayStyle.Flex;
                    spawnablesListView.style.maxHeight = Screen.height * MarrowSDKPreferences.awSpawnerListSceneVertPercent / 100;
                    spawnablesListView.fixedItemHeight = 16;
                    spawnableShowPreviewsToggle.SetValueWithoutNotify(false);
                }

                spawnableGridModeToggle.SetValueWithoutNotify(false);
            }

            Selection.selectionChanged += () =>
            {
                CheckOverlayPrefabInit(dragSpawnableLabel, dragSpawnableTexture, initializeOverlayButton, spawnablesListContainer);
                if (File.Exists(PREFAB_PATH) && spawnablePrefab == null)
                {
                    SetSpawnablePrefab();
                }

                if (dragSpawnableLabel != null && spawnablePrefab != null && Selection.instanceIDs.Length == 1)
                {
                    if (Selection.activeObject is SpawnableCrate)
                    {
                        SpawnableCrate crateObj = (SpawnableCrate)Selection.activeObject;
                        currentCrate = crateObj;
                        dragSpawnableLabel.tooltip = "Click here and drag into the Scene to create a Crate Spawner for [" + crateObj.name.ToString() + "]";
                        dragSpawnableTexture.tooltip = "Click here and drag into the Scene to create a Crate Spawner for [" + crateObj.name.ToString() + "]";
                        SetOverlayContents(dragSpawnableLabel, dragSpawnableTexture);
                    }
                }
            };
            awOverlaySettingsContainer.style.display = DisplayStyle.None;
            return rootVisualElement;
        }

        private void CreateSpawnableCratesList(List<Pallet> AWPalletsList, List<SpawnableCrate> spawnableCratesList, ListView spawnablesListView, string spawnablesSearchFieldString, bool spawnableShowBits)
        {
            spawnableCratesList.Clear();
            var queryEngine = ScannableQueryEngine.SetupQueryEngine();
            List<Scannable> allScannables = new List<Scannable>();
            allScannables = allScannables.OrderBy(s => s.Title).ToList();
            if (AWPalletsList != null)
            {
                AWPalletsList = AWPalletsList.OrderBy(x => x.Title).ToList();
                for (int p = 0; p < AWPalletsList.Count; p++)
                {
                    AWPalletsList[p].GetScannables(ref allScannables);
                    List<Scannable> filteredScannables = new List<Scannable>();
                    filteredScannables = ScannableQueryEngine.FilterScannableData(spawnablesSearchFieldString, queryEngine, allScannables).ToList();
                    foreach (var scannable in filteredScannables)
                    {
                        if (scannable == null)
                            continue;
                        if (spawnableShowBits == false && scannable.Title.Contains("Fragment -"))
                            continue;
                        if (spawnableShowBits == false && scannable is SpawnableCrate spawnCrate && spawnCrate != null && spawnCrate.Tags != null)
                        {
                            foreach (var sCrateTag in spawnCrate.Tags)
                            {
                                if (sCrateTag.ToLower().ToString() == "fragment")
                                    continue;
                            }
                        }

                        if (spawnableShowBits == false && scannable is SpawnableCrate spawnCrateBT && spawnCrateBT != null && spawnCrateBT.BoneTags != null)
                        {
                            if (spawnCrateBT.BoneTags.Tags != null)
                            {
                                foreach (var bTag in spawnCrateBT.BoneTags.Tags)
                                {
                                    if (bTag.DataCard.Title.ToLower().ToString() == "fragment")
                                        continue;
                                }
                            }
                        }

                        if (scannable.GetType() == typeof(SpawnableCrate) && !spawnableCratesList.Contains(scannable))
                        {
                            spawnableCratesList.Add(scannable as SpawnableCrate);
                        }
                    }
                }
            }

            if (File.Exists(PREFAB_PATH) && spawnablePrefab == null)
            {
                SetSpawnablePrefab();
            }

            Func<VisualElement> makeItem = () => new VisualElement();
            Action<VisualElement, int> bindItem = (spawnContainer, i) =>
            {
                if (spawnContainer != null && spawnableCratesList[i] != null)
                {
                    spawnContainer.style.flexDirection = FlexDirection.Column;
                    Label spawnLabel = spawnContainer.ElementAt(0) as Label;
                    Image spawnableImage = new Image();
                    if (spawnLabel != null)
                    {
                        spawnLabel.text = spawnableCratesList[i].Title;
                        spawnLabel.style.justifyContent = Justify.FlexStart;
                    }
                    else
                    {
                        Debug.Log("spawnLabel is NULL");
                    }

                    spawnContainer.style.height = 16;
                    if (MarrowSDKPreferences.awSpawnerOverlayPreviews == true)
                    {
                        spawnableImage.style.marginTop = 16;
                        spawnContainer.style.width = MarrowSDKPreferences.awSpawnerImageSize;
                        spawnContainer.style.height = MarrowSDKPreferences.awSpawnerImageSize + 16;
                        SetSpawnableListPreview(spawnableImage, spawnableCratesList[i]);
                        spawnableImage.StretchToParentWidth();
                        spawnableImage.style.width = MarrowSDKPreferences.awSpawnerImageSize;
                        spawnableImage.style.height = MarrowSDKPreferences.awSpawnerImageSize;
                        spawnableImage.tooltip = spawnableCratesList[i].Title;
                        spawnContainer.Add(spawnableImage);
                    }
                }
            };
            spawnablesListView.itemsSource = spawnableCratesList;
            spawnablesListView.makeItem = OnMakeSpawnListItem;
            spawnablesListView.bindItem = bindItem;
            spawnablesListView.style.flexShrink = 1;
        }

        private void CreateSpawnableCratesGrid(List<Pallet> AWPalletsList, List<SpawnableCrate> spawnableCratesList, ScrollView spawnablesGridScrollView, string spawnablesSearchFieldString, bool spawnableShowBits)
        {
            spawnableCratesList.Clear();
            spawnablesGridScrollView.Clear();
            var queryEngine = ScannableQueryEngine.SetupQueryEngine();
            List<Scannable> allScannables = new List<Scannable>();
            allScannables = allScannables.OrderBy(s => s.Title).ToList();
            if (AWPalletsList != null)
            {
                AWPalletsList = AWPalletsList.OrderBy(x => x.Title).ToList();
                for (int p = 0; p < AWPalletsList.Count; p++)
                {
                    AWPalletsList[p].GetScannables(ref allScannables);
                    List<Scannable> filteredScannables = new List<Scannable>();
                    filteredScannables = ScannableQueryEngine.FilterScannableData(spawnablesSearchFieldString, queryEngine, allScannables).ToList();
                    foreach (var scannable in filteredScannables)
                    {
                        if (scannable == null)
                            continue;
                        if (spawnableShowBits == false && scannable.Title.Contains("Fragment -"))
                            continue;
                        if (spawnableShowBits == false && scannable is SpawnableCrate spawnCrate && spawnCrate != null && spawnCrate.Tags != null)
                        {
                            foreach (var sCrateTag in spawnCrate.Tags)
                            {
                                if (sCrateTag.ToLower().ToString() == "fragment")
                                    continue;
                            }
                        }

                        if (spawnableShowBits == false && scannable is SpawnableCrate spawnCrateBT && spawnCrateBT != null && spawnCrateBT.BoneTags != null)
                        {
                            if (spawnCrateBT.BoneTags.Tags != null)
                            {
                                foreach (var bTag in spawnCrateBT.BoneTags.Tags)
                                {
                                    if (bTag.DataCard.Title.ToLower().ToString() == "fragment")
                                        continue;
                                }
                            }
                        }

                        if (scannable.GetType() == typeof(SpawnableCrate) && !spawnableCratesList.Contains(scannable))
                        {
                            spawnableCratesList.Add(scannable as SpawnableCrate);
                        }
                    }
                }
            }

            if (File.Exists(PREFAB_PATH) && spawnablePrefab == null)
            {
                SetSpawnablePrefab();
            }

            for (int i = 0; i < spawnableCratesList.Count; i++)
            {
                VisualElement spawnContainer = new VisualElement();
                spawnContainer.style.position = Position.Relative;
                spawnContainer.style.width = 100;
                spawnContainer.style.height = 16;
                spawnContainer.style.marginTop = 5;
                spawnContainer.style.marginBottom = 5;
                spawnContainer.style.marginLeft = 5;
                spawnContainer.style.marginRight = 5;
                spawnContainer.style.flexDirection = FlexDirection.Column;
                Label spawnLabel = new Label();
                spawnLabel.text = spawnableCratesList[i].Title;
                spawnLabel.style.whiteSpace = WhiteSpace.Normal;
                spawnLabel.style.flexDirection = FlexDirection.Column;
                if (MarrowSDKPreferences.awSpawnerOverlayPreviews == true)
                {
                    Image spawnableImage = new Image();
                    SetSpawnableListPreview(spawnableImage, spawnableCratesList[i]);
                    spawnContainer.style.height = MarrowSDKPreferences.awSpawnerImageSize;
                    spawnContainer.style.width = MarrowSDKPreferences.awSpawnerImageSize;
                    spawnableImage.style.height = MarrowSDKPreferences.awSpawnerImageSize;
                    spawnableImage.style.width = MarrowSDKPreferences.awSpawnerImageSize;
                    spawnableImage.tooltip = spawnableCratesList[i].Title;
                    spawnableImage.StretchToParentWidth();
                    spawnContainer.Add(spawnableImage);
                    if (MarrowSDKPreferences.awSpawnerImageSize > 99)
                    {
                        spawnContainer.style.height = MarrowSDKPreferences.awSpawnerImageSize + 16;
                        spawnContainer.Add(spawnLabel);
                    }
                }
                else
                {
                    spawnContainer.Add(spawnLabel);
                }

                spawnContainer.RegisterCallback<MouseDownEvent>(evt =>
                {
                    DragAndDrop.PrepareStartDrag();
                    if (spawnablePrefab != null)
                    {
                        DragAndDrop.StartDrag("Dragging");
                        DragAndDrop.objectReferences = new Object[]
                        {
                            spawnablePrefab
                        };
                        foreach (SpawnableCrate spawnableCrate in spawnableCratesList)
                        {
                            if (spawnableCrate != null && spawnableCrate.Title == spawnLabel.text)
                            {
                                currentCrate = spawnableCrate;
                            }
                        }
                    }
                });
                spawnContainer.RegisterCallback<DragUpdatedEvent>(evt =>
                {
                    DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                    if (spawnablePrefab != null && currentCrate != null && spawnablePrefab.GetComponent<CrateSpawner>() && spawnablePrefab.name != "Crate Spawner (" + currentCrate.name.ToString() + ")")
                    {
                        spawnablePrefab.name = "Crate Spawner (" + currentCrate.name.ToString() + ")";
                        spawnablePrefab.GetComponent<CrateSpawner>().spawnableCrateReference = new SpawnableCrateReference(currentCrate.Barcode);
                        spawnablePrefab.GetComponent<MeshFilter>().sharedMesh = currentCrate.PreviewMesh.EditorAsset;
                    }
                });
                spawnablesGridScrollView.Add(spawnContainer);
                spawnablesGridScrollView.style.flexShrink = 1;
            }
        }

        VisualElement OnMakeSpawnListItem()
        {
            var spawnListItem = new VisualElement();
            spawnListItem.Add(new Label());
            spawnListItem.RegisterCallback<MouseDownEvent>(evt =>
            {
                DragAndDrop.PrepareStartDrag();
                if (spawnablePrefab != null)
                {
                    DragAndDrop.StartDrag("Dragging");
                    DragAndDrop.objectReferences = new Object[]
                    {
                        spawnablePrefab
                    };
                }
            });
            spawnListItem.RegisterCallback<DragUpdatedEvent>(evt =>
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                if (spawnablePrefab != null && currentCrate != null && spawnablePrefab.GetComponent<CrateSpawner>() && spawnablePrefab.name != "Crate Spawner (" + currentCrate.name.ToString() + ")")
                {
                    spawnablePrefab.name = "Crate Spawner (" + currentCrate.name.ToString() + ")";
                    spawnablePrefab.GetComponent<CrateSpawner>().spawnableCrateReference = new SpawnableCrateReference(currentCrate.Barcode);
                    spawnablePrefab.GetComponent<MeshFilter>().sharedMesh = currentCrate.PreviewMesh.EditorAsset;
                }
            });
            return spawnListItem;
        }

        private void CheckOverlayPrefabInit(Label dragSpawnableLabel, Image dragSpawnableTexture, Button initializeOverlayButton, VisualElement spawnablesListContainer)
        {
            if (!File.Exists(PREFAB_PATH))
            {
                spawnablePrefab = null;
                spawnablesListContainer.style.display = DisplayStyle.None;
                dragSpawnableLabel.style.display = DisplayStyle.None;
                dragSpawnableTexture.style.display = DisplayStyle.None;
                initializeOverlayButton.style.display = DisplayStyle.Flex;
            }
            else
            {
                initializeOverlayButton.style.display = DisplayStyle.None;
                dragSpawnableLabel.style.display = DisplayStyle.Flex;
                dragSpawnableTexture.style.display = DisplayStyle.Flex;
                spawnablesListContainer.style.display = DisplayStyle.Flex;
            }
        }

        private void AWSettingsApplyButtonOnClick()
        {
            if (this.collapsed)
            {
                this.collapsed = false;
                this.collapsed = true;
            }
            else
            {
                this.collapsed = true;
                this.collapsed = false;
            }
        }

        private void InitializeOverlay()
        {
            GameObject createPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
            createPrefab.name = "Crate Spawner (Template)";
            var box = createPrefab.GetComponent<BoxCollider>();
            Object.DestroyImmediate(box);
            CreateSpawnablePrefab(createPrefab);
            if (this.collapsed)
            {
                this.collapsed = false;
                this.collapsed = true;
            }
            else
            {
                this.collapsed = true;
                this.collapsed = false;
            }
        }

        private void CreateSpawnablePrefab(GameObject createPrefab)
        {
            if (!Directory.Exists("Assets/Prefabs"))
            {
                AssetDatabase.CreateFolder("Assets", "Prefabs");
            }

            if (File.Exists(PREFAB_PATH))
            {
                Debug.Log("File already exists, skipping creation");
            }
            else
            {
                bool prefabCreated = false;
                createPrefab.AddComponent<CrateSpawner>();
                createPrefab.GetComponent<MeshRenderer>().material = MarrowSDK.VoidMaterial;
                PrefabUtility.SaveAsPrefabAsset(createPrefab, PREFAB_PATH, out prefabCreated);
                if (prefabCreated == true)
                {
                    Object.DestroyImmediate(createPrefab);
                }
            }
        }

        private void SetOverlayContents(Label dragSpawnableLabel, Image dragSpawnableTexture)
        {
            dragSpawnableLabel.text = "Drag to Scene\n" + currentCrate.name.ToString();
            SetSpawnableListPreview(dragSpawnableTexture, currentCrate);
            dragSpawnableTexture.StretchToParentSize();
        }

        private void SetSpawnableListPreview(Image spawnablePreviewTexture, Crate crate)
        {
            if (crate.MainAsset.EditorAsset != null)
            {
                if (AssetPreview.GetAssetPreview(crate.MainAsset.EditorAsset) != null)
                {
                    spawnablePreviewTexture.image = AssetPreview.GetAssetPreview(crate.MainAsset.EditorAsset);
                }
            }
        }

        private void SetSpawnablePrefab()
        {
            if (spawnablePrefab == null)
            {
                spawnablePrefab = AssetDatabase.LoadAssetAtPath<GameObject>(PREFAB_PATH);
                if (spawnablePrefab.GetComponent<CrateSpawner>() == null)
                {
                    spawnablePrefab.AddComponent<CrateSpawner>();
                }

                if (spawnablePrefab.GetComponent<MeshRenderer>() == null)
                {
                    spawnablePrefab.AddComponent<MeshRenderer>().material = MarrowSDK.VoidMaterial;
                }

                if (spawnablePrefab.GetComponent<MeshFilter>() == null)
                {
                    spawnablePrefab.AddComponent<MeshFilter>();
                }
            }
        }

        private static Texture2D LoadPNG(string filePath)
        {
            Texture2D tex = null;
            byte[] fileData;
            if (File.Exists(filePath))
            {
                fileData = File.ReadAllBytes(filePath);
                tex = new Texture2D(2, 2);
                tex.LoadImage(fileData);
            }

            return tex;
        }

        private static List<AWSpawnerOverlayToolbar> instances = new List<AWSpawnerOverlayToolbar>();
        public override void OnCreated()
        {
            instances.Add(this);
        }

        public override void OnWillBeDestroyed()
        {
            instances.Remove(this);
        }

        public static void DoWithInstances(Action<AWSpawnerOverlayToolbar> doWithInstance)
        {
            foreach (var instance in instances)
            {
                doWithInstance(instance);
            }
        }
    }
}
#endif
