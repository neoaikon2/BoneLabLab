using System;
using UnityEngine;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using System.Linq;

namespace SLZ.MarrowEditor
{
    public class AssetWarehouseWindow : EditorWindow
    {
        [SerializeField]
        TreeViewState treeViewState;
        AssetWarehouseTreeView treeViewAW;
        private string searchString = "";
        private Rect warehouseRect;
        private Rect searchBarRect;
        private Vector2 warehouseScrollPos;
        private Rect tagsButtonRect;
        private Rect authsButtonRect;
        private int palletIndex = 0;
        private int buildIndex = 0;
        Texture2D palletIcon;
        Texture2D palletPlusIcon;
        Texture2D palletPlusIconBig;
        Texture2D refreshIcon;
        Texture2DArray refreshIconArrayAsset;
        private Texture2D[] refreshIconArray;
        private static bool reloadingWarehouse = false;
        void OnEnable()
        {
            autoRepaintOnSceneChange = true;
            if (treeViewState == null)
                treeViewState = new TreeViewState();
            if (palletIcon == null)
                palletIcon = AssetWarehouseTreeView.GetIconForMonoScript(typeof(Pallet));
            if (palletPlusIcon == null)
                palletPlusIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet-add.png"));
            if (palletPlusIconBig == null)
                palletPlusIconBig = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet-add-big.png"));
            refreshIcon = EditorGUIUtility.Load(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/hunter-reload.png")) as Texture2D;
            refreshIconArrayAsset = EditorGUIUtility.Load(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/hunter-reload-tiled.png")) as Texture2DArray;
            refreshIconArray = new Texture2D[8];
            for (int i = 0; i < refreshIconArray.Length; i++)
            {
                Texture2D refreshIcon = new Texture2D(refreshIconArrayAsset.width, refreshIconArrayAsset.height, refreshIconArrayAsset.format, refreshIconArrayAsset.mipmapCount, false);
                Graphics.CopyTexture(refreshIconArrayAsset, i, refreshIcon, 0);
                refreshIconArray[i] = refreshIcon;
            }

            AssetWarehouse.OnReady(() =>
            {
                if (treeViewAW == null)
                {
                    treeViewAW = new AssetWarehouseTreeView(treeViewState);
                    treeViewAW.ExpandToWorkingContent();
                    UpdateSearch();
                    this.Repaint();
                }

                WarehouseInit();
                AssetWarehouse.Instance.OnChanged += RefreshTree;
            });
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private void OnPlayModeStateChanged(PlayModeStateChange stateChange)
        {
            if (treeViewState != null)
            {
                if (stateChange == PlayModeStateChange.EnteredEditMode)
                {
                    if (!EditorApplication.isPlaying)
                    {
                        AssetWarehouse.OnReady(() =>
                        {
                            treeViewAW.list = EditorPrefs.GetBool("awSettingsListOrTree");
                            buildIndex = EditorPrefs.GetInt("awSettingsBuildIndex");
                            palletIndex = EditorPrefs.GetInt("awSettingsPalletIndex");
                            treeViewAW.showLevels = EditorPrefs.GetBool("awSettingsShowLevels");
                            treeViewAW.showAvatars = EditorPrefs.GetBool("awSettingsShowAvatars");
                            treeViewAW.showSpawnables = EditorPrefs.GetBool("awSettingsShowSpawnabes");
                            treeViewAW.showDataCards = EditorPrefs.GetBool("awSettingsShowDatacards");
                            string selIDString = EditorPrefs.GetString("awSettingsSelectedIDs");
                            string[] selIDStringList = selIDString.Split(",");
                            List<int> selIDIntList = new List<int>();
                            if (selIDStringList.Length > 0)
                            {
                                for (int i = 0; i < selIDStringList.Length; i++)
                                {
                                    int.TryParse(selIDStringList[i], out int intAdded);
                                    if (!string.IsNullOrEmpty(selIDString) && !string.IsNullOrEmpty(selIDStringList[i]) && !selIDIntList.Contains(intAdded))
                                    {
                                        selIDIntList.Add(intAdded);
                                    }
                                }

                                treeViewAW.SetSelection(selIDIntList);
                            }

                            UpdateSearch();
                            this.Repaint();
                        });
                    }
                }
            }
        }

        private void StoreAWState()
        {
            EditorPrefs.SetBool("awSettingsListOrTree", treeViewAW.list);
            EditorPrefs.SetInt("awSettingsBuildIndex", buildIndex);
            EditorPrefs.SetInt("awSettingsPalletIndex", palletIndex);
            EditorPrefs.SetBool("awSettingsShowLevels", treeViewAW.showLevels);
            EditorPrefs.SetBool("awSettingsShowAvatars", treeViewAW.showAvatars);
            EditorPrefs.SetBool("awSettingsShowSpawnabes", treeViewAW.showSpawnables);
            EditorPrefs.SetBool("awSettingsShowDatacards", treeViewAW.showDataCards);
            string selIDString = "";
            foreach (int selID in treeViewAW.state.selectedIDs)
            {
                selIDString += selID.ToString() + ",";
            }

            if (selIDString != "")
            {
                selIDString = selIDString.Remove(selIDString.Length - 1);
            }

            EditorPrefs.SetString("awSettingsSelectedIDs", selIDString);
        }

        private void OnDisable()
        {
            AssetWarehouse.Instance.OnChanged -= OnWarehouseChanged;
            AssetWarehouse.Instance.OnClearEditor -= OnWarehouseClear;
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
        }

        private void WarehouseInit()
        {
            if (treeViewAW == null)
            {
                treeViewAW = new AssetWarehouseTreeView(treeViewState);
                this.Repaint();
            }

            AssetWarehouse.Instance.OnChanged -= OnWarehouseChanged;
            AssetWarehouse.Instance.OnClearEditor -= OnWarehouseClear;
            AssetWarehouse.Instance.OnChanged += OnWarehouseChanged;
            AssetWarehouse.Instance.OnClearEditor += OnWarehouseClear;
            RefreshTree();
        }

        private void OnWarehouseChanged()
        {
            RefreshTree();
        }

        private void OnWarehouseClear()
        {
            AssetWarehouse.Instance.OnChanged -= RefreshTree;
            RefreshTree();
            AssetWarehouse.OnReady(WarehouseInit);
        }

        void OnGUIHeader(bool warehouseReady, string message = null, MessageType messageType = MessageType.Info)
        {
            using (new GUILayout.HorizontalScope())
            {
                if (treeViewAW != null)
                {
                }

                bool hasWorkingPallets = AssetWarehouse.Instance != null && AssetWarehouse.Instance.WorkingPallets.Count > 0;
                if (refreshIconArray.Length > 0)
                {
                    int refreshIconIndex = Time.frameCount / 4 % 8;
                    var refreshImageCycle = refreshIconArray[refreshIconIndex];
                    if (!reloadingWarehouse)
                    {
                        refreshImageCycle = refreshIcon;
                    }

                    if (GUILayout.Button(new GUIContent("", refreshImageCycle, "Reload the AssetWarehouse"), MarrowGUIStyles.BigIconButton))
                    {
                        if (Event.current.control)
                        {
                            EditorUtility.RequestScriptReload();
                        }
                        else
                        {
                            ReloadWarehouseInternal().Forget();
                        }
                    }
                }

                GUILayout.FlexibleSpace();
                if (!string.IsNullOrEmpty(message))
                    EditorGUILayout.HelpBox(message, messageType);
                GUILayout.FlexibleSpace();
                if (GUILayout.Button(new GUIContent("?", "Open the Asset Warehouse Documentation in the default web browser."), MarrowGUIStyles.DefaultButton))
                {
                    Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/PalletsAndCrates");
                }
            }

            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
        }

        void OnGUI()
        {
            int padding = 5;
            GUIStyle style = new GUIStyle();
            style.padding = new RectOffset(padding, padding, padding, padding);
            using (new GUILayout.VerticalScope(style))
            {
                if (AssetWarehouse.Instance == null || (!AssetWarehouse.ready && !AssetWarehouse.Instance.Initializing && !reloadingWarehouse))
                {
                    OnGUIHeader(false, "AssetWarehouse is NULL!  Try refreshing...", MessageType.Error);
                }
                else if (AssetWarehouse.Instance != null && !AssetWarehouse.ready)
                {
                    if (AssetWarehouse.Instance.Initializing || reloadingWarehouse)
                    {
                        OnGUIHeader(false, $"AssetWarehouse is loading... \n  {AssetWarehouse.Instance.PalletCount()} Pallets \n  {AssetWarehouse.Instance.CrateCount()} Crates \n  {AssetWarehouse.Instance.DataCardCount()} DataCards", MessageType.Info);
                    }
                    else
                    {
                        OnGUIHeader(false, "AssetWarehouse is NULL!  Try refreshing...", MessageType.Error);
                    }
                }
                else
                {
                    if (AssetWarehouse.Instance.WorkingPallets.Count == 0)
                    {
                        OnGUIHeader(true, "A Pallet is needed to Pack content inside of Crates and DataCards, please Create a Pallet", MessageType.Warning);
                    }
                    else
                    {
                        OnGUIHeader(false);
                    }

                    if (AssetWarehouse.Instance.WorkingPallets.Count == 0)
                    {
                        if (GUILayout.Button(new GUIContent("Create Pallet", palletPlusIconBig, "Create a Pallet"), GUILayout.ExpandWidth(false)))
                        {
                            CreatePalletEditorWindow.ShowCreatePalletWindowEditor();
                        }
                    }

                    if (AssetWarehouse.Instance.WorkingPallets.Count > 0)
                    {
                        using (new GUILayout.HorizontalScope())
                        {
                            if (treeViewAW != null)
                            {
                                using (new GUILayout.VerticalScope())
                                {
                                    using (new GUILayout.HorizontalScope())
                                    {
                                        if (GUILayout.Button(new GUIContent("", palletPlusIcon, "Create a Pallet")))
                                        {
                                            CreatePalletEditorWindow.ShowCreatePalletWindowEditor();
                                        }

                                        using (new EditorGUILayout.VerticalScope())
                                        {
                                            EditorGUI.BeginChangeCheck();
                                            searchString = GUILayout.TextField(searchString, GUI.skin.FindStyle("ToolbarSeachTextField"), GUILayout.MaxWidth(position.width - 60));
                                            if (EditorGUI.EndChangeCheck())
                                            {
                                                UpdateSearch();
                                                treeViewAW.ExpandAll();
                                            }
                                        }

                                        string searchTooltip = "";
                                        searchTooltip = "Search for a Crate or DataCard by its title or search for a full barcode";
                                        EditorGUI.LabelField(GUILayoutUtility.GetLastRect(), new GUIContent("", searchTooltip));
                                        if (GUILayout.Button(new GUIContent("Clear", "Clear the Search Bar"), MarrowGUIStyles.TrimButton))
                                        {
                                            searchString = "";
                                            UpdateSearch();
                                            treeViewAW.ResetDefaultExpandState();
                                        }

                                        if (!treeViewAW.list)
                                        {
                                            if (GUILayout.Button(new GUIContent("+", "Expand All AW Items"), MarrowGUIStyles.TrimButton))
                                            {
                                                treeViewAW.ExpandAll();
                                            }

                                            if (GUILayout.Button(new GUIContent("-", "Collapse All AW Items"), MarrowGUIStyles.TrimButton))
                                            {
                                                treeViewAW.ResetDefaultExpandState();
                                            }
                                        }
                                    }

                                    searchBarRect = GUILayoutUtility.GetLastRect();
                                    warehouseRect = new Rect(0, 0, position.width, treeViewAW.totalHeight);
                                    warehouseScrollPos = EditorGUILayout.BeginScrollView(warehouseScrollPos, false, false);
                                    treeViewAW.OnGUI(warehouseRect);
                                    GUILayout.Space(treeViewAW.totalHeight);
                                    EditorGUILayout.EndScrollView();
                                }
                            }
                        }
                    }
                }

                using (new GUILayout.VerticalScope())
                {
                    GUILayout.FlexibleSpace();
                    GUILayout.Label("Filters:", EditorStyles.boldLabel);
                    GUILayout.Space(5);
                    if (AssetWarehouse.Instance != null && AssetWarehouse.Instance.WorkingPallets.Count > 0)
                    {
                        EditorGUI.BeginChangeCheck();
                        using (new GUILayout.HorizontalScope())
                        {
                            if (GUILayout.Button(new GUIContent("All", "Enable all filters to view all items"), MarrowGUIStyles.DefaultButton))
                            {
                                if (treeViewAW != null)
                                {
                                    searchString = "";
                                    UpdateSearch();
                                    EnableAllFilters();
                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }
                            }

                            if (GUILayout.Button(new GUIContent("None", "Disable all filters and hide all items"), MarrowGUIStyles.DefaultButton))
                            {
                                if (treeViewAW != null)
                                {
                                    searchString = "";
                                    UpdateSearch();
                                    DisableAllFilters();
                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }
                            }

                            if (treeViewAW != null)
                            {
                                EditorGUI.BeginChangeCheck();
                                treeViewAW.showAvatars = GUILayout.Toggle(ShowAvatarsToggleContext(), new GUIContent(treeViewAW.avatarIcon, "Show Avatars"), MarrowGUIStyles.DefaultIconButton);
                                treeViewAW.showLevels = GUILayout.Toggle(ShowLevelsToggleContext(), new GUIContent(treeViewAW.levelIcon, "Show Levels"), MarrowGUIStyles.DefaultIconButton);
                                treeViewAW.showSpawnables = GUILayout.Toggle(ShowSpawnablesToggleContext(), new GUIContent(treeViewAW.spawnableIcon, "Show Spawnables"), MarrowGUIStyles.DefaultIconButton);
                                treeViewAW.showDataCards = GUILayout.Toggle(ShowDataCardsToggleContext(), new GUIContent(treeViewAW.dataCardIcon, "Show DataCards"), MarrowGUIStyles.DefaultIconButton);
                                GUILayout.Space(5);
                                GUIContent bitsTextOn = new GUIContent("Bits", "Show Destructible Fragments");
                                GUIContent bitsTextOff = new GUIContent("No Bits", "Hide Destructible Fragments");
                                treeViewAW.showSpawnFragments = GUILayout.Toggle(treeViewAW.showSpawnFragments, treeViewAW.showSpawnFragments ? bitsTextOn : bitsTextOff, MarrowGUIStyles.TrimButton);
                                if (EditorGUI.EndChangeCheck())
                                {
                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }
                            }
                        }

                        using (new GUILayout.HorizontalScope())
                        {
                            GUILayout.Label("Authors: ", GUILayout.Width(50));
                            if (treeViewAW != null)
                            {
                                if (GUILayout.Button(new GUIContent("All", "Select All Authors"), MarrowGUIStyles.DefaultButton))
                                {
                                    foreach (var kvp in treeViewAW.uniqueAuthors.ToArray())
                                    {
                                        treeViewAW.uniqueAuthors[kvp.Key] = true;
                                    }

                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }

                                if (GUILayout.Button(new GUIContent("None", "Deselect All Authors"), MarrowGUIStyles.DefaultButton))
                                {
                                    foreach (var kvp in treeViewAW.uniqueAuthors.ToArray())
                                    {
                                        treeViewAW.uniqueAuthors[kvp.Key] = false;
                                    }

                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }

                                if (GUILayout.Button(new GUIContent("Pick Authors", "Open the Authors Selector"), MarrowGUIStyles.DefaultButton, GUILayout.Width(94)))
                                {
                                    PopupWindow.Show(authsButtonRect, new AssetWarehouseAuthsPopupWindow(treeViewAW));
                                }

                                if (Event.current.type == EventType.Repaint)
                                    authsButtonRect = GUILayoutUtility.GetLastRect();
                            }
                        }

                        using (new GUILayout.HorizontalScope())
                        {
                            if (treeViewAW != null)
                            {
                                if (GUILayout.Button(new GUIContent("All", "Select All Tags"), MarrowGUIStyles.DefaultButton))
                                {
                                    foreach (var kvp in treeViewAW.uniqueBoneTags.ToArray())
                                    {
                                        treeViewAW.uniqueBoneTags[kvp.Key] = true;
                                    }

                                    foreach (var kvp in treeViewAW.uniqueTags.ToArray())
                                    {
                                        treeViewAW.uniqueTags[kvp.Key] = true;
                                    }

                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }

                                if (GUILayout.Button(new GUIContent("None", "Deselect All Tags"), MarrowGUIStyles.DefaultButton))
                                {
                                    foreach (var kvp in treeViewAW.uniqueBoneTags.ToArray())
                                    {
                                        treeViewAW.uniqueBoneTags[kvp.Key] = false;
                                    }

                                    foreach (var kvp in treeViewAW.uniqueTags.ToArray())
                                    {
                                        treeViewAW.uniqueTags[kvp.Key] = false;
                                    }

                                    if (!EditorApplication.isPlaying)
                                    {
                                        StoreAWState();
                                    }
                                }

                                if (GUILayout.Button(new GUIContent("Pick Tags", "Open the Tag Selector"), MarrowGUIStyles.DefaultButton, GUILayout.Width(94)))
                                {
                                    PopupWindow.Show(tagsButtonRect, new AssetWarehouseTagsPopupWindow(treeViewAW));
                                }

                                if (Event.current.type == EventType.Repaint)
                                    tagsButtonRect = GUILayoutUtility.GetLastRect();
                                GUILayout.Space(5);
                                treeViewAW.showUntagged = GUILayout.Toggle(treeViewAW.showUntagged, new GUIContent("Show Untagged", "Show Crates that have No Tags"), MarrowGUIStyles.DefaultButton);
                            }
                        }

                        if (EditorGUI.EndChangeCheck())
                        {
                            ApplyCrateFilters();
                        }
                    }

                    using (new GUILayout.HorizontalScope())
                    {
                        if (EditorPrefs.GetBool("UnlockEditingScannables", false))
                        {
                            if (GUILayout.Button("Init", MarrowGUIStyles.DefaultButton))
                            {
                                InitWarehouseInternal().Forget();
                            }

                            if (GUILayout.Button("Clear", MarrowGUIStyles.DefaultButton))
                            {
                                ClearWarehouseInternal().Forget();
                            }
                        }
                    }
                }
            }
        }

        private async UniTask InitWarehouseInternal()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            RefreshTree();
            await AssetWarehouse.Instance.InitAsync();
            RefreshTree();
            WarehouseInit();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        private async UniTask ClearWarehouseInternal()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            RefreshTree();
            AssetWarehouse.Instance.Clear();
            RefreshTree();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        private static async UniTask InitWarehouse()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            await AssetWarehouse.Instance.InitAsync();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        private static void ClearWarehouse()
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            AssetWarehouse.Instance.Clear();
            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        public static async UniTask ReloadWarehouse()
        {
            if (!reloadingWarehouse)
            {
                reloadingWarehouse = true;
                ClearWarehouse();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                await InitWarehouse();
                reloadingWarehouse = false;
            }
        }

        private async UniTaskVoid ReloadWarehouseInternal()
        {
            if (!reloadingWarehouse)
            {
                reloadingWarehouse = true;
                SpinForReload().Forget();
                await ClearWarehouseInternal();
                await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                await InitWarehouseInternal();
                reloadingWarehouse = false;
            }
        }

        private async UniTaskVoid SpinForReload()
        {
            while (reloadingWarehouse)
            {
                Repaint();
                await UniTask.DelayFrame(1);
            }
        }

        private bool ShowAvatarsToggleContext()
        {
            if (treeViewAW.showAvatars)
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Avatars toggle");
                    }
                }

                return true;
            }
            else
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Avatars toggle");
                    }
                }

