#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using SLZ.Marrow;
using UnityEngine;

 

namespace SLZ.MarrowEditor
{
    public static class SDKProjectPreferences
    {
        private class SerializedPreferences
        {
            public List<string> _marrowGameInstallPaths = new List<string>();
            public bool _loadMarrowGames = false;
        }

        private static SerializedPreferences _instance = null;
        private static string preferencesPath = MarrowSDK.GetLibraryPath("SDKPreferences.json");
        public static List<string> MarrowGameInstallPaths
        {
            get
            {
                return _instance._marrowGameInstallPaths;
            }
        }

        public static bool LoadMarrowGames
        {
            get
            {
                return _instance._loadMarrowGames;
            }

            set
            {
                _instance._loadMarrowGames = value;
            }
        }

        public static void LoadFromFile()
        {
            if (!File.Exists(preferencesPath))
            {
                CreateFile();
            }

            string json = File.ReadAllText(preferencesPath);
            _instance = JsonUtility.FromJson<SerializedPreferences>(json);
        }

        public static void SaveToFile()
        {
            string json = JsonUtility.ToJson(_instance, true);
            File.WriteAllText(preferencesPath, json);
        }

        private static void CreateFile()
        {
            if (!Directory.Exists(Path.GetDirectoryName(preferencesPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(preferencesPath));
            }

            _instance = new SerializedPreferences();
#if false
#endif
#if true
            _instance._loadMarrowGames = true;
#endif
            SaveToFile();
        }
    }
}
#endif
