using SLZ.Marrow.Warehouse;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEditor.IMGUI.Controls;
using Cysharp.Threading.Tasks;
using System;
using Object = UnityEngine.Object;

namespace SLZ.MarrowEditor
{
    public class ScannableTreeViewItem : TreeViewItem
    {
        public string barcode = Barcode.EMPTY;
    }

    public class AssetWarehouseTreeView : TreeView
    {
        public List<Object> orderedObjs = new List<Object>();
        public string search = "";
        public bool list = false;
        public bool showAvatars = true;
        public bool showLevels = true;
        public bool showSpawnables = true;
        public bool showDataCards = true;
        public bool showUntagged = true;
        public bool showSpawnFragments = false;
        public Texture2D palletIcon;
        public Texture2D avatarIcon;
        public Texture2D levelIcon;
        public Texture2D spawnableIcon;
        public Texture2D dataCardIcon;
        public Dictionary<string, bool> uniqueTags = new Dictionary<string, bool>();
        public Dictionary<string, bool> uniqueBoneTags = new Dictionary<string, bool>();
        public Dictionary<string, bool> uniqueAuthors = new Dictionary<string, bool>();
        private static Dictionary<System.Type, Texture2D> iconCache = new Dictionary<Type, Texture2D>();
        public AssetWarehouseTreeView(TreeViewState treeViewState) : base(treeViewState)
        {
            Reload();
        }

