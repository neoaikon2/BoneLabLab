using System;
 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using UnityEngine;
using UnityEditor;
using SLZ.Marrow.Warehouse;

namespace SLZ.MarrowEditor
{
    [CustomEditor(typeof(Pallet))]
    public class PalletEditor : ScannableEditor
    {
        SerializedProperty authorProperty;
        SerializedProperty versionProperty;
        SerializedProperty internalProperty;
        SerializedProperty cratesProperty;
        SerializedProperty dataCardsProperty;
        SerializedProperty tagsProperty;
        SerializedProperty changelogProperty;
        SerializedProperty palletDepsProperty;
        SerializedProperty marrowGameProperty;
        private bool createCrateFoldout;
        private bool packFoldout;
        public Texture2D crateIcon;
        public Texture2D levelIcon;
        public Texture2D avatarIcon;
        public Texture2D packPalletIcon;
        Pallet pallet;
        private static bool packing = false;
        private Nullable<bool> installSuccess = null;
        public override bool ShowUnlockableRedactedFields()
        {
            return false;
        }

        public override void OnEnable()
        {
            base.OnEnable();
            authorProperty = serializedObject.FindProperty("_author");
            versionProperty = serializedObject.FindProperty("_version");
            internalProperty = serializedObject.FindProperty("_internal");
            cratesProperty = serializedObject.FindProperty("_crates");
            dataCardsProperty = serializedObject.FindProperty("_dataCards");
            tagsProperty = serializedObject.FindProperty("_tags");
            changelogProperty = serializedObject.FindProperty("_changeLogs");
            palletDepsProperty = serializedObject.FindProperty("_palletDependencies");
            pallet = (Pallet)serializedObject.targetObject;
            createCrateFoldout = pallet.Crates.Count <= 0 && pallet.DataCards.Count <= 0;
            packFoldout = Directory.Exists(AddressablesManager.EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID));
            if (crateIcon == null)
                crateIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-add.png"));
            if (levelIcon == null)
                levelIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-level.png"));
            if (avatarIcon == null)
                avatarIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-avatar.png"));
            if (packPalletIcon == null)
                packPalletIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/packed-pallet.png"));
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            bool barcodeChanged = false;
            EditorGUI.BeginChangeCheck();
            LockedPropertyField(barcodeProperty);
            if (EditorGUI.EndChangeCheck())
            {
                barcodeChanged = true;
            }

            LockedPropertyField(titleProperty);
            LockedPropertyField(authorProperty);
            LockedPropertyField(descriptionProperty, false);
            LockedPropertyField(versionProperty, false);
            if (ShowUnlockableRedactedFields())
            {
                LockedPropertyField(unlockableProperty, false);
                LockedPropertyField(redactedProperty, false);
            }

            EditorGUI.BeginDisabledGroup(true);
            LockedPropertyField(internalProperty, null, true);
            EditorGUI.EndDisabledGroup();
            EditorGUILayout.Space();
            using (new GUILayout.VerticalScope())
            {
                using (new GUILayout.HorizontalScope())
                {
                    using (new GUILayout.VerticalScope())
                    {
                        GUILayout.FlexibleSpace();
                        if (GUILayout.Button(new GUIContent(" New Crate", crateIcon, "Create a new Crate"), GUILayout.ExpandWidth(false), GUILayout.Height(EditorGUIUtility.singleLineHeight * 2), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 6.5f)))
                        {
                            createCrateFoldout = !createCrateFoldout;
                        }

                        GUILayout.FlexibleSpace();
                    }

                    if (!createCrateFoldout)
                    {
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            EditorGUILayout.LabelField(new GUIContent("|"), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 1.5f));
                            GUILayout.FlexibleSpace();
                        }
                    }

