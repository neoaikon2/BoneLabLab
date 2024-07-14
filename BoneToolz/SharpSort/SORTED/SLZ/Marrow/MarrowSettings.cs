using System.Collections.Generic;
using System.IO;
using SLZ.Marrow.Warehouse;
using UnityEngine;
 
 
 
using Newtonsoft.Json.Linq;
 
using SLZ.Serialize;
 
#if UNITY_EDITOR
using UnityEditor;

 

 

#endif
namespace SLZ.Marrow
{
    public class MarrowSettings : ScriptableObject, IPackable, IPackedAssets
    {
        [SerializeField]
        private string _gameTitle;
        public string GameTitle { get => _gameTitle; set => _gameTitle = value; }

        [SerializeField]
        [Tooltip("Content for this Marrow Game")]
        private List<PalletReference> _gamePallets;
        public List<PalletReference> GamePallets { get => _gamePallets; private set => _gamePallets = value; }

        [SerializeField]
        [Tooltip("Individual Content for this Marrow Game")]
        private List<PalletReference> _standalonePallets = new List<PalletReference>();
        public List<PalletReference> StandalonePallets { get => _standalonePallets; private set => _standalonePallets = value; }

        [SerializeField]
        private DataCardReference<BoneTag> _playerTag;
        public DataCardReference<BoneTag> PlayerTag { get => _playerTag; private set => _playerTag = value; }

        [SerializeField]
        private DataCardReference<BoneTag> _beingTag;
        public DataCardReference<BoneTag> BeingTag { get => _beingTag; private set => _beingTag = value; }

        private static MarrowSettings _runtimeInstance;
        public static MarrowSettings RuntimeInstance
        {
            get
            {
                if (_runtimeInstance == null)
                {
#if UNITY_EDITOR
                    if (!Application.isPlaying)
                    {
                        _runtimeInstance = GetOrCreateEditorSettings();
                    }
#endif
                }

                return _runtimeInstance;
            }
        }

        private List<PackedAsset> _packedAssets = new List<PackedAsset>();
        public List<PackedAsset> PackedAssets { get => _packedAssets; }

        public void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.MarrowSettings.ImportPackedAssets(System.Collections.Generic.Dictionary<string, SLZ.Marrow.Warehouse.PackedAsset>)");
            throw new System.NotImplementedException();
        }

        public List<PackedAsset> ExportPackedAssets()
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.MarrowSettings.ExportPackedAssets()");
            throw new System.NotImplementedException();
        }

        public virtual void Pack(ObjectStore store, JObject json)
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.MarrowSettings.Pack(SLZ.Serialize.ObjectStore, Newtonsoft.Json.Linq.JObject)");
            throw new System.NotImplementedException();
        }

        public virtual void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("gameTitle", objectId, out JToken gameTitleValue))
            {
                GameTitle = gameTitleValue.ToObject<string>();
            }

            if (store.TryGetJSON("gamePallets", objectId, out JToken gamePalletsValue))
            {
                JArray arr = (JArray)gamePalletsValue;
                GamePallets = new List<PalletReference>();
                foreach (var gamePalletValue in arr)
                {
                    GamePallets.Add(new PalletReference(gamePalletValue.ToObject<string>()));
                }
            }

            if (store.TryGetJSON("standalonePallets", objectId, out JToken standalonePalletsValue))
            {
                JArray arr = (JArray)standalonePalletsValue;
                StandalonePallets = new List<PalletReference>();
                foreach (var standalonePalletValue in arr)
                {
                    StandalonePallets.Add(new PalletReference(standalonePalletValue.ToObject<string>()));
                }
            }
        }

#if UNITY_EDITOR
        public void GeneratePackedAssets(bool saveAsset = true)
        {
            UnityEngine.Debug.Log("Hollowed Method: SLZ.Marrow.MarrowSettings.GeneratePackedAssets(bool)");
            throw new System.NotImplementedException();
        }

        public const string SETTINGS_FILE_NAME = "MarrowSettings.asset";
        private static string _settingsFilePath = "";
        public static string SettingsFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(_settingsFilePath))
                {
                    _settingsFilePath = MarrowSDK.GetMarrowAssetsPath("Settings", SETTINGS_FILE_NAME);
                }

                return _settingsFilePath;
            }
        }

        private static MarrowSettings GetOrCreateEditorSettings()
        {
            var settings = AssetDatabase.LoadAssetAtPath<MarrowSettings>(SettingsFilePath);
            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<MarrowSettings>();
                if (!Directory.Exists(MarrowSDK.GetMarrowAssetsPath()))
                    AssetDatabase.CreateFolder("Assets", MarrowSDK.EDITOR_ASSETS_FOLDER);
                if (!Directory.Exists(MarrowSDK.GetMarrowAssetsPath("Settings")))
                    AssetDatabase.CreateFolder(MarrowSDK.GetMarrowAssetsPath(), "Settings");
                settings.SetDefaults();
                AssetDatabase.CreateAsset(settings, SettingsFilePath);
                AssetDatabase.SaveAssets();
            }

            return settings;
        }

        private void SetDefaults()
        {
            PlayerTag = new BoneTagReference("SLZ.Marrow.BoneTag.Player");
            BeingTag = new BoneTagReference("SLZ.Marrow.BoneTag.Being");
        }
#endif
    }
}