        protected override TreeViewItem BuildRoot()
        {
            AssetPreview.SetPreviewTextureCacheSize(10000);
            var queryEngine = ScannableQueryEngine.SetupQueryEngine();
            if (palletIcon == null)
                palletIcon = GetIconForMonoScript(typeof(Pallet));
            if (avatarIcon == null)
                avatarIcon = GetIconForMonoScript(typeof(AvatarCrate));
            if (levelIcon == null)
                levelIcon = GetIconForMonoScript(typeof(LevelCrate));
            if (spawnableIcon == null)
                spawnableIcon = GetIconForMonoScript(typeof(SpawnableCrate));
            if (dataCardIcon == null)
                dataCardIcon = GetIconForMonoScript(typeof(DataCard));
            orderedObjs = new List<Object>();
            int id = 0;
            TreeViewItem root = new TreeViewItem
            {
                id = 0,
                depth = -1,
                displayName = "Root"
            };
            TreeViewItem workingPalletItem = null;
            TreeViewItem externalPalletItem = null;
            if (!list)
            {
                workingPalletItem = new TreeViewItem
                {
                    id = id++,
                    displayName = "Pallets"
                };
                orderedObjs.Add(null);
                root.AddChild(workingPalletItem);
                externalPalletItem = new TreeViewItem
                {
                    id = id++,
                    displayName = "External Pallets"
                };
                orderedObjs.Add(null);
                root.AddChild(externalPalletItem);
            }

            List<Pallet> pallets = AssetWarehouse.Instance.GetPallets();
            pallets = pallets.OrderBy(x => x.Title).ToList();
            List<string> distinctTags = new List<string>();
            List<string> distinctBoneTags = new List<string>();
            List<string> distinctAuthors = new List<string>();
            List<Scannable> allScannables = new List<Scannable>();
            distinctAuthors = GetDistinctAuthorsFromPallets(pallets);
            for (var a = 0; a < distinctAuthors.Count; a++)
            {
                if (!uniqueAuthors.ContainsKey(distinctAuthors[a].ToString().ToLower()))
                {
                    uniqueAuthors.Add(distinctAuthors[a].ToString().ToLower(), true);
                }
            }

            distinctBoneTags = GetDistinctBoneTagsFromPallets(pallets);
            for (var b = 0; b < distinctBoneTags.Count; b++)
            {
                if (!uniqueBoneTags.ContainsKey(distinctBoneTags[b].ToString().ToLower()))
                {
                    uniqueBoneTags.Add(distinctBoneTags[b].ToString().ToLower(), true);
                }
            }

            distinctTags = GetDistinctTagsFromCrates(pallets);
            for (var u = 0; u < distinctTags.Count; u++)
            {
                if (!uniqueTags.ContainsKey(distinctTags[u].ToString().ToLower()))
                {
                    uniqueTags.Add(distinctTags[u].ToString().ToLower(), true);
                }
            }

            allScannables = allScannables.OrderBy(s => s.Title).ToList();
            for (int p = 0; p < pallets.Count; p++)
            {
                pallets[p].GetScannables(ref allScannables);
                List<Scannable> filteredScannables = new List<Scannable>();
                filteredScannables = ScannableQueryEngine.FilterScannableData(search, queryEngine, allScannables).ToList();
                HashSet<Crate> scanAvatars = new HashSet<Crate>();
                HashSet<Crate> scanLevels = new HashSet<Crate>();
                HashSet<Crate> scanSpawnables = new HashSet<Crate>();
                Dictionary<System.Type, List<DataCard>> scanDataCards = new Dictionary<Type, List<DataCard>>();
                foreach (var scannable in filteredScannables)
                {
                    if (scannable == null)
                        continue;
                    if (uniqueAuthors != null && uniqueAuthors.Count > 0 && uniqueAuthors.Keys.Contains(pallets[p].Author.ToLower().ToString()) && uniqueAuthors[pallets[p].Author.ToLower().ToString()] == true)
                    {
                        Crate scanCrate = scannable as Crate;
                        if (scanCrate != null)
                        {
                            if ((scanCrate.BoneTags == null || scanCrate.BoneTags.Tags == null || scanCrate.BoneTags.Tags.Count == 0) && (scanCrate.Tags == null || scanCrate.Tags.Count == 0))
                            {
                                if (showUntagged)
                                {
                                    if (showAvatars && scannable.GetType() == typeof(AvatarCrate))
                                    {
                                        scanAvatars.Add(scannable as Crate);
                                    }

                                    if (showLevels && scannable.GetType() == typeof(LevelCrate))
                                    {
                                        scanLevels.Add(scannable as Crate);
                                    }

                                    if (showSpawnables && scannable.GetType() == typeof(SpawnableCrate))
                                    {
                                        if (scannable.Title.Contains("Fragment -") && !showSpawnFragments)
                                            continue;
                                        scanSpawnables.Add(scannable as Crate);
                                    }
                                }
                            }
                            else
                            {
                                for (int t = 0; t < scanCrate.BoneTags.Tags.Count; t++)
                                {
                                    if (scanCrate.BoneTags != null && scanCrate.BoneTags.Tags != null && scanCrate.BoneTags.Tags[t] != null && uniqueBoneTags != null && scanCrate.BoneTags.Tags[t].DataCard != null && !String.IsNullOrEmpty(scanCrate.BoneTags.Tags[t].DataCard.Title.ToLower().ToString()))
                                    {
                                        if (uniqueBoneTags.Keys.Contains(scanCrate.BoneTags.Tags[t].DataCard.Title.ToLower().ToString()) && uniqueBoneTags[scanCrate.BoneTags.Tags[t].DataCard.Title.ToLower().ToString()] == true)
                                        {
                                            if (showAvatars && scannable.GetType() == typeof(AvatarCrate) && !scanAvatars.Contains(scanCrate))
                                            {
                                                scanAvatars.Add(scannable as Crate);
                                            }

                                            if (showLevels && scannable.GetType() == typeof(LevelCrate) && !scanLevels.Contains(scanCrate))
                                            {
                                                scanLevels.Add(scannable as Crate);
                                            }

                                            if (showSpawnables && scannable.GetType() == typeof(SpawnableCrate) && !scanSpawnables.Contains(scanCrate))
                                            {
                                                if (!showSpawnFragments && (scannable.Title.Contains("Fragment -") || scanCrate.BoneTags.Tags[t].DataCard.Title.ToLower().ToString() == "fragment"))
                                                    continue;
                                                scanSpawnables.Add(scannable as Crate);
                                            }
                                        }
                                    }
                                }

                                for (int t = 0; t < scanCrate.Tags.Count; t++)
                                {
                                    if (uniqueTags.Keys.Contains(scanCrate.Tags[t].ToLower().ToString()) && uniqueTags[scanCrate.Tags[t].ToLower().ToString()] == true)
                                    {
                                        if (showAvatars && scannable.GetType() == typeof(AvatarCrate) && !scanAvatars.Contains(scanCrate))
                                        {
                                            scanAvatars.Add(scannable as Crate);
                                        }

                                        if (showLevels && scannable.GetType() == typeof(LevelCrate) && !scanLevels.Contains(scanCrate))
                                        {
                                            scanLevels.Add(scannable as Crate);
                                        }

                                        if (showSpawnables && scannable.GetType() == typeof(SpawnableCrate) && !scanSpawnables.Contains(scanCrate))
                                        {
                                            if (!showSpawnFragments && (scannable.Title.Contains("Fragment -") || scanCrate.Tags[t].ToLower().ToString() == "fragment"))
                                                continue;
                                            scanSpawnables.Add(scannable as Crate);
                                        }
                                    }
                                }
                            }
                        }

                        if (showDataCards && scannable is DataCard dataCard)
                        {
                            if (!scanDataCards.ContainsKey(dataCard.GetType()))
                            {
                                scanDataCards[dataCard.GetType()] = new List<DataCard>();
                            }

                            if (!scanDataCards[dataCard.GetType()].Contains(scannable))
                            {
                                scanDataCards[dataCard.GetType()].Add(dataCard);
                            }
                        }
                    }
                }

                int idCache = id;
                if (palletIcon == null)
                {
                    palletIcon = (Texture2D)AssetDatabase.GetCachedIcon(AssetDatabase.GetAssetPath(pallets[p]));
                }

                var palletTreeItemAdded = new ScannableTreeViewItem
                {
                    id = id,
                    displayName = pallets[p].Title,
                    barcode = pallets[p].Barcode
                };
                palletTreeItemAdded.icon = (Texture2D)palletIcon;
                orderedObjs.Add(pallets[p]);
                if (list)
                {
                    root.AddChild(palletTreeItemAdded);
                }
                else
                {
                    if (AssetWarehouse.Instance.WorkingPallets.ContainsKey(pallets[p].Barcode))
                    {
                        workingPalletItem.AddChild(palletTreeItemAdded);
                    }
                    else
                    {
                        externalPalletItem.AddChild(palletTreeItemAdded);
                    }
                }

                id++;
                if (scanAvatars.Count > 0 || scanLevels.Count > 0 || scanSpawnables.Count > 0)
                {
                    var crateTypeTreeItemAdded = new TreeViewItem
                    {
                        id = id,
                        displayName = nameof(Crate)
                    };
                    if (!list)
                    {
                        crateTypeTreeItemAdded.icon = GetIconForMonoScript(typeof(Crate));
                        orderedObjs.Add(null);
                        palletTreeItemAdded.AddChild(crateTypeTreeItemAdded);
                        id++;
                    }

                    var scanAvatarsList = scanAvatars.OrderBy(crate => crate.Title).ToList();
                    var scanLevelsList = scanLevels.OrderBy(crate => crate.Title).ToList();
                    var scanSpawnablesList = scanSpawnables.OrderBy(crate => crate.Title).ToList();
                    if (scanAvatars != null && scanAvatars.Count > 0)
                        SetupCrateType(scanAvatarsList, ref id, typeof(AvatarCrate), crateTypeTreeItemAdded, root);
                    if (scanLevels != null && scanLevels.Count > 0)
                        SetupCrateType(scanLevelsList, ref id, typeof(LevelCrate), crateTypeTreeItemAdded, root);
                    if (scanSpawnables != null && scanSpawnables.Count > 0)
                        SetupCrateType(scanSpawnablesList, ref id, typeof(SpawnableCrate), crateTypeTreeItemAdded, root);
                }

                if (showDataCards)
                {
                    bool dataCardsExist = false;
                    foreach (var dataCardList in scanDataCards)
                    {
                        if (dataCardList.Value.Count > 0)
                        {
                            dataCardsExist = true;
                            break;
                        }
                    }

                    var dataCardTypeTreeItemAdded = new TreeViewItem
                    {
                        id = id,
                        displayName = nameof(DataCard)
                    };
                    if (!list && dataCardsExist)
                    {
                        dataCardTypeTreeItemAdded.icon = GetIconForMonoScript(typeof(DataCard));
                        orderedObjs.Add(null);
                        palletTreeItemAdded.AddChild(dataCardTypeTreeItemAdded);
                        id++;
                    }

                    foreach (var dataCardType in scanDataCards.Keys.ToList())
                    {
                        scanDataCards[dataCardType] = scanDataCards[dataCardType].OrderBy(crate => crate.Title).ToList();
                    }

                    foreach (var typeDataCard in scanDataCards)
                    {
                        SetupDataCardType(typeDataCard.Value, ref id, typeDataCard.Key, dataCardTypeTreeItemAdded, root);
                    }
                }
            }

            if (root.children == null)
            {
                var emptyList = new TreeViewItem
                {
                    id = 1,
                    displayName = "No items found"
                };
                root.AddChild(emptyList);
            }

            SetupDepthsFromParentsAndChildren(root);
            return root;
        }

