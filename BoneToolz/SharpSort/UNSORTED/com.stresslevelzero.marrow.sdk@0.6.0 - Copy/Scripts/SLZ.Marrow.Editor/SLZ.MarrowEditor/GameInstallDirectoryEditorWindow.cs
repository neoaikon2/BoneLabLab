using UnityEditor;
using System.Linq;
using UnityEngine.UIElements;
using UnityEngine;
using System.IO;
using System;
using System.Collections.Generic;
using SLZ.Marrow;

#if UNITY_EDITOR
namespace SLZ.MarrowEditor
{
    public class GameInstallDirectoryEditorWindow : EditorWindow
    {
        private List<string> foundGamePaths = new List<string>();
        private List<string> foundSearchedPaths = new List<string>();
        private bool quickSearch = false;
        public Action<string> OnCloseWindow;
        private string gameName;
        private Label foundInLocationsLabel;
        private Label foundInLocationsHeaderLabel;
        private static int winHeightAdvClosed = 310;
        private int winHeightAddedAdvOpen = 165;
        private void OnDestroy()
        {
            var gamePath = LoadGamePath();
            OnCloseWindow?.Invoke(gamePath);
            if (SDKWelcomeEditorWin.createWelcomeWin)
            {
                SDKWelcomeEditorWin.createWelcomeWin.Focus();
            }
        }

        public static void ShowGameInstallDirWindowEditor(Action<string> onCloseWindowCallback = null)
        {
            GameInstallDirectoryEditorWindow gameInstallDirWin = GetWindow<GameInstallDirectoryEditorWindow>();
            gameInstallDirWin.titleContent = new GUIContent("Game Installation Locator");
            gameInstallDirWin.minSize = new Vector2(770, winHeightAdvClosed);
            if (onCloseWindowCallback != null)
                gameInstallDirWin.OnCloseWindow += onCloseWindowCallback;
        }

