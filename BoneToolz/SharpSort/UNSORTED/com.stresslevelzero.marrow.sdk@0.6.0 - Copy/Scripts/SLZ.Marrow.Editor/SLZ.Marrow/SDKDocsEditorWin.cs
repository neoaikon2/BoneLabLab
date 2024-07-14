#if UNITY_EDITOR
using SLZ.MarrowEditor;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using System.IO;
using System.Text.RegularExpressions;

namespace SLZ.Marrow
{
    public class SDKDocsEditorWin : EditorWindow
    {
        private VisualElement docsContainer;
        private string videoIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Zone_Icons/icon_marrow_video.png");
        private string assetWarehouseIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/");
        private string editorImagePath = MarrowSDK.GetPackagePath("Editor/SDKDocumentation/Images");
        [MenuItem("Stress Level Zero/MarrowSDK Documentation", false, 5000)]
        public static void ShowSDKDocsWindowEditor()
        {
            EditorWindow sdkDocsWin = GetWindow<SDKDocsEditorWin>();
            sdkDocsWin.titleContent = new GUIContent("MarrowSDK Documentation");
            sdkDocsWin.minSize = new Vector2(360, 740);
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("afd1a6a479b67ac44a041e329f26c073");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            ScrollView sdkDocsScrollView = rootVisualElement.Q<ScrollView>("sdkDocsScrollView");
            docsContainer = rootVisualElement.Q<VisualElement>("docsContainer");
            ToolbarSearchField sdkDocsSearchField = rootVisualElement.Q<ToolbarSearchField>("sdkDocsSearchField");
            sdkDocsSearchField.RegisterValueChangedCallback(evt =>
            {
                if (sdkDocsSearchField.value == null || sdkDocsSearchField.value == "")
                {
                    SearchDocs("");
                    ShowAllDocs();
                }
                else
                {
                    SearchDocs(sdkDocsSearchField.value.ToString());
                }
            });
            Texture2D videoIcon = EditorGUIUtility.Load(videoIconPath) as Texture2D;
            Texture2D palletIcon = EditorGUIUtility.Load(Path.Join(assetWarehouseIconPath, "pallet.png")) as Texture2D;
            Texture2D spawnerIcon = EditorGUIUtility.Load(Path.Join(assetWarehouseIconPath, "crate-ball.png")) as Texture2D;
            Texture2D levelIcon = EditorGUIUtility.Load(Path.Join(assetWarehouseIconPath, "crate-level.png")) as Texture2D;
            Texture2D avatarIcon = EditorGUIUtility.Load(Path.Join(assetWarehouseIconPath, "crate-avatar.png")) as Texture2D;
            Button docsWikiButton = rootVisualElement.Q<Button>("docsWikiButton");
            docsWikiButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki");
            };
            Foldout docsSDKSetupFoldout = rootVisualElement.Q<Foldout>("docsSDKSetupFoldout");
            docsSDKSetupFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsAssetWarehouseFoldout = rootVisualElement.Q<Foldout>("docsAssetWarehouseFoldout");
            docsAssetWarehouseFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsChecklistSpawnersFoldout = rootVisualElement.Q<Foldout>("docsChecklistSpawnersFoldout");
            docsChecklistSpawnersFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsChecklistAvatarsFoldout = rootVisualElement.Q<Foldout>("docsChecklistAvatarsFoldout");
            docsChecklistAvatarsFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsChecklistLevelsFoldout = rootVisualElement.Q<Foldout>("docsChecklistLevelsFoldout");
            docsChecklistLevelsFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsCustomPalletsFoldout = rootVisualElement.Q<Foldout>("docsCustomPalletsFoldout");
            docsCustomPalletsFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsZonesFoldout = rootVisualElement.Q<Foldout>("docsZonesFoldout");
            docsZonesFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsZoneEventsFoldout = rootVisualElement.Q<Foldout>("docsZoneEventsFoldout");
            docsZoneEventsFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsZoneMusicFoldout = rootVisualElement.Q<Foldout>("docsZoneMusicFoldout");
            docsZoneMusicFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsZoneAmbienceFoldout = rootVisualElement.Q<Foldout>("docsZoneAmbienceFoldout");
            docsZoneAmbienceFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsZoneLoadLevelFoldout = rootVisualElement.Q<Foldout>("docsZoneLoadLevelFoldout");
            docsZoneLoadLevelFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsSceneChunksFoldout = rootVisualElement.Q<Foldout>("docsSceneChunksFoldout");
            docsSceneChunksFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsSceneChunksSummaryFoldout = rootVisualElement.Q<Foldout>("docsSceneChunksSummaryFoldout");
            docsSceneChunksSummaryFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            Foldout docsSceneChunksCautionsFoldout = rootVisualElement.Q<Foldout>("docsSceneChunksCautionsFoldout");
            docsSceneChunksCautionsFoldout.RegisterValueChangedCallback(evt =>
            {
                ForceScrollUpdate(sdkDocsScrollView);
            });
            bool spawnersMode = false;
            bool avatarsMode = false;
            bool levelsMode = false;
            Button docsChecklistModeSpawnersButton = rootVisualElement.Q<Button>("docsChecklistModeSpawnersButton");
            Image docsChecklistModeSpawnersImage = new Image();
            docsChecklistModeSpawnersImage.image = spawnerIcon;
            docsChecklistModeSpawnersButton.Add(docsChecklistModeSpawnersImage);
            docsChecklistModeSpawnersImage.StretchToParentSize();
            docsChecklistModeSpawnersButton.clickable.clicked += () =>
            {
                if (!spawnersMode)
                {
                    SearchDocs("spawners");
                    sdkDocsSearchField.SetValueWithoutNotify("spawners");
                    docsChecklistSpawnersFoldout.value = true;
                    spawnersMode = true;
                }
                else
                {
                    spawnersMode = false;
                    sdkDocsSearchField.SetValueWithoutNotify("");
                    SearchDocs("");
                }

                ForceScrollUpdate(sdkDocsScrollView);
            };
            Button docsChecklistModeAvatarsButton = rootVisualElement.Q<Button>("docsChecklistModeAvatarsButton");
            Image docsChecklistModeAvatarsImage = new Image();
            docsChecklistModeAvatarsImage.image = avatarIcon;
            docsChecklistModeAvatarsButton.Add(docsChecklistModeAvatarsImage);
            docsChecklistModeAvatarsImage.StretchToParentSize();
            docsChecklistModeAvatarsButton.clickable.clicked += () =>
            {
                if (!avatarsMode)
                {
                    SearchDocs("avatars");
                    sdkDocsSearchField.SetValueWithoutNotify("avatars");
                    docsChecklistAvatarsFoldout.value = true;
                    avatarsMode = true;
                }
                else
                {
                    avatarsMode = false;
                    sdkDocsSearchField.SetValueWithoutNotify("");
                    SearchDocs("");
                }

                ForceScrollUpdate(sdkDocsScrollView);
            };
            Button docsChecklistModeLevelsButton = rootVisualElement.Q<Button>("docsChecklistModeLevelsButton");
            Image docsChecklistModeLevelsImage = new Image();
            docsChecklistModeLevelsImage.image = levelIcon;
            docsChecklistModeLevelsButton.Add(docsChecklistModeLevelsImage);
            docsChecklistModeLevelsImage.StretchToParentSize();
            docsChecklistModeLevelsButton.clickable.clicked += () =>
            {
                if (!levelsMode)
                {
                    SearchDocs("levels");
                    sdkDocsSearchField.SetValueWithoutNotify("levels");
                    docsChecklistLevelsFoldout.value = true;
                    levelsMode = true;
                }
                else
                {
                    levelsMode = false;
                    sdkDocsSearchField.SetValueWithoutNotify("");
                    SearchDocs("");
                }

                ForceScrollUpdate(sdkDocsScrollView);
            };
            Button docsMarrowSDKSetupButton = rootVisualElement.Q<Button>("docsMarrowSDKSetupButton");
            docsMarrowSDKSetupButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki#project-setup");
            };
            Button docsMarrowSDKSetupVideoButton = rootVisualElement.Q<Button>("docsMarrowSDKSetupVideoButton");
            Image docsVideoButtonImageSetup = new Image();
            docsVideoButtonImageSetup.image = videoIcon;
            docsMarrowSDKSetupVideoButton.Add(docsVideoButtonImageSetup);
            docsVideoButtonImageSetup.StretchToParentSize();
            docsMarrowSDKSetupVideoButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=AKylo9lPqXQ");
            };
            Button docsCrateSpawnersButton = rootVisualElement.Q<Button>("docsCrateSpawnersButton");
            docsCrateSpawnersButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Spawnables");
            };
            Button docsAvatarCrateButton = rootVisualElement.Q<Button>("docsAvatarCrateButton");
            docsAvatarCrateButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Avatars");
            };
            Button docsCreateNewPalletButton = rootVisualElement.Q<Button>("docsCreateNewPalletButton");
            Image docsCreateNewPalletImage = new Image();
            docsCreateNewPalletImage.image = palletIcon;
            docsCreateNewPalletButton.Add(docsCreateNewPalletImage);
            docsCreateNewPalletImage.StretchToParentSize();
            docsCreateNewPalletImage.style.marginRight = 110;
            docsCreateNewPalletButton.clickable.clicked += () =>
            {
                CreatePalletEditorWindow.ShowCreatePalletWindowEditor();
            };
            Button docsGameInstallLocatorButton = rootVisualElement.Q<Button>("docsGameInstallLocatorButton");
            docsGameInstallLocatorButton.clickable.clicked += () =>
            {
                GameInstallDirectoryEditorWindow.ShowGameInstallDirWindowEditor();
            };
            Button docsAvatarCrateVideoButton = rootVisualElement.Q<Button>("docsAvatarCrateVideoButton");
            Image docsVideoButtonImageAvatar = new Image();
            docsVideoButtonImageAvatar.image = videoIcon;
            docsAvatarCrateVideoButton.Add(docsVideoButtonImageAvatar);
            docsVideoButtonImageAvatar.StretchToParentSize();
            docsAvatarCrateVideoButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=nH7HB7u7GtM");
            };
            VisualElement docsChecklistAvatarBonesImageBodyContainer = rootVisualElement.Q<VisualElement>("docsChecklistAvatarBonesImageBodyContainer");
            Image docsChecklistAvatarBonesImageBody = new Image
            {
                image = EditorGUIUtility.Load(Path.Join(editorImagePath, "optional_bones_body.png")) as Texture2D
            };
            docsChecklistAvatarBonesImageBodyContainer.style.backgroundImage = (StyleBackground)docsChecklistAvatarBonesImageBody.image;
            Button docsChecklistAvatarBonesImageBodyButton = rootVisualElement.Q<Button>("docsChecklistAvatarBonesImageBodyButton");
            docsChecklistAvatarBonesImageBodyButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://raw.githubusercontent.com/wiki/StressLevelZero/MarrowSDK/Images/Avatar/optional_bones_body.png");
            };
            VisualElement docsChecklistAvatarBonesImageHeadContainer = rootVisualElement.Q<VisualElement>("docsChecklistAvatarBonesImageHeadContainer");
            Image docsChecklistAvatarBonesImageHead = new Image
            {
                image = EditorGUIUtility.Load(Path.Join(editorImagePath, "optional_bones_head.png")) as Texture2D
            };
            docsChecklistAvatarBonesImageHeadContainer.style.backgroundImage = (StyleBackground)docsChecklistAvatarBonesImageHead.image;
            Button docsChecklistAvatarBonesImageHeadButton = rootVisualElement.Q<Button>("docsChecklistAvatarBonesImageHeadButton");
            docsChecklistAvatarBonesImageHeadButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://raw.githubusercontent.com/wiki/StressLevelZero/MarrowSDK/Images/Avatar/optional_bones_head.png");
            };
            VisualElement docsChecklistAvatarBonesImageHandContainer = rootVisualElement.Q<VisualElement>("docsChecklistAvatarBonesImageHandContainer");
            Image docsChecklistAvatarBonesImageHand = new Image
            {
                image = EditorGUIUtility.Load(Path.Join(editorImagePath, "optional_bones_hand.png")) as Texture2D
            };
            docsChecklistAvatarBonesImageHandContainer.style.backgroundImage = (StyleBackground)docsChecklistAvatarBonesImageHand.image;
            Button docsChecklistAvatarBonesImageHandButton = rootVisualElement.Q<Button>("docsChecklistAvatarBonesImageHandButton");
            docsChecklistAvatarBonesImageHandButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://raw.githubusercontent.com/wiki/StressLevelZero/MarrowSDK/Images/Avatar/optional_bones_hand.png");
            };
            Button docsLevelCrateButton = rootVisualElement.Q<Button>("docsLevelCrateButton");
            docsLevelCrateButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Levels");
            };
            Button docsPalletPackButton = rootVisualElement.Q<Button>("docsCustomPalletsButton");
            docsPalletPackButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/BuildPallet");
            };
            Button docsZonesButton = rootVisualElement.Q<Button>("docsZonesButton");
            docsZonesButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Zones");
            };
            Button docsZoneEventsButton = rootVisualElement.Q<Button>("docsZoneEventsButton");
            docsZoneEventsButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneEvents");
            };
            Button docsZoneMusicButton = rootVisualElement.Q<Button>("docsZoneMusicButton");
            docsZoneMusicButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneMusic");
            };
            Button docsZoneAmbienceButton = rootVisualElement.Q<Button>("docsZoneAmbienceButton");
            docsZoneAmbienceButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneAmbience");
            };
            Button docsZoneLoadLevelButton = rootVisualElement.Q<Button>("docsZoneLoadLevelButton");
            docsZoneLoadLevelButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/ZoneLoadLevel");
            };
            Button docsSceneChunksButton = rootVisualElement.Q<Button>("docsSceneChunksButton");
            docsSceneChunksButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki/SceneChunks");
            };
            Button docsAssetWarehouseButton = rootVisualElement.Q<Button>("docsAssetWarehouseButton");
            docsAssetWarehouseButton.clickable.clicked += () =>
            {
                AssetWarehouseWindow.ShowWindow();
            };
            Button docsOpenAssetWarehouseButtonChecklist = rootVisualElement.Q<Button>("docsOpenAssetWarehouseButtonChecklist");
            docsOpenAssetWarehouseButtonChecklist.clickable.clicked += () =>
            {
                AssetWarehouseWindow.ShowWindow();
            };
            Button docsZoneToolsButton = rootVisualElement.Q<Button>("docsZoneToolsButton");
            docsZoneToolsButton.clickable.clicked += () =>
            {
                ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
            };
            Button docsZoneCreationOverlayButton = rootVisualElement.Q<Button>("docsZoneCreationOverlayButton");
            docsZoneCreationOverlayButton.clickable.clicked += () =>
            {
                ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                ZoneCreateLinkOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
            };
            Button docsSpawnersOverlayButton = rootVisualElement.Q<Button>("docsSpawnersOverlayButton");
            docsSpawnersOverlayButton.clickable.clicked += () =>
            {
                AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
            };
            Button docsSpawnersAWSpawnOverlayButton = rootVisualElement.Q<Button>("docsSpawnersAWSpawnOverlayButton");
            docsSpawnersAWSpawnOverlayButton.clickable.clicked += () =>
            {
                AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.displayed = true);
                AWSpawnerOverlayToolbar.DoWithInstances(instance => instance.collapsed = false);
            };
            Button docsSpawnersWindowButton = rootVisualElement.Q<Button>("docsSpawnersWindowButton");
            docsSpawnersWindowButton.clickable.clicked += () =>
            {
                AWSpawnerEditorWin.ShowAWSpawnerWindowEditor();
            };
            Button docsSpawnersAWSpawnWindowButton = rootVisualElement.Q<Button>("docsSpawnersAWSpawnWindowButton");
            docsSpawnersAWSpawnWindowButton.clickable.clicked += () =>
            {
                AWSpawnerEditorWin.ShowAWSpawnerWindowEditor();
            };
            Button docsChecklistLevelUtilButton = rootVisualElement.Q<Button>("docsChecklistLevelUtilButton");
            docsChecklistLevelUtilButton.clickable.clicked += () =>
            {
            };
            Toggle docsChecklistAvatarHumanoid = rootVisualElement.Q<Toggle>("docsChecklistAvatarHumanoid");
            docsChecklistAvatarHumanoid.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarHumanoid.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarHumanoidPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarHumanoidPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarHumanoidPref", MarrowSDKPreferences.docsChecklistAvatarHumanoidPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarHumanoidPref = EditorPrefs.GetBool("docsChecklistAvatarHumanoidPref", false);
            docsChecklistAvatarHumanoid.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarHumanoidPref);
            Toggle docsChecklistAvatarWeightPainted = rootVisualElement.Q<Toggle>("docsChecklistAvatarWeightPainted");
            docsChecklistAvatarWeightPainted.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarWeightPainted.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarWeightPaintedPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarWeightPaintedPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarWeightPaintedPref", MarrowSDKPreferences.docsChecklistAvatarWeightPaintedPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarWeightPaintedPref = EditorPrefs.GetBool("docsChecklistAvatarWeightPaintedPref", false);
            docsChecklistAvatarWeightPainted.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarWeightPaintedPref);
            Toggle docsChecklistAvatarModelImport = rootVisualElement.Q<Toggle>("docsChecklistAvatarModelImport");
            docsChecklistAvatarModelImport.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarModelImport.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarModelImportPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarModelImportPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarModelImportPref", MarrowSDKPreferences.docsChecklistAvatarModelImportPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarModelImportPref = EditorPrefs.GetBool("docsChecklistAvatarModelImportPref", false);
            docsChecklistAvatarModelImport.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarModelImportPref);
            Toggle docsChecklistAvatarEyes = rootVisualElement.Q<Toggle>("docsChecklistAvatarEyes");
            docsChecklistAvatarEyes.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarEyes.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarEyesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarEyesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarEyesPref", MarrowSDKPreferences.docsChecklistAvatarEyesPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarEyesPref = EditorPrefs.GetBool("docsChecklistAvatarEyesPref", false);
            docsChecklistAvatarEyes.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarEyesPref);
            Toggle docsChecklistAvatarRequiredBones = rootVisualElement.Q<Toggle>("docsChecklistAvatarRequiredBones");
            docsChecklistAvatarRequiredBones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarRequiredBones.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarRequiredBonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarRequiredBonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarRequiredBonesPref", MarrowSDKPreferences.docsChecklistAvatarRequiredBonesPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarRequiredBonesPref = EditorPrefs.GetBool("docsChecklistAvatarRequiredBonesPref", false);
            docsChecklistAvatarRequiredBones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarRequiredBonesPref);
            Toggle docsChecklistAvatarMapBones = rootVisualElement.Q<Toggle>("docsChecklistAvatarMapBones");
            docsChecklistAvatarMapBones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarMapBones.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarMapBonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarMapBonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarMapBonesPref", MarrowSDKPreferences.docsChecklistAvatarMapBonesPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarMapBonesPref = EditorPrefs.GetBool("docsChecklistAvatarMapBonesPref", false);
            docsChecklistAvatarMapBones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarMapBonesPref);
            Toggle docsChecklistAvatarApplyMaterials = rootVisualElement.Q<Toggle>("docsChecklistAvatarApplyMaterials");
            docsChecklistAvatarApplyMaterials.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarApplyMaterials.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarApplyMaterialsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarApplyMaterialsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarApplyMaterialsPref", MarrowSDKPreferences.docsChecklistAvatarApplyMaterialsPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarApplyMaterialsPref = EditorPrefs.GetBool("docsChecklistAvatarApplyMaterialsPref", false);
            docsChecklistAvatarApplyMaterials.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarApplyMaterialsPref);
            Toggle docsChecklistAvatarCreateGameObject = rootVisualElement.Q<Toggle>("docsChecklistAvatarCreateGameObject");
            docsChecklistAvatarCreateGameObject.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarCreateGameObject.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarCreateGameObjectPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarCreateGameObjectPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarCreateGameObjectPref", MarrowSDKPreferences.docsChecklistAvatarCreateGameObjectPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarCreateGameObjectPref = EditorPrefs.GetBool("docsChecklistAvatarCreateGameObjectPref", false);
            docsChecklistAvatarCreateGameObject.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarCreateGameObjectPref);
            Toggle docsChecklistAvatarCreatePrefab = rootVisualElement.Q<Toggle>("docsChecklistAvatarCreatePrefab");
            docsChecklistAvatarCreatePrefab.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarCreatePrefab.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarCreatePrefabPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarCreatePrefabPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarCreatePrefabPref", MarrowSDKPreferences.docsChecklistAvatarCreatePrefabPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarCreatePrefabPref = EditorPrefs.GetBool("docsChecklistAvatarCreatePrefabPref", false);
            docsChecklistAvatarCreatePrefab.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarCreatePrefabPref);
            Toggle docsChecklistAvatarEditPrefabDirectly = rootVisualElement.Q<Toggle>("docsChecklistAvatarEditPrefabDirectly");
            docsChecklistAvatarEditPrefabDirectly.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarEditPrefabDirectly.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarEditPrefabDirectlyPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarEditPrefabDirectlyPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarEditPrefabDirectlyPref", MarrowSDKPreferences.docsChecklistAvatarEditPrefabDirectlyPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarEditPrefabDirectlyPref = EditorPrefs.GetBool("docsChecklistAvatarEditPrefabDirectlyPref", false);
            docsChecklistAvatarEditPrefabDirectly.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarEditPrefabDirectlyPref);
            Toggle docsChecklistAvatarScriptBodyMeshes = rootVisualElement.Q<Toggle>("docsChecklistAvatarScriptBodyMeshes");
            docsChecklistAvatarScriptBodyMeshes.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarScriptBodyMeshes.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptBodyMeshesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptBodyMeshesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarScriptBodyMeshesPref", MarrowSDKPreferences.docsChecklistAvatarScriptBodyMeshesPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarScriptBodyMeshesPref = EditorPrefs.GetBool("docsChecklistAvatarScriptBodyMeshesPref", false);
            docsChecklistAvatarScriptBodyMeshes.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarScriptBodyMeshesPref);
            Toggle docsChecklistAvatarScriptWristBones = rootVisualElement.Q<Toggle>("docsChecklistAvatarScriptWristBones");
            docsChecklistAvatarScriptWristBones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarScriptWristBones.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptWristBonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptWristBonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarScriptWristBonesPref", MarrowSDKPreferences.docsChecklistAvatarScriptWristBonesPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarScriptWristBonesPref = EditorPrefs.GetBool("docsChecklistAvatarScriptWristBonesPref", false);
            docsChecklistAvatarScriptWristBones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarScriptWristBonesPref);
            Toggle docsChecklistAvatarScriptEyeOverride = rootVisualElement.Q<Toggle>("docsChecklistAvatarScriptEyeOverride");
            docsChecklistAvatarScriptEyeOverride.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarScriptEyeOverride.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptEyeOverridePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarScriptEyeOverridePref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarScriptEyeOverridePref", MarrowSDKPreferences.docsChecklistAvatarScriptEyeOverridePref);
            });
            MarrowSDKPreferences.docsChecklistAvatarScriptEyeOverridePref = EditorPrefs.GetBool("docsChecklistAvatarScriptEyeOverridePref", false);
            docsChecklistAvatarScriptEyeOverride.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarScriptEyeOverridePref);
            Toggle docsChecklistAvatarEditBody = rootVisualElement.Q<Toggle>("docsChecklistAvatarEditBody");
            docsChecklistAvatarEditBody.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarEditBody.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarEditBodyPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarEditBodyPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarEditBodyPref", MarrowSDKPreferences.docsChecklistAvatarEditBodyPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarEditBodyPref = EditorPrefs.GetBool("docsChecklistAvatarEditBodyPref", false);
            docsChecklistAvatarEditBody.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarEditBodyPref);
            Toggle docsChecklistAvatarEyeOffset = rootVisualElement.Q<Toggle>("docsChecklistAvatarEyeOffset");
            docsChecklistAvatarEyeOffset.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarEyeOffset.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarEyeOffsetPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarEyeOffsetPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarEyeOffsetPref", MarrowSDKPreferences.docsChecklistAvatarEyeOffsetPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarEyeOffsetPref = EditorPrefs.GetBool("docsChecklistAvatarEyeOffsetPref", false);
            docsChecklistAvatarEyeOffset.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarEyeOffsetPref);
            Toggle docsChecklistAvatarCustomSounds = rootVisualElement.Q<Toggle>("docsChecklistAvatarCustomSounds");
            docsChecklistAvatarCustomSounds.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarCustomSounds.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarCustomSoundsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarCustomSoundsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarCustomSoundsPref", MarrowSDKPreferences.docsChecklistAvatarCustomSoundsPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarCustomSoundsPref = EditorPrefs.GetBool("docsChecklistAvatarCustomSoundsPref", false);
            docsChecklistAvatarCustomSounds.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarCustomSoundsPref);
            Toggle docsChecklistAvatarAudioVariance = rootVisualElement.Q<Toggle>("docsChecklistAvatarAudioVariance");
            docsChecklistAvatarAudioVariance.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarAudioVariance.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarAudioVariancePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarAudioVariancePref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarAudioVariancePref", MarrowSDKPreferences.docsChecklistAvatarAudioVariancePref);
            });
            MarrowSDKPreferences.docsChecklistAvatarAudioVariancePref = EditorPrefs.GetBool("docsChecklistAvatarAudioVariancePref", false);
            docsChecklistAvatarAudioVariance.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarAudioVariancePref);
            Toggle docsChecklistAvatarAddSoundClips = rootVisualElement.Q<Toggle>("docsChecklistAvatarAddSoundClips");
            docsChecklistAvatarAddSoundClips.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarAddSoundClips.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarAddSoundClipsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarAddSoundClipsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarAddSoundClipsPref", MarrowSDKPreferences.docsChecklistAvatarAddSoundClipsPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarAddSoundClipsPref = EditorPrefs.GetBool("docsChecklistAvatarAddSoundClipsPref", false);
            docsChecklistAvatarAddSoundClips.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarAddSoundClipsPref);
            Toggle docsChecklistAvatarOpenAssetWarehouse = rootVisualElement.Q<Toggle>("docsChecklistAvatarOpenAssetWarehouse");
            docsChecklistAvatarOpenAssetWarehouse.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarOpenAssetWarehouse.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarOpenAssetWarehousePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarOpenAssetWarehousePref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarOpenAssetWarehousePref", MarrowSDKPreferences.docsChecklistAvatarOpenAssetWarehousePref);
            });
            MarrowSDKPreferences.docsChecklistAvatarOpenAssetWarehousePref = EditorPrefs.GetBool("docsChecklistAvatarOpenAssetWarehousePref", false);
            docsChecklistAvatarOpenAssetWarehouse.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarOpenAssetWarehousePref);
            Toggle docsChecklistAvatarAddCrate = rootVisualElement.Q<Toggle>("docsChecklistAvatarAddCrate");
            docsChecklistAvatarAddCrate.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarAddCrate.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarAddCratePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarAddCratePref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarAddCratePref", MarrowSDKPreferences.docsChecklistAvatarAddCratePref);
            });
            MarrowSDKPreferences.docsChecklistAvatarAddCratePref = EditorPrefs.GetBool("docsChecklistAvatarAddCratePref", false);
            docsChecklistAvatarAddCrate.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarAddCratePref);
            Toggle docsChecklistAvatarPackPallet = rootVisualElement.Q<Toggle>("docsChecklistAvatarPackPallet");
            docsChecklistAvatarPackPallet.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarPackPallet.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarPackPalletPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarPackPalletPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarPackPalletPref", MarrowSDKPreferences.docsChecklistAvatarPackPalletPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarPackPalletPref = EditorPrefs.GetBool("docsChecklistAvatarPackPalletPref", false);
            docsChecklistAvatarPackPallet.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarPackPalletPref);
            Toggle docsChecklistAvatarInstallMod = rootVisualElement.Q<Toggle>("docsChecklistAvatarInstallMod");
            docsChecklistAvatarInstallMod.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistAvatarInstallMod.value)
                {
                    MarrowSDKPreferences.docsChecklistAvatarInstallModPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistAvatarInstallModPref = false;
                }

                EditorPrefs.SetBool("docsChecklistAvatarInstallModPref", MarrowSDKPreferences.docsChecklistAvatarInstallModPref);
            });
            MarrowSDKPreferences.docsChecklistAvatarInstallModPref = EditorPrefs.GetBool("docsChecklistAvatarInstallModPref", false);
            docsChecklistAvatarInstallMod.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistAvatarInstallModPref);
            Button docsAvatarChecklistResetButton = rootVisualElement.Q<Button>("docsAvatarChecklistResetButton");
            docsAvatarChecklistResetButton.clickable.clicked += () =>
            {
                docsChecklistAvatarHumanoid.value = false;
                docsChecklistAvatarWeightPainted.value = false;
                docsChecklistAvatarModelImport.value = false;
                docsChecklistAvatarEyes.value = false;
                docsChecklistAvatarRequiredBones.value = false;
                docsChecklistAvatarMapBones.value = false;
                docsChecklistAvatarApplyMaterials.value = false;
                docsChecklistAvatarCreateGameObject.value = false;
                docsChecklistAvatarCreatePrefab.value = false;
                docsChecklistAvatarEditPrefabDirectly.value = false;
                docsChecklistAvatarScriptBodyMeshes.value = false;
                docsChecklistAvatarScriptWristBones.value = false;
                docsChecklistAvatarScriptEyeOverride.value = false;
                docsChecklistAvatarEditBody.value = false;
                docsChecklistAvatarEyeOffset.value = false;
                docsChecklistAvatarCustomSounds.value = false;
                docsChecklistAvatarAudioVariance.value = false;
                docsChecklistAvatarAddSoundClips.value = false;
                docsChecklistAvatarOpenAssetWarehouse.value = false;
                docsChecklistAvatarAddCrate.value = false;
                docsChecklistAvatarPackPallet.value = false;
                docsChecklistAvatarInstallMod.value = false;
            };
            Toggle docsChecklistLevelLayoutEnvironment = rootVisualElement.Q<Toggle>("docsChecklistLevelLayoutEnvironment");
            docsChecklistLevelLayoutEnvironment.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelLayoutEnvironment.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelLayoutEnvironmentPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelLayoutEnvironmentPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelLayoutEnvironmentPref", MarrowSDKPreferences.docsChecklistLevelLayoutEnvironmentPref);
            });
            MarrowSDKPreferences.docsChecklistLevelLayoutEnvironmentPref = EditorPrefs.GetBool("docsChecklistLevelLayoutEnvironmentPref", false);
            docsChecklistLevelLayoutEnvironment.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelLayoutEnvironmentPref);
            Toggle docsChecklistLevelLights = rootVisualElement.Q<Toggle>("docsChecklistLevelLights");
            docsChecklistLevelLights.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelLights.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelLightsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelLightsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelLightsPref", MarrowSDKPreferences.docsChecklistLevelLightsPref);
            });
            MarrowSDKPreferences.docsChecklistLevelLightsPref = EditorPrefs.GetBool("docsChecklistLevelLightsPref", false);
            docsChecklistLevelLights.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelLightsPref);
            Toggle docsChecklistLevelLightProbes = rootVisualElement.Q<Toggle>("docsChecklistLevelLightProbes");
            docsChecklistLevelLightProbes.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelLightProbes.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelLightProbesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelLightProbesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelLightProbesPref", MarrowSDKPreferences.docsChecklistLevelLightProbesPref);
            });
            MarrowSDKPreferences.docsChecklistLevelLightProbesPref = EditorPrefs.GetBool("docsChecklistLevelLightProbesPref", false);
            docsChecklistLevelLightProbes.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelLightProbesPref);
            Toggle docsChecklistLevelReflectionProbes = rootVisualElement.Q<Toggle>("docsChecklistLevelReflectionProbes");
            docsChecklistLevelReflectionProbes.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelReflectionProbes.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelReflectionProbesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelReflectionProbesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelReflectionProbesPref", MarrowSDKPreferences.docsChecklistLevelReflectionProbesPref);
            });
            MarrowSDKPreferences.docsChecklistLevelReflectionProbesPref = EditorPrefs.GetBool("docsChecklistLevelReflectionProbesPref", false);
            docsChecklistLevelReflectionProbes.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelReflectionProbesPref);
            Toggle docsChecklistLevelBakeLights = rootVisualElement.Q<Toggle>("docsChecklistLevelBakeLights");
            docsChecklistLevelBakeLights.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelBakeLights.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeLightsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeLightsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelBakeLightsPref", MarrowSDKPreferences.docsChecklistLevelBakeLightsPref);
            });
            MarrowSDKPreferences.docsChecklistLevelBakeLightsPref = EditorPrefs.GetBool("docsChecklistLevelBakeLightsPref", false);
            docsChecklistLevelBakeLights.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelBakeLightsPref);
            Toggle docsChecklistLevelAddFogVolume = rootVisualElement.Q<Toggle>("docsChecklistLevelAddFogVolume");
            docsChecklistLevelAddFogVolume.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelAddFogVolume.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelAddFogVolumePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelAddFogVolumePref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelAddFogVolumePref", MarrowSDKPreferences.docsChecklistLevelAddFogVolumePref);
            });
            MarrowSDKPreferences.docsChecklistLevelAddFogVolumePref = EditorPrefs.GetBool("docsChecklistLevelAddFogVolumePref", false);
            docsChecklistLevelAddFogVolume.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelAddFogVolumePref);
            Toggle docsChecklistLevelBakeFog = rootVisualElement.Q<Toggle>("docsChecklistLevelBakeFog");
            docsChecklistLevelBakeFog.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelBakeFog.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeFogPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeFogPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelBakeFogPref", MarrowSDKPreferences.docsChecklistLevelBakeFogPref);
            });
            MarrowSDKPreferences.docsChecklistLevelBakeFogPref = EditorPrefs.GetBool("docsChecklistLevelBakeFogPref", false);
            docsChecklistLevelBakeFog.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelBakeFogPref);
            Toggle docsChecklistLevelBakeNavMesh = rootVisualElement.Q<Toggle>("docsChecklistLevelBakeNavMesh");
            docsChecklistLevelBakeNavMesh.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelBakeNavMesh.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeNavMeshPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeNavMeshPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelBakeNavMeshPref", MarrowSDKPreferences.docsChecklistLevelBakeNavMeshPref);
            });
            MarrowSDKPreferences.docsChecklistLevelBakeNavMeshPref = EditorPrefs.GetBool("docsChecklistLevelBakeNavMeshPref", false);
            docsChecklistLevelBakeNavMesh.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelBakeNavMeshPref);
            Toggle docsChecklistLevelBakeOcclusion = rootVisualElement.Q<Toggle>("docsChecklistLevelBakeOcclusion");
            docsChecklistLevelBakeOcclusion.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelBakeOcclusion.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeOcclusionPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelBakeOcclusionPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelBakeOcclusionPref", MarrowSDKPreferences.docsChecklistLevelBakeOcclusionPref);
            });
            MarrowSDKPreferences.docsChecklistLevelBakeOcclusionPref = EditorPrefs.GetBool("docsChecklistLevelBakeOcclusionPref", false);
            docsChecklistLevelBakeOcclusion.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelBakeOcclusionPref);
            Toggle docsChecklistLevelPlacePlayerMarker = rootVisualElement.Q<Toggle>("docsChecklistLevelPlacePlayerMarker");
            docsChecklistLevelPlacePlayerMarker.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelPlacePlayerMarker.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelPlacePlayerMarkerPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelPlacePlayerMarkerPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelPlacePlayerMarkerPref", MarrowSDKPreferences.docsChecklistLevelPlacePlayerMarkerPref);
            });
            MarrowSDKPreferences.docsChecklistLevelPlacePlayerMarkerPref = EditorPrefs.GetBool("docsChecklistLevelPlacePlayerMarkerPref", false);
            docsChecklistLevelPlacePlayerMarker.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelPlacePlayerMarkerPref);
            Toggle docsChecklistLevelAddZones = rootVisualElement.Q<Toggle>("docsChecklistLevelAddZones");
            docsChecklistLevelAddZones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelAddZones.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelAddZonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelAddZonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelAddZonesPref", MarrowSDKPreferences.docsChecklistLevelAddZonesPref);
            });
            MarrowSDKPreferences.docsChecklistLevelAddZonesPref = EditorPrefs.GetBool("docsChecklistLevelAddZonesPref", false);
            docsChecklistLevelAddZones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelAddZonesPref);
            Toggle docsChecklistLevelLinkZones = rootVisualElement.Q<Toggle>("docsChecklistLevelLinkZones");
            docsChecklistLevelLinkZones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelLinkZones.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelLinkZonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelLinkZonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelLinkZonesPref", MarrowSDKPreferences.docsChecklistLevelLinkZonesPref);
            });
            MarrowSDKPreferences.docsChecklistLevelLinkZonesPref = EditorPrefs.GetBool("docsChecklistLevelLinkZonesPref", false);
            docsChecklistLevelLinkZones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelLinkZonesPref);
            Toggle docsChecklistLevelPlaceCrateSpawners = rootVisualElement.Q<Toggle>("docsChecklistLevelPlaceCrateSpawners");
            docsChecklistLevelPlaceCrateSpawners.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelPlaceCrateSpawners.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelPlaceCrateSpawnersPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelPlaceCrateSpawnersPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelPlaceCrateSpawnersPref", MarrowSDKPreferences.docsChecklistLevelPlaceCrateSpawnersPref);
            });
            MarrowSDKPreferences.docsChecklistLevelPlaceCrateSpawnersPref = EditorPrefs.GetBool("docsChecklistLevelPlaceCrateSpawnersPref", false);
            docsChecklistLevelPlaceCrateSpawners.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelPlaceCrateSpawnersPref);
            Toggle docsChecklistLevelZonePermissions = rootVisualElement.Q<Toggle>("docsChecklistLevelZonePermissions");
            docsChecklistLevelZonePermissions.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelZonePermissions.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelZonePermissionsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelZonePermissionsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelZonePermissionsPref", MarrowSDKPreferences.docsChecklistLevelZonePermissionsPref);
            });
            MarrowSDKPreferences.docsChecklistLevelZonePermissionsPref = EditorPrefs.GetBool("docsChecklistLevelZonePermissionsPref", false);
            docsChecklistLevelZonePermissions.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelZonePermissionsPref);
            Toggle docsChecklistLevelReverbZones = rootVisualElement.Q<Toggle>("docsChecklistLevelReverbZones");
            docsChecklistLevelReverbZones.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelReverbZones.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelReverbZonesPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelReverbZonesPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelReverbZonesPref", MarrowSDKPreferences.docsChecklistLevelReverbZonesPref);
            });
            MarrowSDKPreferences.docsChecklistLevelReverbZonesPref = EditorPrefs.GetBool("docsChecklistLevelReverbZonesPref", false);
            docsChecklistLevelReverbZones.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelReverbZonesPref);
            Toggle docsChecklistLevelZoneMusicAmbience = rootVisualElement.Q<Toggle>("docsChecklistLevelZoneMusicAmbience");
            docsChecklistLevelZoneMusicAmbience.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelZoneMusicAmbience.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelZoneMusicAmbiencePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelZoneMusicAmbiencePref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelZoneMusicAmbiencePref", MarrowSDKPreferences.docsChecklistLevelZoneMusicAmbiencePref);
            });
            MarrowSDKPreferences.docsChecklistLevelZoneMusicAmbiencePref = EditorPrefs.GetBool("docsChecklistLevelZoneMusicAmbiencePref", false);
            docsChecklistLevelZoneMusicAmbience.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelZoneMusicAmbiencePref);
            Toggle docsChecklistLevelZoneEvents = rootVisualElement.Q<Toggle>("docsChecklistLevelZoneEvents");
            docsChecklistLevelZoneEvents.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelZoneEvents.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelZoneEventsPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelZoneEventsPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelZoneEventsPref", MarrowSDKPreferences.docsChecklistLevelZoneEventsPref);
            });
            MarrowSDKPreferences.docsChecklistLevelZoneEventsPref = EditorPrefs.GetBool("docsChecklistLevelZoneEventsPref", false);
            docsChecklistLevelZoneEvents.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelZoneEventsPref);
            Toggle docsChecklistLevelSceneChunks = rootVisualElement.Q<Toggle>("docsChecklistLevelSceneChunks");
            docsChecklistLevelSceneChunks.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelSceneChunks.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelSceneChunksPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelSceneChunksPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelSceneChunksPref", MarrowSDKPreferences.docsChecklistLevelSceneChunksPref);
            });
            MarrowSDKPreferences.docsChecklistLevelSceneChunksPref = EditorPrefs.GetBool("docsChecklistLevelSceneChunksPref", false);
            docsChecklistLevelSceneChunks.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelSceneChunksPref);
            Toggle docsChecklistLevelOpenAssetWarehouse = rootVisualElement.Q<Toggle>("docsChecklistLevelOpenAssetWarehouse");
            docsChecklistLevelOpenAssetWarehouse.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelOpenAssetWarehouse.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelOpenAssetWarehousePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelOpenAssetWarehousePref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelOpenAssetWarehousePref", MarrowSDKPreferences.docsChecklistLevelOpenAssetWarehousePref);
            });
            MarrowSDKPreferences.docsChecklistLevelOpenAssetWarehousePref = EditorPrefs.GetBool("docsChecklistLevelOpenAssetWarehousePref", false);
            docsChecklistLevelOpenAssetWarehouse.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelOpenAssetWarehousePref);
            Toggle docsChecklistLevelAddCrate = rootVisualElement.Q<Toggle>("docsChecklistLevelAddCrate");
            docsChecklistLevelAddCrate.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelAddCrate.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelAddCratePref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelAddCratePref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelAddCratePref", MarrowSDKPreferences.docsChecklistLevelAddCratePref);
            });
            MarrowSDKPreferences.docsChecklistLevelAddCratePref = EditorPrefs.GetBool("docsChecklistLevelAddCratePref", false);
            docsChecklistLevelAddCrate.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelAddCratePref);
            Toggle docsChecklistLevelPackPallet = rootVisualElement.Q<Toggle>("docsChecklistLevelPackPallet");
            docsChecklistLevelPackPallet.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelPackPallet.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelPackPalletPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelPackPalletPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelPackPalletPref", MarrowSDKPreferences.docsChecklistLevelPackPalletPref);
            });
            MarrowSDKPreferences.docsChecklistLevelPackPalletPref = EditorPrefs.GetBool("docsChecklistLevelPackPalletPref", false);
            docsChecklistLevelPackPallet.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelPackPalletPref);
            Toggle docsChecklistLevelInstallMod = rootVisualElement.Q<Toggle>("docsChecklistLevelInstallMod");
            docsChecklistLevelInstallMod.RegisterValueChangedCallback(evt =>
            {
                if (docsChecklistLevelInstallMod.value)
                {
                    MarrowSDKPreferences.docsChecklistLevelInstallModPref = true;
                }
                else
                {
                    MarrowSDKPreferences.docsChecklistLevelInstallModPref = false;
                }

                EditorPrefs.SetBool("docsChecklistLevelInstallModPref", MarrowSDKPreferences.docsChecklistLevelInstallModPref);
            });
            MarrowSDKPreferences.docsChecklistLevelInstallModPref = EditorPrefs.GetBool("docsChecklistLevelInstallModPref", false);
            docsChecklistLevelInstallMod.SetValueWithoutNotify(MarrowSDKPreferences.docsChecklistLevelInstallModPref);
            Button docsLevelChecklistResetButton = rootVisualElement.Q<Button>("docsLevelChecklistResetButton");
            docsLevelChecklistResetButton.clickable.clicked += () =>
            {
                docsChecklistLevelLayoutEnvironment.value = false;
                docsChecklistLevelLights.value = false;
                docsChecklistLevelLightProbes.value = false;
                docsChecklistLevelReflectionProbes.value = false;
                docsChecklistLevelBakeLights.value = false;
                docsChecklistLevelAddFogVolume.value = false;
                docsChecklistLevelBakeFog.value = false;
                docsChecklistLevelBakeNavMesh.value = false;
                docsChecklistLevelBakeOcclusion.value = false;
                docsChecklistLevelPlacePlayerMarker.value = false;
                docsChecklistLevelAddZones.value = false;
                docsChecklistLevelLinkZones.value = false;
                docsChecklistLevelPlaceCrateSpawners.value = false;
                docsChecklistLevelZonePermissions.value = false;
                docsChecklistLevelReverbZones.value = false;
                docsChecklistLevelZoneMusicAmbience.value = false;
                docsChecklistLevelZoneEvents.value = false;
                docsChecklistLevelOpenAssetWarehouse.value = false;
                docsChecklistLevelAddCrate.value = false;
                docsChecklistLevelPackPallet.value = false;
                docsChecklistLevelInstallMod.value = false;
            };
        }

        private void SearchDocs(string searchField)
        {
            if (string.IsNullOrEmpty(searchField))
            {
                ShowAllDocs();
                return;
            }

            List<Label> searchResultTopics = new List<Label>();
            List<Button> searchResultItems = new List<Button>();
            List<Label> searchResultContents = new List<Label>();
            List<Label> searchResultToggleLabels = new List<Label>();
            foreach (var child in docsContainer.Children())
            {
                if (child is VisualElement)
                {
                    foreach (var subChild in child.Children())
                    {
                        if (subChild is Label labelTopic)
                        {
                            if (labelTopic.text.ToLower().Contains(searchField.ToLower()))
                            {
                                searchResultTopics.Add(labelTopic);
                            }
                        }

                        if (subChild is VisualElement buttonItemContainer)
                        {
                            foreach (var subSubChild in buttonItemContainer.Children())
                            {
                                if (subSubChild is Button buttonItem)
                                {
                                    if (buttonItem.text.ToLower().Contains(searchField.ToLower()))
                                    {
                                        searchResultItems.Add(buttonItem);
                                    }
                                }

                                if (subSubChild is Foldout foldoutItem)
                                {
                                    foreach (var subSubFoldChild in foldoutItem.Children())
                                    {
                                        if (subSubFoldChild is VisualElement foldVisContainer)
                                        {
                                            foreach (var subSubFoldVisVis in subSubFoldChild.Children())
                                            {
                                                if (subSubFoldVisVis is Label foldoutContentsLvl1)
                                                {
                                                    foldoutContentsLvl1.text = foldoutContentsLvl1.text.Replace("<color=yellow>", "");
                                                    foldoutContentsLvl1.text = foldoutContentsLvl1.text.Replace("</color>", "");
                                                    if (!string.IsNullOrEmpty(searchField) && foldoutContentsLvl1.text.ToLower().Contains(searchField.ToLower()))
                                                    {
                                                        foldoutContentsLvl1.text = Regex.Replace(foldoutContentsLvl1.text, @searchField, @"<color=yellow>$&</color>", RegexOptions.IgnoreCase);
                                                        searchResultContents.Add(foldoutContentsLvl1);
                                                    }
                                                }

                                                if (subSubFoldVisVis is VisualElement checklistToggleContainer)
                                                {
                                                    foreach (var subSubFoldVisVisVis in subSubFoldVisVis.Children())
                                                    {
                                                        if (subSubFoldVisVisVis is Toggle foldoutContentsToggle)
                                                        {
                                                            foreach (var subsubFoldVisVisToggle in subSubFoldVisVisVis.Children())
                                                            {
                                                                if (subsubFoldVisVisToggle is Label foldoutContentsToggleLabel)
                                                                {
                                                                    foldoutContentsToggleLabel.text = foldoutContentsToggleLabel.text.Replace("<color=yellow>", "");
                                                                    foldoutContentsToggleLabel.text = foldoutContentsToggleLabel.text.Replace("</color>", "");
                                                                    if (!string.IsNullOrEmpty(searchField) && foldoutContentsToggleLabel.text.ToLower().Contains(searchField.ToLower()))
                                                                    {
                                                                        foldoutContentsToggleLabel.text = Regex.Replace(foldoutContentsToggleLabel.text, @searchField, @"<color=yellow>$&</color>", RegexOptions.IgnoreCase);
                                                                        searchResultToggleLabels.Add(foldoutContentsToggleLabel);
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            HideAllDocs();
            foreach (Label topicSearch in searchResultTopics)
            {
                topicSearch.style.display = DisplayStyle.Flex;
                if (topicSearch.parent.style.display == DisplayStyle.None)
                {
                    topicSearch.parent.style.display = DisplayStyle.Flex;
                }
            }

            foreach (Button itemSearch in searchResultItems)
            {
                itemSearch.style.display = DisplayStyle.Flex;
                if (itemSearch.parent.style.display == DisplayStyle.None)
                {
                    itemSearch.parent.style.display = DisplayStyle.Flex;
                }

                if (itemSearch.parent.parent.style.display == DisplayStyle.None)
                {
                    itemSearch.parent.parent.style.display = DisplayStyle.Flex;
                }
            }

            for (var l = 0; l < searchResultContents.Count; l++)
            {
                searchResultContents[l].style.display = DisplayStyle.Flex;
                if (searchResultContents[l].parent.style.display == DisplayStyle.None)
                {
                    searchResultContents[l].parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultContents[l].parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultContents[l].parent.parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultContents[l].parent.parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultContents[l].parent.parent.parent.style.display = DisplayStyle.Flex;
                }
            }

            for (var t = 0; t < searchResultToggleLabels.Count; t++)
            {
                searchResultToggleLabels[t].style.display = DisplayStyle.Flex;
                if (searchResultToggleLabels[t].parent.style.display == DisplayStyle.None)
                {
                    searchResultToggleLabels[t].parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultToggleLabels[t].parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultToggleLabels[t].parent.parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultToggleLabels[t].parent.parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultToggleLabels[t].parent.parent.parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultToggleLabels[t].parent.parent.parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultToggleLabels[t].parent.parent.parent.parent.style.display = DisplayStyle.Flex;
                }

                if (searchResultToggleLabels[t].parent.parent.parent.parent.parent.style.display == DisplayStyle.None)
                {
                    searchResultToggleLabels[t].parent.parent.parent.parent.parent.style.display = DisplayStyle.Flex;
                }
            }
        }

        private void HideAllDocs()
        {
            foreach (var child in docsContainer.Children())
            {
                if (child is VisualElement)
                {
                    foreach (var subChild in child.Children())
                    {
                        subChild.style.display = DisplayStyle.None;
                    }
                }
            }
        }

        private void ShowAllDocs()
        {
            foreach (var child in docsContainer.Children())
            {
                if (child is VisualElement)
                {
                    foreach (var subChild in child.Children())
                    {
                        if (subChild.name.Contains("docsUtilitiesLabel") || subChild.name.Contains("docsLightProbeButtonContainer"))
                        {
                            subChild.style.display = DisplayStyle.None;
                        }
                        else
                        {
                            subChild.style.display = DisplayStyle.Flex;
                        }
                    }
                }
            }
        }

        void ForceScrollUpdate(ScrollView view)
        {
            view.schedule.Execute(() =>
            {
                var fakeOldRect = Rect.zero;
                var fakeNewRect = view.layout;
                using var evt = GeometryChangedEvent.GetPooled(fakeOldRect, fakeNewRect);
                evt.target = view.contentContainer;
                view.contentContainer.SendEvent(evt);
            }).ExecuteLater(30);
        }
    }
}
#endif