        public void ResetDefaultExpandState()
        {
            CollapseAll();
            SetExpanded(new List<int>() { 1 });
        }

        public void ExpandToWorkingContent()
        {
            ResetDefaultExpandState();
            SetExpanded(new[] { 0 });
        }

        public static Texture2D GetIconForMonoScript(System.Type monoScriptType)
        {
            Texture2D icon = null;
            if (!iconCache.TryGetValue(monoScriptType, out icon))
            {
                icon = EditorGUIUtility.ObjectContent(null, monoScriptType).image as Texture2D;
                var guids = AssetDatabase.FindAssets($"t:script {monoScriptType.Name}");
                foreach (var guid in guids)
                {
                    var path = AssetDatabase.GUIDToAssetPath(guid);
                    if (!string.IsNullOrEmpty(path) && AssetDatabase.GetMainAssetTypeAtPath(path) == typeof(MonoScript))
                    {
                        var scriptAsset = AssetDatabase.LoadAssetAtPath<MonoScript>(path);
                        if (scriptAsset != null && scriptAsset.GetClass() == monoScriptType)
                        {
                            icon = AssetDatabase.GetCachedIcon(path) as Texture2D;
                        }
                    }
                }

                if (icon != null)
                {
                    iconCache[monoScriptType] = icon;
                }
            }

            return icon;
        }