        public void CreateGUI()
        {
            string VISUALTREE_PATH = AssetDatabase.GUIDToAssetPath("55c01d9138366234088eb53daeedf9b5");
            var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(VISUALTREE_PATH);
            VisualElement tree = visualTree.Instantiate();
            tree.StretchToParentSize();
            rootVisualElement.Add(tree);
            Button doneButton = tree.Q<Button>("doneButton");
            doneButton.clicked += Close;
            gameName = MarrowSDK.GAME_NAMES[0];
            foundInLocationsHeaderLabel = tree.Q<Label>("foundInLocationsHeaderLabel");
            foundInLocationsLabel = tree.Q<Label>("foundInLocationsLabel");
            VisualElement gameInstallRefreshImageContainer = tree.Q<VisualElement>("gameInstallRefreshImageContainer");
            Image gameInstallRefreshImage = new Image
            {
                image = EditorGUIUtility.Load(MarrowSDK.GetPackagePath("Editor/Assets/Icons/Warehouse/hunter-reload.png")) as Texture2D
            };
            gameInstallRefreshImageContainer.Add(gameInstallRefreshImage);
            gameInstallRefreshImage.StretchToParentSize();
            Label instructionsLabel = tree.Q<Label>("instructionsLabel");
            instructionsLabel.text = instructionsLabel.text.Replace("game install location", gameName + " install location");
            instructionsLabel.text = instructionsLabel.text.Replace("game Content Pallet", gameName + " Content Pallet");
            LoadGamePath();
            Foldout advancedOptionsFoldout = tree.Q<Foldout>("advancedOptionsFoldout");
            advancedOptionsFoldout.text = advancedOptionsFoldout.text.Insert(advancedOptionsFoldout.text.IndexOf(" game install"), " " + gameName);
            advancedOptionsFoldout.RegisterValueChangedCallback(evt =>
            {
                Rect windowRect = position;
                if (advancedOptionsFoldout.value)
                {
                    if (windowRect.height != (winHeightAdvClosed + winHeightAddedAdvOpen))
                    {
                        windowRect.height = winHeightAdvClosed + winHeightAddedAdvOpen;
                        position = windowRect;
                    }
                }
                else
                {
                    if (windowRect.height != winHeightAdvClosed)
                    {
                        windowRect.height = winHeightAdvClosed;
                        position = windowRect;
                    }
                }
            });
            VisualElement multipleFoundInstructionsContainer = tree.Q<VisualElement>("multipleFoundInstructionsContainer");
            multipleFoundInstructionsContainer.style.display = DisplayStyle.None;
            ListView foundLocationsListView = tree.Q<ListView>("foundLocationsListView");
            foundLocationsListView.itemsSource = foundGamePaths;
            Func<VisualElement> makeItem = () =>
            {
                VisualElement element = new VisualElement();
                element.style.flexDirection = FlexDirection.Row;
                element.style.paddingLeft = EditorGUIUtility.singleLineHeight;
                Label pathLabel = new Label();
                pathLabel.name = "RowPathLabel";
                pathLabel.style.unityTextAlign = TextAnchor.MiddleCenter;
                pathLabel.style.fontSize = 12;
                element.Add(pathLabel);
                return element;
            };
            Action<VisualElement, int> bindItem = (e, i) =>
            {
                Label pathLabel = e.Q<Label>("RowPathLabel");
                string foundPath = foundGamePaths[i];
                if (!String.IsNullOrEmpty(foundPath))
                {
                    pathLabel.text = foundPath.Replace("\\", "/");
                }
                else
                {
                    pathLabel.text = "Unknown or Inaccessible Path";
                }
            };
            foundLocationsListView.onSelectionChange += objects =>
            {
                if (objects.Any())
                {
                    SetGamePath(foundGamePaths[foundLocationsListView.selectedIndex]);
                    LoadGamePath();
                    foundLocationsListView.Focus();
                }
            };
            foundLocationsListView.bindItem = bindItem;
            foundLocationsListView.makeItem = makeItem;
            Button searchGameFolderButton = tree.Q<Button>("searchGameFolderButton");
            searchGameFolderButton.text = $"Auto-Find {gameName}";
            searchGameFolderButton.clickable.clicked += () =>
            {
                if (EditorUtility.DisplayDialog("Perform exhaustive search?", "The Auto-Find process methodically searches all fixed hard drives looking for " + gameName + " install locations. This may take several minutes.", "Search", "Cancel"))
                {
                    FindGameOnClick();
                    if (foundSearchedPaths.Count == 1)
                    {
                        if (!foundGamePaths.Contains(foundSearchedPaths[0]))
                        {
                            foundGamePaths.Add(foundSearchedPaths[0]);
                        }
                    }
                    else
                    {
                        foreach (var foundPath in foundSearchedPaths)
                        {
                            if (!foundGamePaths.Contains(foundPath))
                            {
                                foundGamePaths.Add(foundPath);
                            }
                        }
                    }

                    foundLocationsListView?.Rebuild();
                    if (foundGamePaths.Count == 1)
                    {
                        foundLocationsListView.selectedIndex = 0;
                        SetGamePath(foundGamePaths[0]);
                        LoadGamePath();
                    }

                    if (foundGamePaths.Count > 1)
                    {
                        multipleFoundInstructionsContainer.style.display = DisplayStyle.Flex;
                    }
                    else
                    {
                        multipleFoundInstructionsContainer.style.display = DisplayStyle.None;
                    }
                }
            };
            Button searchGameManualButton = tree.Q<Button>("searchGameManualButton");
            searchGameManualButton.clickable.clicked += () =>
            {
                DirectoryInfo defaultSteamPath = new DirectoryInfo("C:/Program Files (x86)/Steam/steamapps/common/");
                var manualGameInstall = EditorUtility.OpenFolderPanel($"Locate {gameName} Install", defaultSteamPath.FullName, "");
                if (!String.IsNullOrEmpty(manualGameInstall))
                {
                    DirectoryInfo manualDir = new DirectoryInfo(manualGameInstall);
                    if (manualDir.FullName.ToLower().Contains($"{gameName.ToLower()}") && (!manualDir.FullName.ToLower().Contains($"{gameName.ToLower()}_steam_windows64_data") && !manualDir.FullName.ToLower().Contains($"{gameName.ToLower()}_oculus_windows64_data")))
                    {
                        if (Directory.Exists(Path.Combine(manualDir.FullName, $"{gameName}_Oculus_Windows64_Data")))
                        {
                            manualDir = new DirectoryInfo(Path.Combine(manualDir.FullName, $"{gameName}_Oculus_Windows64_Data"));
                        }
                        else if (Directory.Exists(Path.Combine(manualDir.FullName, $"{gameName}_Steam_Windows64_Data")))
                        {
                            manualDir = new DirectoryInfo(Path.Combine(manualDir.FullName, $"{gameName}_Steam_Windows64_Data"));
                        }
                    }

                    if (manualDir.FullName.Contains($"{gameName}_Steam_Windows64_Data") || manualDir.FullName.Contains($"{gameName}_Oculus_Windows64_Data"))
                    {
                        if (!foundGamePaths.Contains(manualDir.FullName))
                        {
                            foundGamePaths.Add(manualDir.FullName);
                            foundLocationsListView?.Rebuild();
                        }

                        foundLocationsListView.selectedIndex = foundGamePaths.IndexOf(manualDir.FullName);
                        foundLocationsListView.Focus();
                    }
                    else
                    {
                        Debug.LogError($"Selected folder did not contain a {gameName} installation.");
                    }
                }
            };
            DirectoryInfo gamePathOculus = new DirectoryInfo($"C:/Program Files/Oculus/Software/Software/stress-level-zero-inc-bonelab/{gameName}_Oculus_Windows64_Data");
            DirectoryInfo gamePathSteam = new DirectoryInfo($"C:/Program Files (x86)/Steam/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            DirectoryInfo gamePathSteam2 = new DirectoryInfo($"D:/SteamLibrary/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            DirectoryInfo gamePathSteam3 = new DirectoryInfo($"D:/Games/SteamLibrary/steamapps/common/{gameName}/{gameName}_Steam_Windows64_Data");
            foundGamePaths.Clear();
            var gamePath = LoadGamePath();
            if (!string.IsNullOrEmpty(gamePath) && Directory.Exists(gamePath))
            {
                DirectoryInfo currentValidPath = new DirectoryInfo(gamePath);
                foundGamePaths.Add(currentValidPath.FullName);
                foundLocationsListView.selectedIndex = 0;
                foundLocationsListView.Focus();
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

            foundLocationsListView?.Rebuild();
            if (foundGamePaths.Count == 1)
            {
                foundLocationsListView.selectedIndex = 0;
                foundLocationsListView.Focus();
            }

            if (foundGamePaths.Count > 1)
            {
                multipleFoundInstructionsContainer.style.display = DisplayStyle.Flex;
            }
            else
            {
                multipleFoundInstructionsContainer.style.display = DisplayStyle.None;
            }

            if (foundGamePaths.Count > 1 && string.IsNullOrEmpty(gamePath) && Directory.Exists(foundGamePaths[0]))
            {
                SetGamePath(foundGamePaths[0]);
                LoadGamePath();
            }
        }

        private void FindGameOnClick()
        {
            string gameName = MarrowSDK.GAME_NAMES[0];
            foundSearchedPaths.Clear();
            float progressBarStatus = 0f;
            int driveCount = 0;
            EditorUtility.DisplayCancelableProgressBar("Finding " + gameName + " Location", $"This may take a while...", progressBarStatus);
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                driveCount++;
                if (quickSearch && foundSearchedPaths.Count > 0)
                {
                    return;
                }

                if (drive.IsReady && drive.DriveType == DriveType.Fixed)
                {
                    try
                    {
                        string[] searchQueries =
                        {
                            $"{gameName}_Oculus_Windows64_Data",
                            $"{gameName}_Steam_Windows64_Data"};
                        string searchRoot = drive.Name;
                        var directories = SearchDirectories(searchRoot, searchQueries);
                        foreach (var foundDir in directories)
                        {
                            foundSearchedPaths.Add(foundDir);
                            if (quickSearch && foundSearchedPaths.Count > 0)
                            {
                                return;
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                progressBarStatus = driveCount / DriveInfo.GetDrives().Length;
            }
        }

        public static IEnumerable<string> SearchDirectories(string path, string[] searchPatterns)
        {
            return searchPatterns.AsParallel().SelectMany(searchPattern => Directory.EnumerateDirectories(path, searchPattern, new EnumerationOptions { IgnoreInaccessible = true, RecurseSubdirectories = true }));
        }

        private string LoadGamePath()
        {
            SDKProjectPreferences.LoadFromFile();
            var gameInstallPath = string.Empty;
            if (SDKProjectPreferences.MarrowGameInstallPaths != null && SDKProjectPreferences.MarrowGameInstallPaths.Count > 0)
            {
                gameInstallPath = SDKProjectPreferences.MarrowGameInstallPaths[0];
            }

            if (string.IsNullOrEmpty(gameName))
                gameName = MarrowSDK.GAME_NAMES[0];
            if (foundInLocationsLabel != null)
            {
                foundInLocationsHeaderLabel.text = $"{gameName} Install Folder: ";
                foundInLocationsLabel.text = $"{gameInstallPath}";
            }

            return gameInstallPath;
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
    }
}
#endif