                    if (createCrateFoldout)
                    {
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            EditorGUILayout.LabelField(new GUIContent("\u25ba"), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 1.5f));
                            GUILayout.FlexibleSpace();
                        }

                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            if (GUILayout.Button(new GUIContent(" Level Crate", levelIcon, "Create a new Level"), GUILayout.ExpandWidth(false)))
                            {
                                CreateLevelCrateEditorWindow.ShowCreateLevelCrateWindowEditor();
                            }

                            GUILayout.FlexibleSpace();
                        }

                        EditorGUILayout.Space(EditorGUIUtility.singleLineHeight / 4f);
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            if (GUILayout.Button(new GUIContent(" Avatar Crate", avatarIcon, "Create a new Avatar"), GUILayout.ExpandWidth(false)))
                            {
                                var wizard = CrateWizard.CreateWizard(pallet);
                                wizard.crateType = CrateWizard.CrateType.AVATAR_CRATE;
                            }

                            GUILayout.FlexibleSpace();
                        }
                    }

                    GUILayout.FlexibleSpace();
                }
            }

            EditorGUILayout.Space();
#if true
            using (new GUILayout.VerticalScope(GUILayout.Height(EditorGUIUtility.singleLineHeight * 2f)))
            {
                using (new GUILayout.HorizontalScope(GUILayout.Height(EditorGUIUtility.singleLineHeight * 1.8f)))
                {
                    using (new GUILayout.VerticalScope())
                    {
                        GUILayout.FlexibleSpace();
                        if (GUILayout.Button(new GUIContent(" Pack Pallet", packPalletIcon, "Build the pallet content"), GUILayout.ExpandWidth(false), GUILayout.Height(EditorGUIUtility.singleLineHeight * 2), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 6.5f)))
                        {
                            packFoldout = !packFoldout;
                            installSuccess = null;
                        }

                        GUILayout.FlexibleSpace();
                    }

                    if (!packFoldout)
                    {
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            EditorGUILayout.LabelField(new GUIContent("|"), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 1.5f));
                            GUILayout.FlexibleSpace();
                        }
                    }

                    if (packFoldout)
                    {
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            EditorGUILayout.LabelField(new GUIContent("\u25ba"), GUILayout.MaxWidth(EditorGUIUtility.singleLineHeight * 1.5f));
                            GUILayout.FlexibleSpace();
                        }

                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            if (GUILayout.Button(new GUIContent("Pack for PC", "Build the pallet for PC"), GUILayout.ExpandWidth(false)))
                            {
                                PackPalletWithValidation(pallet, BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64).Forget();
                                installSuccess = null;
                            }

                            if (GUILayout.Button(new GUIContent("Pack for Quest", "Build the pallet for Android"), GUILayout.ExpandWidth(false)))
                            {
                                PackPalletWithValidation(pallet, BuildTargetGroup.Android, BuildTarget.Android).Forget();
                                installSuccess = null;
                            }

                            GUILayout.FlexibleSpace();
                        }

                        EditorGUILayout.Space();
                        EditorGUILayout.Space();
                        using (new GUILayout.VerticalScope())
                        {
                            GUILayout.FlexibleSpace();
                            string palletFolder = AddressablesManager.EvaluateProfileValueBuildPathForPallet(pallet, AddressablesManager.ProfilePalletID);
                            if (Directory.Exists(palletFolder))
                            {
                                if (GUILayout.Button(new GUIContent("Open Pallet", "Open Built Pallet Folder"), GUILayout.ExpandWidth(false)))
                                {
                                    AddressablesManager.OpenBuiltModFolder(pallet);
                                }

                                if (EditorUserBuildSettings.activeBuildTarget == BuildTarget.StandaloneWindows64)
                                {
                                    foreach (var gamePath in ModBuilder.GamePathDictionary)
                                    {
                                        using (new GUILayout.HorizontalScope())
                                        {
                                            if (GUILayout.Button(new GUIContent($"Install Pallet", "Install Pallet locally to BONELAB on PC"), GUILayout.ExpandWidth(false)))
                                            {
                                                installSuccess = null;
                                                var success = ModBuilder.InstallMod(palletFolder, System.IO.Path.Combine(gamePath.Value, MarrowSDK.RUNTIME_MODS_DIRECTORY_NAME));
                                                installSuccess = success;
                                            }

                                            if (installSuccess.HasValue)
                                            {
                                                EditorGUILayout.LabelField(installSuccess.Value ? "Installed!" : "Failed to Install!", GUILayout.ExpandWidth(false));
                                            }
                                        }
                                    }
                                }
                            }

                            GUILayout.FlexibleSpace();
                        }
                    }

                    GUILayout.FlexibleSpace();
                }
            }

