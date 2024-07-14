using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using SLZ.Marrow;

 

namespace SLZ.MarrowEditor
{
    public class ModBuilder
    {
        private static List<string> _gamePaths;
        public static List<string> GamePaths
        {
            get
            {
                if (_gamePaths == null)
                {
                    _gamePaths = new List<string>();
                    _gamePaths.AddRange(GamePathDictionary.Values);
                }

                return _gamePaths;
            }
        }

        private static Dictionary<string, string> _gamePathDictionary;
        public static Dictionary<string, string> GamePathDictionary
        {
            get
            {
                if (_gamePathDictionary == null)
                {
                    _gamePathDictionary = new Dictionary<string, string>();
                    string gamePathParent = System.IO.Directory.GetParent(System.IO.Directory.GetParent(UnityEngine.Application.persistentDataPath).ToString()).ToString();
                    foreach (var gameName in MarrowSDK.GAME_NAMES)
                    {
                        string gamePath = Path.Combine(gamePathParent, MarrowSDK.DEV_NAME, gameName);
                        if (System.IO.Directory.Exists(gamePath))
                            _gamePathDictionary.Add(gameName, gamePath);
                    }
                }

                return _gamePathDictionary;
            }

            set
            {
                _gamePathDictionary = value;
            }
        }

        public static bool InstallMod(string modFolderPath, string gameModsFolder)
        {
            bool success = true;
            if (Directory.Exists(modFolderPath))
            {
                if (!Directory.Exists(gameModsFolder))
                    Directory.CreateDirectory(gameModsFolder);
                string destModFolderPath = Path.Combine(gameModsFolder, Path.GetFileName(modFolderPath));
                if (Directory.Exists(destModFolderPath))
                    Directory.Delete(destModFolderPath, true);
                try
                {
                    var modDirectories = Directory.GetDirectories(modFolderPath, "*", SearchOption.AllDirectories);
                    foreach (string dir in modDirectories)
                    {
                        Directory.CreateDirectory(dir.Replace(modFolderPath, destModFolderPath));
                    }

                    var modFiles = Directory.GetFiles(modFolderPath, "*.*", SearchOption.AllDirectories);
                    foreach (string file in modFiles)
                    {
                        if (!Directory.Exists(file))
                        {
                            File.Copy(file, file.Replace(modFolderPath, destModFolderPath));
                        }
                    }

                    Debug.Log($"Copied {Path.GetFileName(modFolderPath)} pallet to {destModFolderPath}");
                }
                catch (Exception e)
                {
                    success = false;
                    Debug.LogError($"Failed to Copy {Path.GetFileName(modFolderPath)} pallet to {destModFolderPath}, Exception: ");
                    Debug.LogException(e);
                }
            }
            else
            {
                success = false;
                if (!Directory.Exists(modFolderPath))
                    Debug.LogError($"Mod folder missing at: {modFolderPath}");
            }

            return success;
        }
    }
}