        private List<Scannable> GetAllScannables(List<Pallet> pallets)
        {
            List<Scannable> allScannables = new List<Scannable>();
            for (int p = 0; p < pallets.Count; p++)
            {
                pallets[p].GetScannables(ref allScannables);
            }

            return allScannables;
        }

        private List<string> GetDistinctAuthorsFromPallets(List<Pallet> pallets)
        {
            List<string> distinctAuthors = new List<string>();
            for (int p = 0; p < pallets.Count; p++)
            {
                if (pallets[p].Author != null)
                {
                    if (!distinctAuthors.Contains(pallets[p].Author))
                    {
                        distinctAuthors.Add(pallets[p].Author);
                    }
                }
            }

            return distinctAuthors;
        }

        private List<string> GetDistinctBoneTagsFromPallets(List<Pallet> pallets)
        {
            List<string> distinctBoneTags = new List<string>();
            for (int p = 0; p < pallets.Count; p++)
            {
                if (pallets[p].DataCards != null)
                {
                    foreach (var dataCard in pallets[p].DataCards)
                    {
                        if (dataCard.GetType() == typeof(BoneTag) && !distinctBoneTags.Contains(dataCard.Title))
                        {
                            distinctBoneTags.Add(dataCard.Title);
                        }
                    }
                }
            }

            return distinctBoneTags;
        }

        private List<string> GetDistinctTagsFromCrates(List<Pallet> pallets)
        {
            List<string> distinctTags = new List<string>();
            for (int p = 0; p < pallets.Count; p++)
            {
                for (int c = 0; c < pallets[p].Crates.Count; c++)
                {
                    if (pallets[p].Crates[c].Tags != null)
                    {
                        for (int t = 0; t < pallets[p].Crates[c].Tags.Count; t++)
                        {
                            if (!distinctTags.Contains(pallets[p].Crates[c].Tags[t]))
                            {
                                distinctTags.Add(pallets[p].Crates[c].Tags[t]);
                            }
                        }
                    }
                }
            }

            return distinctTags;
        }

        protected override void DoubleClickedItem(int id)
        {
            base.DoubleClickedItem(id);
            var selectedObject = orderedObjs[id];
            if (selectedObject != null && AssetDatabase.CanOpenAssetInEditor(selectedObject.GetInstanceID()))
            {
                AssetDatabase.OpenAsset(selectedObject);
            }
        }

        protected override void SelectionChanged(IList<int> selectedIds)
        {
            base.SelectionChanged(selectedIds);
            var selectedObjects = selectedIds.Select(id => orderedObjs[id]).ToArray();
            if (selectedObjects.Length > 0)
            {
                Selection.objects = selectedObjects;
            }

            if (!EditorApplication.isPlaying)
            {
                string selIDString = "";
                foreach (int selID in selectedIds)
                {
                    selIDString += selID.ToString() + ",";
                }

                selIDString = selIDString.Remove(selIDString.Length - 1);
                EditorPrefs.SetString("awSettingsSelectedIDs", selIDString);
            }
        }

