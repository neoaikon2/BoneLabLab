#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    public class AWSpawnerEditorWin : EditorWindow
    {
        private const string PREFAB_PATH = "Assets/Prefabs/Crate Spawner (Template).prefab";
        private GameObject spawnablePrefab = null;
        private SpawnableCrate currentCrate = null;
        private ScrollView spawnablesGridScrollView;
        private Button initializeOverlayButton;
        [MenuItem("Stress Level Zero/Void Tools/AW Spawner Window", false, 5000)]
        public static void ShowAWSpawnerWindowEditor()
        {
            EditorWindow awSpawnWin = GetWindow<AWSpawnerEditorWin>();
            awSpawnWin.titleContent = new GUIContent("Asset Warehouse CrateSpawner");
            awSpawnWin.minSize = new Vector2(800, 800);
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("7a3d2236aa2e2f749846efe6fa9df7cb");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            initializeOverlayButton = new Button();
            initializeOverlayButton.text = "Initialize Overlay";
            initializeOverlayButton.clickable.clicked += InitializeOverlay;
            Toggle spawnableShowPreviewsToggle = rootVisualElement.Q<Toggle>("spawnableShowPreviewsToggle");
#if false
#else
            spawnableShowPreviewsToggle.value = false;
            MarrowSDKPreferences.awSpawnerWinPreviews = false;
#endif
            spawnablesGridScrollView = rootVisualElement.Q<ScrollView>("spawnablesGridScrollView");
            ToolbarSearchField spawnablesSearchField = rootVisualElement.Q<ToolbarSearchField>("spawnablesSearchField");
            Toggle spawnableShowBitsToggle = rootVisualElement.Q<Toggle>("spawnableShowBitsToggle");
            spawnablesGridScrollView.RegisterCallback<MouseEnterEvent>(evt =>
            {
                CheckOverlayPrefabInit(initializeOverlayButton, spawnablesGridScrollView);
            });
            CheckOverlayPrefabInit(initializeOverlayButton, spawnablesGridScrollView);
            AssetWarehouse.OnReady(() =>
            {
                List<Pallet> AWPalletsList = AssetWarehouse.Instance.GetPallets();
                List<SpawnableCrate> spawnableCratesList = new List<SpawnableCrate>();
                CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                spawnablesSearchField.RegisterValueChangedCallback(evt =>
                {
                    ScannableQueryEngine.scanQuerySearchErrorCount = 0;
                    CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                });
                spawnableShowPreviewsToggle.RegisterValueChangedCallback(evt =>
                {
                    if (spawnableShowPreviewsToggle.value == true)
                    {
                        MarrowSDKPreferences.awSpawnerWinPreviews = true;
                        CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                    }
                    else
                    {
                        MarrowSDKPreferences.awSpawnerWinPreviews = false;
                        CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                    }

                    Repaint();
                });
                spawnableShowBitsToggle.RegisterValueChangedCallback(evt =>
                {
                    if (spawnableShowBitsToggle.value == true)
                    {
                        CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                    }
                    else
                    {
                        CreateSpawnableCratesGrid(AWPalletsList, spawnableCratesList, spawnablesGridScrollView, spawnablesSearchField.value, spawnableShowBitsToggle.value);
                    }

                    Repaint();
                });
            });
            rootVisualElement.Add(initializeOverlayButton);
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
                Color origBackground = spawnContainer.style.backgroundColor.value;
                spawnContainer.style.position = Position.Relative;
                spawnContainer.style.width = 150;
                spawnContainer.style.height = 32;
                spawnContainer.style.marginTop = 5;
                spawnContainer.style.marginBottom = 5;
                spawnContainer.style.marginLeft = 5;
                spawnContainer.style.marginRight = 5;
                spawnContainer.style.flexDirection = FlexDirection.Column;
                Label spawnLabel = new Label();
                spawnLabel.text = spawnableCratesList[i].Title;
                spawnLabel.style.whiteSpace = WhiteSpace.Normal;
                spawnLabel.style.marginTop = 2;
                spawnLabel.style.marginLeft = 2;
                if (MarrowSDKPreferences.awSpawnerWinPreviews == true)
                {
                    spawnContainer.style.height = 132;
                    Image spawnableImage = new Image();
                    SetSpawnableListPreview(spawnableImage, spawnableCratesList[i]);
                    spawnableImage.StretchToParentSize();
                    spawnableImage.style.alignContent = Align.FlexEnd;
                    spawnableImage.style.marginTop = 16;
                    spawnContainer.Add(spawnableImage);
                }

                spawnContainer.Add(spawnLabel);
                spawnContainer.RegisterCallback<MouseDownEvent>(evt =>
                {
                    foreach (var spawnableContainer in spawnablesGridScrollView.Children())
                    {
                        spawnableContainer.style.backgroundColor = origBackground;
                    }

                    spawnContainer.style.backgroundColor = new Color(0.15f, 0.4f, 0.66f);
                    spawnContainer.style.borderBottomLeftRadius = 5;
                    spawnContainer.style.borderBottomRightRadius = 5;
                    spawnContainer.style.borderTopLeftRadius = 5;
                    spawnContainer.style.borderTopRightRadius = 5;
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
                    if (spawnablePrefab != null && spawnablePrefab.GetComponent<CrateSpawner>() && spawnablePrefab.name != "Crate Spawner (" + currentCrate.name.ToString() + ")")
                    {
                        spawnablePrefab.name = "Crate Spawner (" + currentCrate.name.ToString() + ")";
                        spawnablePrefab.GetComponent<CrateSpawner>().spawnableCrateReference = new SpawnableCrateReference(currentCrate.Barcode);
                        spawnablePrefab.GetComponent<MeshFilter>().sharedMesh = currentCrate.PreviewMesh.EditorAsset;
                    }
                });
                spawnablesGridScrollView.Add(spawnContainer);
            }
        }

        private void CheckOverlayPrefabInit(Button initializeOverlayButton, VisualElement spawnablesGridScrollView)
        {
            if (!File.Exists(PREFAB_PATH))
            {
                spawnablePrefab = null;
                spawnablesGridScrollView.style.display = DisplayStyle.None;
                initializeOverlayButton.style.display = DisplayStyle.Flex;
            }
            else
            {
                initializeOverlayButton.style.display = DisplayStyle.None;
                spawnablesGridScrollView.style.display = DisplayStyle.Flex;
                if (spawnablePrefab == null)
                {
                    SetSpawnablePrefab();
                }
            }
        }

        private void InitializeOverlay()
        {
            GameObject createPrefab = GameObject.CreatePrimitive(PrimitiveType.Cube);
            createPrefab.name = "Crate Spawner (Template)";
            var box = createPrefab.GetComponent<BoxCollider>();
            DestroyImmediate(box);
            CreateSpawnablePrefab(createPrefab);
            if (File.Exists(PREFAB_PATH))
            {
                spawnablesGridScrollView.style.display = DisplayStyle.Flex;
                initializeOverlayButton.style.display = DisplayStyle.None;
            }

            Repaint();
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
                    DestroyImmediate(createPrefab);
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
    }
}
#endif