                return false;
            }
        }

        private bool ShowLevelsToggleContext()
        {
            if (treeViewAW.showLevels)
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Levels toggle");
                    }
                }

                return true;
            }
            else
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Levels toggle");
                    }
                }

                return false;
            }
        }

        private bool ShowSpawnablesToggleContext()
        {
            if (treeViewAW.showSpawnables)
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Spawnables toggle");
                    }
                }

                return true;
            }
            else
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on Spawnables toggle");
                    }
                }

                return false;
            }
        }

        private bool ShowDataCardsToggleContext()
        {
            if (treeViewAW.showDataCards)
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on DataCards toggle");
                    }
                }

                return true;
            }
            else
            {
                if (Event.current.type == EventType.MouseDown && Event.current.button == 0)
                {
                    if (Event.current.modifiers == (EventModifiers.Control))
                    {
                        Debug.Log("CTRL key held on DataCards toggle");
                    }
                }

                return false;
            }
        }

        private void EnableAllFilters()
        {
            treeViewAW.showAvatars = true;
            treeViewAW.showLevels = true;
            treeViewAW.showSpawnables = true;
            treeViewAW.showDataCards = true;
            treeViewAW.showUntagged = true;
            foreach (var kvp in treeViewAW.uniqueBoneTags.ToArray())
            {
                treeViewAW.uniqueBoneTags[kvp.Key] = true;
            }

            foreach (var kvp in treeViewAW.uniqueTags.ToArray())
            {
                treeViewAW.uniqueTags[kvp.Key] = true;
            }
        }

        private void DisableAllFilters()
        {
            treeViewAW.showAvatars = false;
            treeViewAW.showLevels = false;
            treeViewAW.showSpawnables = false;
            treeViewAW.showDataCards = false;
            treeViewAW.showUntagged = true;
            foreach (var kvp in treeViewAW.uniqueBoneTags.ToArray())
            {
                treeViewAW.uniqueBoneTags[kvp.Key] = false;
            }

            foreach (var kvp in treeViewAW.uniqueTags.ToArray())
            {
                treeViewAW.uniqueTags[kvp.Key] = false;
            }
        }

        private void ApplyCrateFilters()
        {
            if (treeViewAW != null)
            {
                if (!treeViewAW.list)
                {
                    RefreshTree();
                    for (int t = 0; t < treeViewAW.orderedObjs.Count; t++)
                    {
                        if (treeViewAW.orderedObjs[t] != null && treeViewAW.showAvatars && treeViewAW.orderedObjs[t].GetType() == typeof(AvatarCrate))
                        {
                            treeViewAW.FrameItem(t);
                        }

                        if (treeViewAW.orderedObjs[t] != null && treeViewAW.showLevels && treeViewAW.orderedObjs[t].GetType() == typeof(LevelCrate))
                        {
                            treeViewAW.FrameItem(t);
                        }

                        if (treeViewAW.orderedObjs[t] != null && treeViewAW.showSpawnables && treeViewAW.orderedObjs[t].GetType() == typeof(SpawnableCrate))
                        {
                            treeViewAW.FrameItem(t);
                        }

                        if (treeViewAW.orderedObjs[t] != null && treeViewAW.showDataCards && treeViewAW.orderedObjs[t].GetType() == typeof(DataCard))
                        {
                            treeViewAW.FrameItem(t);
                        }
                    }
                }
                else
                {
                    RefreshTree();
                    treeViewAW.ExpandAll();
                }
            }
        }

        private void UpdateSearch()
        {
            treeViewAW.search = searchString;
            treeViewAW.searchString = null;
            ScannableQueryEngine.scanQuerySearchErrorCount = 0;
            RefreshTree();
            if (!string.IsNullOrEmpty(searchString))
                treeViewAW.ExpandAll();
        }

        private void RefreshTree()
        {
            if (treeViewAW != null)
            {
                treeViewAW.Reload();
            }
        }

        [MenuItem("Stress Level Zero/Void Tools/Asset Warehouse (" + MarrowSDK.SDK_VERSION + ")", false, 10)]
        public static void ShowWindow()
        {
            string awImagePath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/hunter16.png");
            Texture2D awImage = EditorGUIUtility.Load(awImagePath) as Texture2D;
            var window = GetWindow<AssetWarehouseWindow>();
            window.titleContent = new GUIContent(" Asset Warehouse");
            window.titleContent.image = awImage;
            window.Show();
        }
    }
}