#endif
            EditorGUILayout.Space();
            EditorGUI.BeginChangeCheck();
            LockedPropertyField(cratesProperty, false);
            if (GUILayout.Button(new GUIContent("Sort Crates", "Refresh and sort Asset Warehouse crates"), GUILayout.ExpandWidth(false)))
            {
                pallet.SortCrates();
            }

            LockedPropertyField(dataCardsProperty, false);
            if (GUILayout.Button(new GUIContent("Add BoneTag", "Add a BoneTag to the Asset Warehouse"), GUILayout.ExpandWidth(false)))
            {
                DataCardCreatorEditor.ShowWindowBoneTag(pallet);
            }

            if (GUILayout.Button(new GUIContent("Add MonoDisc", "Add a MonoDisc to the Asset Warehouse"), GUILayout.ExpandWidth(false)))
            {
                DataCardCreatorEditor.ShowWindowMonoDisc(pallet);
            }

            if (EditorGUI.EndChangeCheck())
            {
            }

            LockedPropertyField(changelogProperty, false);
            LockedPropertyField(palletDepsProperty, false);
            if (GUILayout.Button(new GUIContent("Add Pallet Dependency", "Add dependency to another pallet"), GUILayout.ExpandWidth(false)))
            {
                AddPalletDependencyFromFile(pallet).Forget();
            }

#if true
            if (GUILayout.Button(new GUIContent("Add Bonelab Dependency", "Add dependency to the Bonelab pallets"), GUILayout.ExpandWidth(false)))
            {
                SDKProjectPreferences.LoadFromFile();
                if (SDKProjectPreferences.MarrowGameInstallPaths == null || SDKProjectPreferences.MarrowGameInstallPaths.Count <= 0)
                {
                    GameInstallDirectoryEditorWindow.ShowGameInstallDirWindowEditor(gamePath => AddGamePallets());
                }
                else
                {
                    AddGamePallets();
                }
            }

