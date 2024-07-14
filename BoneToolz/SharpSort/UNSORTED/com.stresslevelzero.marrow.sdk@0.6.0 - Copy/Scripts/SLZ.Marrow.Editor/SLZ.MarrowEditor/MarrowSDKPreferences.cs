 
using System.Collections.Generic;
 
using SLZ.Marrow;
 
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace SLZ.MarrowEditor
{
    public class MarrowSDKPreferences
    {
        private class MarrowSDKSettingsProvider : SettingsProvider
        {
            public MarrowSDKSettingsProvider(string path, SettingsScope scopes = SettingsScope.User) : base(path, scopes)
            {
                LoadPreferencesData();
            }

            public override void OnGUI(string searchContext)
            {
                PreferencesGUI();
            }

            public override void OnActivate(string searchContext, VisualElement rootElement)
            {
                LoadPreferencesData();
                base.OnActivate(searchContext, rootElement);
            }

            public override void OnDeactivate()
            {
                SaveGameInstallData();
            }
        }

        [SettingsProvider]
        static SettingsProvider NewPreferenceProvider()
        {
            return new MarrowSDKSettingsProvider("Preferences/Marrow SDK");
        }

        private static bool prefsLoaded = false;
        public static List<string> editorGameInstallDirectories = new List<string>();
        public static bool loadMarrowGames = false;
        public static bool startWarehouseLoadAssetDatabase = true;
        public static bool startWarehouseLoadModsFolder = true;
        public static bool verboseWarehouseLogging = false;
        public static bool unlockEditingScannables = false;
        public static bool gizmoShowZoneGizmos = true;
        public static bool gizmoShowZonePickableCube = true;
        public static bool gizmoShowZoneLinks = true;
        public static bool gizmoShowZoneNames = true;
        public static bool gizmoSceneChunkGizmos = true;
        public static bool gizmoZoneItemGizmos = true;
        public static bool gizmoZoneAmbience = true;
        public static bool gizmoZoneMusic = true;
        public static bool gizmoZoneActivators = true;
        public static bool gizmoZoneLinkLines = true;
        [Range(0.0f, 1.0f)]
        public static float gizmoZoneOpacity = 0.05f;
        public static bool gizmoZoneLinkItemRelations = true;
        [Range(0.0f, 1.0f)]
        public static float gizmoZoneLinkItemOpacity = 0.85f;
        public static string zonesParentHolderName = "ZONES";
        public static float gizmoShowZoneLabelsRange = 50f;
        public static bool awSpawnerOverlayPreviews = false;
        public static bool awSpawnerWinPreviews = false;
        public static bool awSpawnerGridMode = false;
        public static int awSpawnerImageSize = 100;
        public static int awSpawnerGridSceneHorizPercent = 40;
        public static int awSpawnerGridSceneVertPercent = 40;
        public static int awSpawnerListSceneVertPercent = 40;
        public static bool docsChecklistAvatarHumanoidPref = false;
        public static bool docsChecklistAvatarWeightPaintedPref = false;
        public static bool docsChecklistAvatarModelImportPref = false;
        public static bool docsChecklistAvatarEyesPref = false;
        public static bool docsChecklistAvatarRequiredBonesPref = false;
        public static bool docsChecklistAvatarMapBonesPref = false;
        public static bool docsChecklistAvatarApplyMaterialsPref = false;
        public static bool docsChecklistAvatarCreateGameObjectPref = false;
        public static bool docsChecklistAvatarCreatePrefabPref = false;
        public static bool docsChecklistAvatarEditPrefabDirectlyPref = false;
        public static bool docsChecklistAvatarScriptBodyMeshesPref = false;
        public static bool docsChecklistAvatarScriptWristBonesPref = false;
        public static bool docsChecklistAvatarScriptEyeOverridePref = false;
        public static bool docsChecklistAvatarEditBodyPref = false;
        public static bool docsChecklistAvatarEyeOffsetPref = false;
        public static bool docsChecklistAvatarCustomSoundsPref = false;
        public static bool docsChecklistAvatarAudioVariancePref = false;
        public static bool docsChecklistAvatarAddSoundClipsPref = false;
        public static bool docsChecklistAvatarOpenAssetWarehousePref = false;
        public static bool docsChecklistAvatarAddCratePref = false;
        public static bool docsChecklistAvatarPackPalletPref = false;
        public static bool docsChecklistAvatarInstallModPref = false;
        public static bool docsChecklistLevelLayoutEnvironmentPref = false;
        public static bool docsChecklistLevelLightsPref = false;
        public static bool docsChecklistLevelLightProbesPref = false;
        public static bool docsChecklistLevelReflectionProbesPref = false;
        public static bool docsChecklistLevelBakeLightsPref = false;
        public static bool docsChecklistLevelAddFogVolumePref = false;
        public static bool docsChecklistLevelBakeFogPref = false;
        public static bool docsChecklistLevelBakeNavMeshPref = false;
        public static bool docsChecklistLevelBakeOcclusionPref = false;
        public static bool docsChecklistLevelPlacePlayerMarkerPref = false;
        public static bool docsChecklistLevelAddZonesPref = false;
        public static bool docsChecklistLevelLinkZonesPref = false;
        public static bool docsChecklistLevelPlaceCrateSpawnersPref = false;
        public static bool docsChecklistLevelZonePermissionsPref = false;
        public static bool docsChecklistLevelReverbZonesPref = false;
        public static bool docsChecklistLevelZoneMusicAmbiencePref = false;
        public static bool docsChecklistLevelZoneEventsPref = false;
        public static bool docsChecklistLevelSceneChunksPref = false;
        public static bool docsChecklistLevelOpenAssetWarehousePref = false;
        public static bool docsChecklistLevelAddCratePref = false;
        public static bool docsChecklistLevelPackPalletPref = false;
        public static bool docsChecklistLevelInstallModPref = false;
        public static bool awSettingsListOrTree;
        public static int awSettingsBuildIndex;
        public static int awSettingsPalletIndex;
        public static bool awSettingsShowLevels;
        public static bool awSettingsShowAvatars;
        public static bool awSettingsShowSpawnables;
        public static bool awSettingsShowDatacards;
        public static string awSettingsSelectedIDs;
        static bool gameInstallChanged = false;
        static bool loadToggleChanged = false;
        public static void LoadPreferencesData()
        {
            SDKProjectPreferences.LoadFromFile();
            if (SDKProjectPreferences.MarrowGameInstallPaths.Count > 0)
            {
                editorGameInstallDirectories.Clear();
                foreach (var marrowGameInstallPath in SDKProjectPreferences.MarrowGameInstallPaths)
                {
                    editorGameInstallDirectories.Add(marrowGameInstallPath);
                }
            }
            else
            {
                editorGameInstallDirectories.Clear();
                editorGameInstallDirectories.Add(string.Empty);
            }

            loadMarrowGames = SDKProjectPreferences.LoadMarrowGames;
            gameInstallChanged = false;
            loadToggleChanged = false;
            startWarehouseLoadAssetDatabase = EditorPrefs.GetBool("StartWarehouseLoadAssetDatabase", true);
            startWarehouseLoadModsFolder = EditorPrefs.GetBool("StartWarehouseLoadModsFolder", true);
            verboseWarehouseLogging = EditorPrefs.GetBool("VerboseWarehouseLogging", false);
            unlockEditingScannables = EditorPrefs.GetBool("UnlockEditingScannables", false);
            gizmoShowZoneGizmos = EditorPrefs.GetBool("gizmoShowZoneGizmos", true);
            gizmoShowZonePickableCube = EditorPrefs.GetBool("gizmoShowZonePickableCube", true);
            gizmoShowZoneLinks = EditorPrefs.GetBool("gizmoShowZoneLinks", true);
            gizmoShowZoneNames = EditorPrefs.GetBool("gizmoShowZoneNames", true);
            gizmoSceneChunkGizmos = EditorPrefs.GetBool("gizmoSceneChunkGizmos", true);
            gizmoZoneItemGizmos = EditorPrefs.GetBool("gizmoZoneItemGizmos", true);
            gizmoZoneAmbience = EditorPrefs.GetBool("gizmoZoneAmbience", true);
            gizmoZoneMusic = EditorPrefs.GetBool("gizmoZoneMusic", true);
            gizmoZoneActivators = EditorPrefs.GetBool("gizmoZoneActivators", true);
            gizmoZoneLinkLines = EditorPrefs.GetBool("gizmoZoneLinkLines", true);
            gizmoZoneOpacity = EditorPrefs.GetFloat("gizmoZoneOpacity", 0.05f);
            gizmoZoneLinkItemRelations = EditorPrefs.GetBool("gizmoZoneLinkItemRelations", true);
            gizmoZoneLinkItemOpacity = EditorPrefs.GetFloat("gizmoZoneLinkItemOpacity", 0.05f);
            zonesParentHolderName = EditorPrefs.GetString("zonesParentHolderName", "ZONES");
            gizmoShowZoneLabelsRange = EditorPrefs.GetFloat("gizmoShowZoneLabelsRange", 50f);
            awSpawnerOverlayPreviews = EditorPrefs.GetBool("awSpawnerPreviews", false);
            awSpawnerWinPreviews = EditorPrefs.GetBool("awSpawnerWinPreviews", true);
            awSpawnerGridMode = EditorPrefs.GetBool("awSpawnerGridMode", false);
            awSpawnerImageSize = EditorPrefs.GetInt("awSpawnerImageSize", 100);
            awSpawnerGridSceneHorizPercent = EditorPrefs.GetInt("awSpawnerGridSceneHorizPercent", 40);
            awSpawnerGridSceneVertPercent = EditorPrefs.GetInt("awSpawnerGridSceneVertPercent", 40);
            awSpawnerListSceneVertPercent = EditorPrefs.GetInt("awSpawnerListSceneVertPercent", 80);
            docsChecklistAvatarHumanoidPref = EditorPrefs.GetBool("docsChecklistAvatarHumanoidPref", false);
            docsChecklistAvatarWeightPaintedPref = EditorPrefs.GetBool("docsChecklistAvatarWeightPaintedPref", false);
            docsChecklistAvatarModelImportPref = EditorPrefs.GetBool("docsChecklistAvatarModelImportPref", false);
            docsChecklistAvatarEyesPref = EditorPrefs.GetBool("docsChecklistAvatarEyesPref", false);
            docsChecklistAvatarRequiredBonesPref = EditorPrefs.GetBool("docsChecklistAvatarRequiredBonesPref", false);
            docsChecklistAvatarMapBonesPref = EditorPrefs.GetBool("docsChecklistAvatarMapBonesPref", false);
            docsChecklistAvatarApplyMaterialsPref = EditorPrefs.GetBool("docsChecklistAvatarApplyMaterialsPref", false);
            docsChecklistAvatarCreateGameObjectPref = EditorPrefs.GetBool("docsChecklistAvatarCreateGameObjectPref", false);
            docsChecklistAvatarCreatePrefabPref = EditorPrefs.GetBool("docsChecklistAvatarCreatePrefabPref", false);
            docsChecklistAvatarEditPrefabDirectlyPref = EditorPrefs.GetBool("docsChecklistAvatarEditPrefabDirectlyPref", false);
            docsChecklistAvatarScriptBodyMeshesPref = EditorPrefs.GetBool("docsChecklistAvatarScriptBodyMeshesPref", false);
            docsChecklistAvatarScriptWristBonesPref = EditorPrefs.GetBool("docsChecklistAvatarScriptWristBonesPref", false);
            docsChecklistAvatarScriptEyeOverridePref = EditorPrefs.GetBool("docsChecklistAvatarScriptEyeOverridePref", false);
            docsChecklistAvatarEditBodyPref = EditorPrefs.GetBool("docsChecklistAvatarEditBodyPref", false);
            docsChecklistAvatarEyeOffsetPref = EditorPrefs.GetBool("docsChecklistAvatarEyeOffsetPref", false);
            docsChecklistAvatarCustomSoundsPref = EditorPrefs.GetBool("docsChecklistAvatarCustomSoundsPref", false);
            docsChecklistAvatarAudioVariancePref = EditorPrefs.GetBool("docsChecklistAvatarAudioVariancePref", false);
            docsChecklistAvatarAddSoundClipsPref = EditorPrefs.GetBool("docsChecklistAvatarAddSoundClipsPref", false);
            docsChecklistAvatarOpenAssetWarehousePref = EditorPrefs.GetBool("docsChecklistAvatarOpenAssetWarehousePref", false);
            docsChecklistAvatarAddCratePref = EditorPrefs.GetBool("docsChecklistAvatarAddCratePref", false);
            docsChecklistAvatarPackPalletPref = EditorPrefs.GetBool("docsChecklistAvatarPackPalletPref", false);
            docsChecklistAvatarInstallModPref = EditorPrefs.GetBool("docsChecklistAvatarInstallModPref", false);
            docsChecklistLevelLayoutEnvironmentPref = EditorPrefs.GetBool("docsChecklistLevelLayoutEnvironmentPref", false);
            docsChecklistLevelLightsPref = EditorPrefs.GetBool("docsChecklistLevelLightsPref", false);
            docsChecklistLevelLightProbesPref = EditorPrefs.GetBool("docsChecklistLevelLightProbesPref", false);
            docsChecklistLevelReflectionProbesPref = EditorPrefs.GetBool("docsChecklistLevelReflectionProbesPref", false);
            docsChecklistLevelBakeLightsPref = EditorPrefs.GetBool("docsChecklistLevelBakeLightsPref", false);
            docsChecklistLevelAddFogVolumePref = EditorPrefs.GetBool("docsChecklistLevelAddFogVolumePref", false);
            docsChecklistLevelBakeFogPref = EditorPrefs.GetBool("docsChecklistLevelBakeFogPref", false);
            docsChecklistLevelBakeNavMeshPref = EditorPrefs.GetBool("docsChecklistLevelBakeNavMeshPref", false);
            docsChecklistLevelBakeOcclusionPref = EditorPrefs.GetBool("docsChecklistLevelBakeOcclusionPref", false);
            docsChecklistLevelPlacePlayerMarkerPref = EditorPrefs.GetBool("docsChecklistLevelPlacePlayerMarkerPref", false);
            docsChecklistLevelAddZonesPref = EditorPrefs.GetBool("docsChecklistLevelAddZonesPref", false);
            docsChecklistLevelLinkZonesPref = EditorPrefs.GetBool("docsChecklistLevelLinkZonesPref", false);
            docsChecklistLevelPlaceCrateSpawnersPref = EditorPrefs.GetBool("docsChecklistLevelPlaceCrateSpawnersPref", false);
            docsChecklistLevelZonePermissionsPref = EditorPrefs.GetBool("docsChecklistLevelZonePermissionsPref", false);
            docsChecklistLevelReverbZonesPref = EditorPrefs.GetBool("docsChecklistLevelReverbZonesPref", false);
            docsChecklistLevelZoneMusicAmbiencePref = EditorPrefs.GetBool("docsChecklistLevelZoneMusicAmbiencePref", false);
            docsChecklistLevelZoneEventsPref = EditorPrefs.GetBool("docsChecklistLevelZoneEventsPref", false);
            docsChecklistLevelSceneChunksPref = EditorPrefs.GetBool("docsChecklistLevelSceneChunksPref", false);
            docsChecklistLevelOpenAssetWarehousePref = EditorPrefs.GetBool("docsChecklistLevelOpenAssetWarehousePref", false);
            docsChecklistLevelAddCratePref = EditorPrefs.GetBool("docsChecklistLevelAddCratePref", false);
            docsChecklistLevelPackPalletPref = EditorPrefs.GetBool("docsChecklistLevelPackPalletPref", false);
            docsChecklistLevelInstallModPref = EditorPrefs.GetBool("docsChecklistLevelInstallModPref", false);
            awSettingsListOrTree = EditorPrefs.GetBool("awSettingsListOrTree", false);
            awSettingsBuildIndex = EditorPrefs.GetInt("awSettingsBuildIndex", 0);
            awSettingsPalletIndex = EditorPrefs.GetInt("awSettingsPalletIndex", 0);
            awSettingsShowLevels = EditorPrefs.GetBool("awSettingsShowLevels", true);
            awSettingsShowAvatars = EditorPrefs.GetBool("awSettingsShowAvatars", true);
            awSettingsShowSpawnables = EditorPrefs.GetBool("awSettingsShowSpawnables", true);
            awSettingsShowDatacards = EditorPrefs.GetBool("awSettingsShowDatacards", true);
            awSettingsSelectedIDs = EditorPrefs.GetString("awSettingsSelectedIDs", "");
        }

        public static void SaveGameInstallData()
        {
            if (gameInstallChanged || loadToggleChanged)
            {
                bool changed = false;
                SDKProjectPreferences.LoadFromFile();
                for (var i = editorGameInstallDirectories.Count - 1; i >= 0; i--)
                {
                    var editorGameInstallDirectory = editorGameInstallDirectories[i];
                    if (string.IsNullOrEmpty(editorGameInstallDirectory))
                    {
                        editorGameInstallDirectories.RemoveAt(i);
                    }
                }

                if (editorGameInstallDirectories.Count > 0)
                {
                    SDKProjectPreferences.MarrowGameInstallPaths.Clear();
                    foreach (var editorGameInstallDirectory in editorGameInstallDirectories)
                    {
                        SDKProjectPreferences.MarrowGameInstallPaths.Add(editorGameInstallDirectory);
                    }

                    changed = true;
                }
                else
                {
                    editorGameInstallDirectories.Add(string.Empty);
                    SDKProjectPreferences.MarrowGameInstallPaths.Clear();
                    changed = true;
                }

                if (loadToggleChanged)
                {
                    SDKProjectPreferences.LoadMarrowGames = loadMarrowGames;
                    changed = true;
                }

                if (changed)
                {
                    SDKProjectPreferences.SaveToFile();
                }
            }
        }

        public static void PreferencesGUI()
        {
            EditorGUILayout.BeginVertical();
            EditorGUIUtility.labelWidth = 300;
            EditorGUIUtility.fieldWidth = 60;
            gameInstallChanged = false;
            EditorGUILayout.LabelField("Asset Warehouse", EditorStyles.boldLabel);
            loadToggleChanged = false;
            bool drewLoadCheckbox = false;
            for (var i = 0; i < editorGameInstallDirectories.Count; i++)
            {
                using (new EditorGUILayout.HorizontalScope())
                {
                    var gameName = MarrowSDK.GAME_NAMES[0];
                    var buttonLabel = new GUIContent(EditorGUIUtility.IconContent("d_folderopened icon"));
                    buttonLabel.tooltip = $"Locate {gameName} Install Directory";
                    if (GUILayout.Button(buttonLabel, MarrowGUIStyles.SkinnyIconButton))
                    {
                        var gameInstallIndex = i;
                        GameInstallDirectoryEditorWindow.ShowGameInstallDirWindowEditor(gameInstall =>
                        {
                            if (!string.IsNullOrEmpty(gameInstall))
                            {
                                editorGameInstallDirectories[gameInstallIndex] = gameInstall;
                                gameInstallChanged = true;
                            }
                        });
                    }

                    using (var gameInstallCheck = new EditorGUI.ChangeCheckScope())
                    {
                        editorGameInstallDirectories[i] = EditorGUILayout.DelayedTextField(new GUIContent($"{gameName} Install Location", "Example: \"C:/Program Files (x86)/Steam/steamapps/common/BONELAB/BONELAB_Steam_Windows64_Data\""), editorGameInstallDirectories[i]);
                        if (gameInstallCheck.changed)
                        {
                            gameInstallChanged = true;
                        }
                    }

                    if (!drewLoadCheckbox)
                    {
                        using (var loadToggleCheck = new EditorGUI.ChangeCheckScope())
                        {
                            drewLoadCheckbox = true;
                            loadMarrowGames = EditorGUILayout.Toggle(new GUIContent("", "Loading Game Pallets Enabled"), loadMarrowGames, GUILayout.Width(EditorGUIUtility.singleLineHeight));
                            loadToggleChanged = loadToggleCheck.changed;
                        }
                    }
                }
            }

            SaveGameInstallData();
            verboseWarehouseLogging = EditorGUILayout.Toggle("Verbose AssetWarehouse Logging", verboseWarehouseLogging);
            unlockEditingScannables = EditorGUILayout.Toggle("Developer Mode", unlockEditingScannables);
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Zones", EditorStyles.boldLabel);
            gizmoShowZoneGizmos = EditorGUILayout.Toggle("Show Zone Gizmos", gizmoShowZoneGizmos);
            gizmoShowZoneLabelsRange = EditorGUILayout.Slider("Zone Gizmo Label Range", gizmoShowZoneLabelsRange, 0f, 1000f);
            gizmoZoneOpacity = EditorGUILayout.Slider("Zone Opacity", gizmoZoneOpacity, 0f, 1f);
            gizmoShowZonePickableCube = EditorGUILayout.Toggle("Show Zone Pickable Cube", gizmoShowZonePickableCube);
            gizmoShowZoneLinks = EditorGUILayout.Toggle("Show Zone Links", gizmoShowZoneLinks);
            gizmoZoneLinkLines = EditorGUILayout.Toggle("Show ZoneLink Lines", gizmoZoneLinkLines);
            gizmoShowZoneNames = EditorGUILayout.Toggle("Show Zone Names", gizmoShowZoneNames);
            gizmoZoneActivators = EditorGUILayout.Toggle("Show Zone Activators", gizmoZoneActivators);
            gizmoSceneChunkGizmos = EditorGUILayout.Toggle("Show Scene Chunk Gizmos", gizmoSceneChunkGizmos);
            gizmoZoneItemGizmos = EditorGUILayout.Toggle("Show Zone Item Gizmos", gizmoZoneItemGizmos);
            gizmoZoneLinkItemOpacity = EditorGUILayout.Slider("ZoneLink Item Opacity", gizmoZoneLinkItemOpacity, 0f, 1f);
            EditorGUI.indentLevel++;
            gizmoZoneAmbience = EditorGUILayout.Toggle("Show Zone Ambience Gizmos", gizmoZoneAmbience);
            gizmoZoneMusic = EditorGUILayout.Toggle("Show Zone Music Gizmos", gizmoZoneMusic);
            EditorGUI.indentLevel--;
            gizmoZoneLinkItemRelations = EditorGUILayout.Toggle("Show ZoneLink Item Relations", gizmoZoneLinkItemRelations);
            zonesParentHolderName = EditorGUILayout.TextField("Zones Parent Holder Name", zonesParentHolderName);
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Hide and Reopen the Zone Creation and Linking Overlay", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("to refresh values changed here.", EditorStyles.boldLabel);
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("AW Spawner Overlay", EditorStyles.boldLabel);
            awSpawnerOverlayPreviews = EditorGUILayout.Toggle("Show Preview Images for AWSpawner Overlay", awSpawnerOverlayPreviews);
            awSpawnerWinPreviews = EditorGUILayout.Toggle("Show Preview Images for AWSpawner Editor Window", awSpawnerWinPreviews);
            awSpawnerGridMode = EditorGUILayout.Toggle("Toggle Grid Mode layout of Spawnables", awSpawnerGridMode);
            awSpawnerImageSize = EditorGUILayout.IntSlider("Size (px) of preview images", awSpawnerImageSize, 20, 150);
            awSpawnerGridSceneHorizPercent = EditorGUILayout.IntSlider("Horizontal % of SceneView in Grid Mode", awSpawnerGridSceneHorizPercent, 10, 90);
            awSpawnerGridSceneVertPercent = EditorGUILayout.IntSlider("Vertical % of SceneView in Grid Mode", awSpawnerGridSceneVertPercent, 10, 90);
            awSpawnerListSceneVertPercent = EditorGUILayout.IntSlider("Vertical % of SceneView in List Mode", awSpawnerListSceneVertPercent, 10, 90);
            EditorGUILayout.EndVertical();
            if (GUI.changed)
            {
                EditorPrefs.SetBool("StartWarehouseLoadAssetDatabase", startWarehouseLoadAssetDatabase);
                EditorPrefs.SetBool("StartWarehouseLoadModsFolder", startWarehouseLoadModsFolder);
                EditorPrefs.SetBool("VerboseWarehouseLogging", verboseWarehouseLogging);
                EditorPrefs.SetBool("UnlockEditingScannables", unlockEditingScannables);
                EditorPrefs.SetBool("gizmoShowZoneGizmos", gizmoShowZoneGizmos);
                EditorPrefs.SetBool("gizmoShowZonePickableCube", gizmoShowZonePickableCube);
                EditorPrefs.SetBool("gizmoShowZoneLinks", gizmoShowZoneLinks);
                EditorPrefs.SetBool("gizmoShowZoneNames", gizmoShowZoneNames);
                EditorPrefs.SetBool("gizmoSceneChunkGizmos", gizmoSceneChunkGizmos);
                EditorPrefs.SetBool("gizmoZoneItemGizmos", gizmoZoneItemGizmos);
                EditorPrefs.SetBool("gizmoZoneAmbience", gizmoZoneAmbience);
                EditorPrefs.SetBool("gizmoZoneMusic", gizmoZoneMusic);
                EditorPrefs.SetBool("gizmoZoneActivators", gizmoZoneActivators);
                EditorPrefs.SetBool("gizmoZoneLinkLines", gizmoZoneLinkLines);
                EditorPrefs.SetFloat("gizmoZoneOpacity", gizmoZoneOpacity);
                EditorPrefs.SetBool("gizmoZoneLinkItemRelations", gizmoZoneLinkItemRelations);
                EditorPrefs.SetFloat("gizmoZoneLinkItemOpacity", gizmoZoneLinkItemOpacity);
                EditorPrefs.SetString("zonesParentHolderName", zonesParentHolderName);
                EditorPrefs.SetFloat("gizmoShowZoneLabelsRange", gizmoShowZoneLabelsRange);
                EditorPrefs.SetBool("awSpawnerPreviews", awSpawnerOverlayPreviews);
                EditorPrefs.SetBool("awSpawnerWinPreviews", awSpawnerWinPreviews);
                EditorPrefs.SetBool("awSpawnerGridMode", awSpawnerGridMode);
                EditorPrefs.SetInt("awSpawnerImageSize", awSpawnerImageSize);
                EditorPrefs.SetInt("awSpawnerGridSceneHorizPercent", awSpawnerGridSceneHorizPercent);
                EditorPrefs.SetInt("awSpawnerGridSceneVertPercent", awSpawnerGridSceneVertPercent);
                EditorPrefs.SetInt("awSpawnerListSceneVertPercent", awSpawnerListSceneVertPercent);
                EditorPrefs.SetBool("docsChecklistAvatarHumanoidPref", docsChecklistAvatarHumanoidPref);
                EditorPrefs.SetBool("docsChecklistAvatarWeightPaintedPref", docsChecklistAvatarWeightPaintedPref);
                EditorPrefs.SetBool("docsChecklistAvatarModelImportPref", docsChecklistAvatarModelImportPref);
                EditorPrefs.SetBool("docsChecklistAvatarEyesPref", docsChecklistAvatarEyesPref);
                EditorPrefs.SetBool("docsChecklistAvatarRequiredBonesPref", docsChecklistAvatarRequiredBonesPref);
                EditorPrefs.SetBool("docsChecklistAvatarMapBonesPref", docsChecklistAvatarMapBonesPref);
                EditorPrefs.SetBool("docsChecklistAvatarApplyMaterialsPref", docsChecklistAvatarApplyMaterialsPref);
                EditorPrefs.SetBool("docsChecklistAvatarCreateGameObjectPref", docsChecklistAvatarCreateGameObjectPref);
                EditorPrefs.SetBool("docsChecklistAvatarCreatePrefabPref", docsChecklistAvatarCreatePrefabPref);
                EditorPrefs.SetBool("docsChecklistAvatarEditPrefabDirectlyPref", docsChecklistAvatarEditPrefabDirectlyPref);
                EditorPrefs.SetBool("docsChecklistAvatarScriptBodyMeshesPref", docsChecklistAvatarScriptBodyMeshesPref);
                EditorPrefs.SetBool("docsChecklistAvatarScriptWristBonesPref", docsChecklistAvatarScriptWristBonesPref);
                EditorPrefs.SetBool("docsChecklistAvatarScriptEyeOverridePref", docsChecklistAvatarScriptEyeOverridePref);
                EditorPrefs.SetBool("docsChecklistAvatarEditBodyPref", docsChecklistAvatarEditBodyPref);
                EditorPrefs.SetBool("docsChecklistAvatarEyeOffsetPref", docsChecklistAvatarEyeOffsetPref);
                EditorPrefs.SetBool("docsChecklistAvatarCustomSoundsPref", docsChecklistAvatarCustomSoundsPref);
                EditorPrefs.SetBool("docsChecklistAvatarAudioVariancePref", docsChecklistAvatarAudioVariancePref);
                EditorPrefs.SetBool("docsChecklistAvatarAddSoundClipsPref", docsChecklistAvatarAddSoundClipsPref);
                EditorPrefs.SetBool("docsChecklistAvatarOpenAssetWarehousePref", docsChecklistAvatarOpenAssetWarehousePref);
                EditorPrefs.SetBool("docsChecklistAvatarAddCratePref", docsChecklistAvatarAddCratePref);
                EditorPrefs.SetBool("docsChecklistAvatarPackPalletPref", docsChecklistAvatarPackPalletPref);
                EditorPrefs.SetBool("docsChecklistAvatarInstallModPref", docsChecklistAvatarInstallModPref);
                EditorPrefs.SetBool("docsChecklistLevelLayoutEnvironmentPref", docsChecklistLevelLayoutEnvironmentPref);
                EditorPrefs.SetBool("docsChecklistLevelLightsPref", docsChecklistLevelLightsPref);
                EditorPrefs.SetBool("docsChecklistLevelLightProbesPref", docsChecklistLevelLightProbesPref);
                EditorPrefs.SetBool("docsChecklistLevelReflectionProbesPref", docsChecklistLevelReflectionProbesPref);
                EditorPrefs.SetBool("docsChecklistLevelBakeLightsPref", docsChecklistLevelBakeLightsPref);
                EditorPrefs.SetBool("docsChecklistLevelAddFogVolumePref", docsChecklistLevelAddFogVolumePref);
                EditorPrefs.SetBool("docsChecklistLevelBakeFogPref", docsChecklistLevelBakeFogPref);
                EditorPrefs.SetBool("docsChecklistLevelBakeNavMeshPref", docsChecklistLevelBakeNavMeshPref);
                EditorPrefs.SetBool("docsChecklistLevelBakeOcclusionPref", docsChecklistLevelBakeOcclusionPref);
                EditorPrefs.SetBool("docsChecklistLevelPlacePlayerMarkerPref", docsChecklistLevelPlacePlayerMarkerPref);
                EditorPrefs.SetBool("docsChecklistLevelAddZonesPref", docsChecklistLevelAddZonesPref);
                EditorPrefs.SetBool("docsChecklistLevelLinkZonesPref", docsChecklistLevelLinkZonesPref);
                EditorPrefs.SetBool("docsChecklistLevelPlaceCrateSpawnersPref", docsChecklistLevelPlaceCrateSpawnersPref);
                EditorPrefs.SetBool("docsChecklistLevelZonePermissionsPref", docsChecklistLevelZonePermissionsPref);
                EditorPrefs.SetBool("docsChecklistLevelReverbZonesPref", docsChecklistLevelReverbZonesPref);
                EditorPrefs.SetBool("docsChecklistLevelZoneMusicAmbiencePref", docsChecklistLevelZoneMusicAmbiencePref);
                EditorPrefs.SetBool("docsChecklistLevelZoneEventsPref", docsChecklistLevelZoneEventsPref);
                EditorPrefs.SetBool("docsChecklistLevelSceneChunksPref", docsChecklistLevelSceneChunksPref);
                EditorPrefs.SetBool("docsChecklistLevelOpenAssetWarehousePref", docsChecklistLevelOpenAssetWarehousePref);
                EditorPrefs.SetBool("docsChecklistLevelAddCratePref", docsChecklistLevelAddCratePref);
                EditorPrefs.SetBool("docsChecklistLevelPackPalletPref", docsChecklistLevelPackPalletPref);
                EditorPrefs.SetBool("docsChecklistLevelInstallModPref", docsChecklistLevelInstallModPref);
                EditorPrefs.SetBool("awSettingsListOrTree", awSettingsListOrTree);
                EditorPrefs.SetInt("awSettingsBuildIndex", awSettingsBuildIndex);
                EditorPrefs.SetInt("awSettingsPalletIndex", awSettingsPalletIndex);
                EditorPrefs.SetBool("awSettingsShowLevels", awSettingsShowLevels);
                EditorPrefs.SetBool("awSettingsShowAvatars", awSettingsShowAvatars);
                EditorPrefs.SetBool("awSettingsShowSpawnables", awSettingsShowSpawnables);
                EditorPrefs.SetBool("awSettingsShowDatacards", awSettingsShowDatacards);
                EditorPrefs.SetString("awSettingsSelectedIDs", awSettingsSelectedIDs);
            }
        }
    }
}