        private void SetupCrateType(List<Crate> crates, ref int id, System.Type crateType, TreeViewItem crateTypeTreeItemAdded, TreeViewItem root)
        {
            bool subListSetup = false;
            Texture2D crateIcon = null;
            TreeViewItem crateTypeTreeSubItemAdded = new TreeViewItem
            {
                id = id,
                displayName = Crate.GetCrateName(crateType)
            };
            crateTypeTreeItemAdded.AddChild(crateTypeTreeSubItemAdded);
            for (int c = 0; c < crates.Count; c++)
            {
                if (crateIcon == null)
                {
                    crateIcon = AssetPreview.GetMiniThumbnail(crates[c]);
                }

                if (!subListSetup && !list)
                {
                    crateTypeTreeSubItemAdded.icon = crateIcon;
                    orderedObjs.Add(null);
                    id++;
                    subListSetup = true;
                }

                bool loadedInWarehouse = AssetWarehouse.Instance.HasCrate(crates[c].Barcode);
                var crateTreeItemAdded = new ScannableTreeViewItem
                {
                    id = id,
                    displayName = crates[c].GetNameNoExtension() + (loadedInWarehouse ? "" : "  -NOT in Warehouse!"),
                    barcode = crates[c].Barcode
                };
                crateTreeItemAdded.icon = crateIcon;
                SetCrateIcon(crateTreeItemAdded, crates[c]).Forget();
                orderedObjs.Add(crates[c]);
                if (list)
                {
                    root.AddChild(crateTreeItemAdded);
                }
                else
                {
                    crateTypeTreeSubItemAdded.AddChild(crateTreeItemAdded);
                }

                id++;
            }
        }

        private void SetupDataCardType(List<DataCard> dataCards, ref int id, System.Type dataCardType, TreeViewItem dataCardTypeTreeItem, TreeViewItem root)
        {
            bool subListSetup = false;
            Texture2D dataCardIcon = null;
            var dataCardTypeTreeSubItemAdded = new TreeViewItem
            {
                id = id,
                displayName = dataCardType.Name
            };
            dataCardTypeTreeItem.AddChild(dataCardTypeTreeSubItemAdded);
            for (int i = 0; i < dataCards.Count; i++)
            {
                if (dataCardIcon == null)
                {
                    dataCardIcon = AssetPreview.GetMiniThumbnail(dataCards[i]);
                }

                if (!subListSetup && !list)
                {
                    dataCardTypeTreeSubItemAdded.icon = dataCardIcon;
                    orderedObjs.Add(null);
                    id++;
                    subListSetup = true;
                }

                bool loadedInWarehouse = AssetWarehouse.Instance.HasDataCard(dataCards[i].Barcode);
                var dataCardTreeItemAdded = new ScannableTreeViewItem
                {
                    id = id,
                    displayName = dataCards[i].Title + (loadedInWarehouse ? "" : "  -NOT in Warehouse!"),
                    barcode = dataCards[i].Barcode
                };
                dataCardTreeItemAdded.icon = dataCardIcon;
                orderedObjs.Add(dataCards[i]);
                if (list)
                {
                    root.AddChild(dataCardTreeItemAdded);
                }
                else
                {
                    dataCardTypeTreeSubItemAdded.AddChild(dataCardTreeItemAdded);
                }

                id++;
            }
        }

        private async UniTaskVoid SetCrateIcon(TreeViewItem treeItem, Crate crate)
        {
            if (crate.MainAsset.EditorAsset != null)
            {
                await UniTask.WaitUntil(() => !AssetPreview.IsLoadingAssetPreview(crate.MainAsset.EditorAsset.GetInstanceID()));
                if (AssetPreview.GetAssetPreview(crate.MainAsset.EditorAsset) != null)
                    treeItem.icon = AssetPreview.GetAssetPreview(crate.MainAsset.EditorAsset);
            }
        }

        protected override bool CanStartDrag(CanStartDragArgs args)
        {
            return AssetWarehouse.ready;
        }

        protected override void SetupDragAndDrop(SetupDragAndDropArgs args)
        {
            base.SetupDragAndDrop(args);
            if (AssetWarehouse.ready)
            {
                var dragItems = FindRows(args.draggedItemIDs);
                List<string> crateBarcodes = new List<string>();
                List<string> palletBarcodes = new List<string>();
                List<Object> allScannables = new List<Object>();
                foreach (var dragItem in dragItems)
                {
                    if (dragItem is ScannableTreeViewItem scannableItem)
                    {
                        if (AssetWarehouse.Instance.TryGetScannable(scannableItem.barcode, out var scannable))
                        {
                            allScannables.Add(scannable);
                            if (scannable is Pallet pallet)
                            {
                                palletBarcodes.Add(pallet.Barcode);
                            }
                            else if (scannable is Crate crate)
                            {
                                crateBarcodes.Add(crate.Barcode);
                            }
                        }
                    }
                }

                DragAndDrop.PrepareStartDrag();
                if (crateBarcodes.Count > 0)
                    DragAndDrop.SetGenericData("_cratesBarcodes", crateBarcodes);
                if (palletBarcodes.Count > 0)
                    DragAndDrop.SetGenericData("_palletBarcodes", palletBarcodes);
                DragAndDrop.objectReferences = allScannables.ToArray();
                DragAndDrop.StartDrag("Draggin scannables");
                DragAndDrop.visualMode = DragAndDropVisualMode.Move;
            }
        }
    }
}