#endif
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            serializedObject.ApplyModifiedProperties();
            if (barcodeChanged)
            {
                foreach (var crate in pallet.Crates)
                {
                    crate.GenerateBarcode(true);
                    Undo.RecordObject(crate, "Update Crate Barcode");
                }
            }
        }

        private void AddGamePallets()
        {
            SDKProjectPreferences.LoadFromFile();
            if (SDKProjectPreferences.MarrowGameInstallPaths != null && SDKProjectPreferences.MarrowGameInstallPaths.Count > 0)
            {
                var gamePath = SDKProjectPreferences.MarrowGameInstallPaths[0];
                if (!string.IsNullOrEmpty(gamePath) && Directory.Exists(gamePath))
                {
                    bool added = false;
                    var gameBarcodes = GetPalletBarcodesFromMarrowGamePath(gamePath).ToList();
                    HashSet<string> palletDeps = pallet.PalletDependencies.Select(palletReference => palletReference.Barcode.ToString()).ToHashSet();
                    if (gameBarcodes.Count > 0)
                    {
                        foreach (var gameBarcode in gameBarcodes)
                        {
                            if (!string.IsNullOrEmpty(gameBarcode) && !palletDeps.Contains(gameBarcode))
                            {
                                pallet.PalletDependencies.Add(new PalletReference(gameBarcode));
                                palletDeps.Add(gameBarcode);
                                added = true;
                            }
                        }
                    }

                    if (added)
                    {
                        EditorUtility.SetDirty(pallet);
                        AssetDatabase.SaveAssetIfDirty(pallet);
                        AssetDatabase.Refresh();
                        AssetWarehouseWindow.ReloadWarehouse().Forget();
                    }
                }
            }
        }

        public static async UniTaskVoid AddPalletDependencyFromFile(Pallet pallet)
        {
            QueueEditorUpdateLoop.StartEditorUpdateLoop();
            Pallet palletDependency = await ImportPalletWindow.LoadPalletFromFolder();
            bool added = false;
            if (palletDependency != null)
            {
                bool foundPallet = false;
                foreach (var palletDep in pallet.PalletDependencies)
                {
                    if (palletDep.Barcode == palletDependency.Barcode)
                    {
                        foundPallet = true;
                        break;
                    }
                }

                if (!foundPallet)
                {
                    pallet.PalletDependencies.Add(new PalletReference(palletDependency.Barcode));
                    added = true;
                }
            }

            if (added)
            {
                EditorUtility.SetDirty(pallet);
                AssetDatabase.SaveAssetIfDirty(pallet);
                AssetDatabase.Refresh();
            }

            QueueEditorUpdateLoop.StopEditorUpdateLoop();
        }

        private static async UniTaskVoid PackPalletWithValidation(Pallet pallet, BuildTargetGroup buildTargetGroup, BuildTarget buildTarget, bool dedupe = false)
        {
            if (!packing)
            {
                packing = true;
                QueueEditorUpdateLoop.StartEditorUpdateLoop();
                SDKProjectPreferences.LoadFromFile();
                bool currentLoadMarrowGames = SDKProjectPreferences.LoadMarrowGames;
                if (currentLoadMarrowGames)
                {
                    SDKProjectPreferences.LoadMarrowGames = false;
                    SDKProjectPreferences.SaveToFile();
                    await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                    await AssetWarehouseWindow.ReloadWarehouse();
                    await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                }

                try
                {
                    if (!MarrowProjectValidation.ValidateProject())
                    {
                        MarrowProjectValidationWindow.ShowWindow();
                        packing = false;
                        return;
                    }

                    var currentTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
                    var currentTarget = EditorUserBuildSettings.activeBuildTarget;
                    if (EditorUserBuildSettings.activeBuildTarget != buildTarget || EditorUserBuildSettings.selectedBuildTargetGroup != buildTargetGroup)
                    {
                        EditorUserBuildSettings.SwitchActiveBuildTarget(buildTargetGroup, buildTarget);
                    }

                    PalletPackerEditor.PackPallet(pallet, out var result, dedupe, checkValidation: false);
                    if (result != null && string.IsNullOrEmpty(result.Error))
                    {
                    }
                    else
                    {
                        EditorUtility.DisplayDialog("Pallet Pack Error", $"ERROR\nPallet \"{pallet.Title}\" failed to Pack\nError: {result?.Error}", "Ok   ):");
                    }

                    EditorUserBuildSettings.SwitchActiveBuildTarget(currentTargetGroup, currentTarget);
                }
                catch (Exception e)
                {
                    EditorUtility.DisplayDialog("Pallet Pack Error", $"CRITICAL PACKING ERROR\nPallet \"{pallet.Title}\" failed to Pack\nException: {e}", "Ok   ):");
                }

                if (currentLoadMarrowGames)
                {
                    SDKProjectPreferences.LoadFromFile();
                    SDKProjectPreferences.LoadMarrowGames = true;
                    SDKProjectPreferences.SaveToFile();
                    await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                    await AssetWarehouseWindow.ReloadWarehouse();
                    await UniTask.Delay(TimeSpan.FromMilliseconds(100));
                }

                QueueEditorUpdateLoop.StopEditorUpdateLoop();
                packing = false;
            }
        }

        private string[] GetPalletBarcodesFromMarrowGamePath(string gamePath)
        {
            if (!string.IsNullOrEmpty(gamePath) && Directory.Exists(gamePath))
            {
                string contentDirectory = "";
                var dirs = Directory.GetDirectories(gamePath, "StandaloneWindows64", SearchOption.AllDirectories);
                foreach (var dir in dirs)
                {
                    var parent = Directory.GetParent(dir);
                    var parentParent = parent == null ? null : Directory.GetParent(parent.FullName);
                    if (parent != null && parentParent != null && parent.Name == "aa" && parentParent.Name == "StreamingAssets")
                    {
                        contentDirectory = Path.GetFullPath(dir);
                        break;
                    }
                }

                gamePath = contentDirectory;
                string marrowGamePath = Path.Combine(gamePath, "MarrowGame.json");
                if (File.Exists(marrowGamePath) && PalletPacker.TryUnpackMarrowGameJsonFromFile(marrowGamePath, out var marrowGame, out _))
                {
                    string[] gameBarcodes = new string[marrowGame.GamePallets.Count];
                    for (var i = 0; i < marrowGame.GamePallets.Count; i++)
                    {
                        gameBarcodes[i] = marrowGame.GamePallets[i].Barcode.ToString();
                    }

                    DestroyImmediate(marrowGame);
                    return gameBarcodes;
                }
            }

            return Array.Empty<string>();
        }
    }
}