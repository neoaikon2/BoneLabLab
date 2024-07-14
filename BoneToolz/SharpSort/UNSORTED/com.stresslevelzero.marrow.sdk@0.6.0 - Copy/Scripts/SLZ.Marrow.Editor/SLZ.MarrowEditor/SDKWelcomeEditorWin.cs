using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine;
using System.IO;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using System.Collections.Generic;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    [InitializeOnLoad]
    public class SDKWelcomeEditorWin : EditorWindow
    {
        private string gameName;
        public static string welcomePath = "Not Found";
        private List<string> foundGamePaths = new List<string>();
        private Label welcomeInstallPathLabel;
        public static EditorWindow createWelcomeWin = null;
        [MenuItem("Stress Level Zero/MarrowSDK Getting Started", false, 4999)]
        public static void ShowSDKWelcomeWindowEditor()
        {
            string palletImagePath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet16.png");
            Texture2D palletIconImage = EditorGUIUtility.Load(palletImagePath) as Texture2D;
            createWelcomeWin = GetWindow<SDKWelcomeEditorWin>();
            createWelcomeWin.titleContent = new GUIContent(" Getting Started");
            createWelcomeWin.titleContent.image = palletIconImage;
            createWelcomeWin.minSize = new Vector2(610, 750);
        }

        static SDKWelcomeEditorWin()
        {
            EditorApplication.delayCall += CheckAWInstance;
        }

        static void CheckAWInstance()
        {
            AssetWarehouse.OnReady(() =>
            {
                if (AssetWarehouse.Instance != null && AssetWarehouse.Instance.WorkingPallets.Count < 1)
                {
                    EditorApplication.delayCall += ShowWindowAutomatically;
                }
            });
        }

        static void ShowWindowAutomatically()
        {
            ShowSDKWelcomeWindowEditor();
        }

        void OnFocus()
        {
            LoadGamePath();
        }

        private void OnEnable()
        {
            LoadGamePath();
        }

        private void OnLostFocus()
        {
            LoadGamePath();
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("be4a3c691b13bc245a7b2f1b94fec3cf");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            welcomeInstallPathLabel = tree.Q<Label>("welcomeInstallPathLabel");
            gameName = MarrowSDK.GAME_NAMES[0];
            string assetWarehouseIconPath = MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse");
            LoadGamePath();
            VisualElement welcomeHeaderImageContainer = tree.Q<VisualElement>("welcomeHeaderImageContainer");
            Image welcomeHeaderImage = new Image
            {
                image = EditorGUIUtility.Load(Path.Combine(assetWarehouseIconPath, "skeleboy-bigger.png")) as Texture2D
            };
            welcomeHeaderImageContainer.Add(welcomeHeaderImage);
            welcomeHeaderImage.StretchToParentSize();
            Image palletInfoImage = tree.Q<Image>("palletInfoImage");
            Texture2D palletIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet.png"));
            if (palletIcon != null)
            {
                palletInfoImage.image = palletIcon;
                palletInfoImage.StretchToParentSize();
                palletInfoImage.style.position = Position.Relative;
            }

            Image crateInfoImage = tree.Q<Image>("crateInfoImage");
            Texture2D crateIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate.png"));
            if (palletIcon != null)
            {
                crateInfoImage.image = crateIcon;
                crateInfoImage.StretchToParentSize();
                crateInfoImage.style.position = Position.Relative;
            }

            Image dataCardInfoImage = tree.Q<Image>("dataCardInfoImage");
            Texture2D dataCardIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/datacard.png"));
            if (palletIcon != null)
            {
                dataCardInfoImage.image = dataCardIcon;
                dataCardInfoImage.StretchToParentSize();
                dataCardInfoImage.style.position = Position.Relative;
            }

            Button welcomeVerifyInstallButton = tree.Q<Button>("welcomeVerifyInstallButton");
            Texture2D folderIcon = (Texture2D)EditorGUIUtility.IconContent("d_folderopened icon").image;
            if (folderIcon != null)
            {
                welcomeVerifyInstallButton.text = "";
                Image welcomeVerifyInstallImage = new Image
                {
                    image = folderIcon
                };
                welcomeVerifyInstallImage.AddToClassList("linkCursor");
                welcomeVerifyInstallButton.Add(welcomeVerifyInstallImage);
                welcomeVerifyInstallImage.StretchToParentSize();
            }

            welcomeVerifyInstallButton.clickable.clicked += () =>
            {
                GameInstallDirectoryEditorWindow.ShowGameInstallDirWindowEditor();
            };
            Label welcomeVerifyInstallLabel = tree.Q<Label>("welcomeVerifyInstallLabel");
            welcomeVerifyInstallLabel.text = welcomeVerifyInstallLabel.text.Replace("game install", gameName + " install");
            welcomeVerifyInstallLabel.text = welcomeVerifyInstallLabel.text.Replace("game Content Pallet", gameName + " Content Pallet");
            Button welcomeAssetWarehouseButton = tree.Q<Button>("welcomeAssetWarehouseButton");
            Texture2D awIcon = EditorGUIUtility.Load(Path.Combine(assetWarehouseIconPath, "hunter.png")) as Texture2D;
            if (awIcon != null)
            {
                welcomeAssetWarehouseButton.text = "";
                Image welcomeAssetWarehouseIconImage = new Image
                {
                    image = awIcon
                };
                welcomeAssetWarehouseIconImage.AddToClassList("linkCursor");
                welcomeAssetWarehouseButton.Add(welcomeAssetWarehouseIconImage);
            }

            welcomeAssetWarehouseButton.clickable.clicked += () =>
            {
                AssetWarehouseWindow.ShowWindow();
            };
            var welcomeCreatePalletImage = tree.Q<Image>("welcomeCreatePalletImage");
            Texture2D palletCrateIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/pallet-add-big.png"));
            if (palletCrateIcon != null)
            {
                welcomeCreatePalletImage.image = palletCrateIcon;
            }

            var welcomeSelectPalletImage = tree.Q<Image>("welcomeSelectPalletImage");
            if (palletIcon != null)
            {
                welcomeSelectPalletImage.image = palletIcon;
            }

            var welcomeLevelCrateImage = tree.Q<Image>("welcomeLevelCrateImage");
            Texture2D levelCrateIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/crate-level.png"));
            if (levelCrateIcon != null)
            {
                welcomeLevelCrateImage.image = levelCrateIcon;
            }

            var welcomePackPalletImage = tree.Q<Image>("welcomePackPalletImage");
            Texture2D packedPalletIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/packed-pallet-small.png"));
            if (levelCrateIcon != null)
            {
                welcomePackPalletImage.image = packedPalletIcon;
            }

            Button welcomeMarrowDocsButton = tree.Q<Button>("welcomeMarrowDocsButton");
            welcomeMarrowDocsButton.clickable.clicked += () =>
            {
                SDKDocsEditorWin.ShowSDKDocsWindowEditor();
            };
            Button welcomeMarrowWikiButton = tree.Q<Button>("welcomeMarrowWikiButton");
            welcomeMarrowWikiButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://github.com/StressLevelZero/MarrowSDK/wiki");
            };
            Button welcomeLavaGangDiscordButton = tree.Q<Button>("welcomeLavaGangDiscordButton");
            welcomeLavaGangDiscordButton.clickable.clicked += () =>
            {
                Application.OpenURL("https://discord.com/invite/j4zM7Ntd9B");
            };
            rootVisualElement.Add(tree);
        }

        private void AutoDiscoverDefaultPath()
        {
            DirectoryInfo gamePathOculus = new DirectoryInfo($"C:/Program Files/Oculus/Software/Software/stress-level-zero-inc-bonelab/{gameName}_Oculus_Windows64_Data");
            DirectoryInfo gamePathSteam = new DirectoryInfo($"C:/Program Files (x86)/Steam/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            DirectoryInfo gamePathSteam2 = new DirectoryInfo($"D:/SteamLibrary/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            DirectoryInfo gamePathSteam3 = new DirectoryInfo($"D:/Games/SteamLibrary/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            foundGamePaths.Clear();
            if (!string.IsNullOrEmpty(GetGameInstallPath()) && Directory.Exists(GetGameInstallPath()))
            {
                DirectoryInfo currentValidPath = new DirectoryInfo(GetGameInstallPath());
                foundGamePaths.Add(currentValidPath.FullName);
            }

            if (Directory.Exists(gamePathOculus.FullName) && !foundGamePaths.Contains(gamePathOculus.FullName))
            {
                foundGamePaths.Add(gamePathOculus.FullName);
            }

            if (Directory.Exists(gamePathSteam.FullName) && !foundGamePaths.Contains(gamePathSteam.FullName))
            {
                foundGamePaths.Add(gamePathSteam.FullName);
            }

            if (Directory.Exists(gamePathSteam2.FullName) && !foundGamePaths.Contains(gamePathSteam2.FullName))
            {
                foundGamePaths.Add(gamePathSteam2.FullName);
            }

            if (Directory.Exists(gamePathSteam3.FullName) && !foundGamePaths.Contains(gamePathSteam3.FullName))
            {
                foundGamePaths.Add(gamePathSteam3.FullName);
            }

            if (foundGamePaths.Count > 0 && string.IsNullOrEmpty(GetGameInstallPath()))
            {
                SetGamePath(foundGamePaths[0]);
                LoadGamePath();
            }

            if (foundGamePaths.Count == 0)
            {
                GameInstallDirectoryEditorWindow.ShowGameInstallDirWindowEditor();
            }
        }

        private void SetGamePath(string gamePath)
        {
            gamePath = gamePath.Replace("\\", "/");
            bool changed = false;
            SDKProjectPreferences.LoadFromFile();
            if (SDKProjectPreferences.MarrowGameInstallPaths.Count <= 0)
            {
                SDKProjectPreferences.MarrowGameInstallPaths.Add(gamePath);
                changed = true;
            }
            else
            {
                if (SDKProjectPreferences.MarrowGameInstallPaths[0] != gamePath)
                {
                    SDKProjectPreferences.MarrowGameInstallPaths[0] = gamePath;
                    changed = true;
                }
            }

            if (changed)
                SDKProjectPreferences.SaveToFile();
        }

        private string GetGameInstallPath()
        {
            if (SDKProjectPreferences.MarrowGameInstallPaths != null && SDKProjectPreferences.MarrowGameInstallPaths.Count > 0)
            {
                return SDKProjectPreferences.MarrowGameInstallPaths[0];
            }
            else
            {
                return string.Empty;
            }
        }

        private void LoadGamePath()
        {
            SDKProjectPreferences.LoadFromFile();
            if (string.IsNullOrEmpty(gameName))
                gameName = MarrowSDK.GAME_NAMES[0];
            if (welcomeInstallPathLabel != null)
            {
                if (string.IsNullOrEmpty(GetGameInstallPath()))
                {
                    welcomeInstallPathLabel.text = "Not found";
                    AutoDiscoverDefaultPath();
                }
                else
                {
                    welcomeInstallPathLabel.text = $"{GetGameInstallPath()}";
                }
            }
        }
    }
}
#endif
