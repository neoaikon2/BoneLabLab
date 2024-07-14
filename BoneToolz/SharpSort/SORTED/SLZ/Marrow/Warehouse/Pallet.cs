using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
 
#if UNITY_EDITOR
using UnityEditor;

#endif
namespace SLZ.Marrow.Warehouse
{
    public partial class Pallet : Scannable, ISerializationCallbackReceiver
    {
        [SerializeField]
        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        [SerializeField]
        private string _version = "0.0.0";
        public string Version
        {
            get
            {
                return _version;
            }

            set
            {
                _version = value;
            }
        }

        [SerializeField]
        private string _sdkVersion = MarrowSDK.SDK_VERSION;
        public string SDKVersion
        {
            get
            {
                return _sdkVersion;
            }

            set
            {
                _sdkVersion = value;
            }
        }

        [SerializeField]
        [Tooltip("NO LONGER USED")]
        private bool _internal = false;
        public bool Internal
        {
            [Obsolete("Use Pallet.IsInMarrowGame()")]
            get
            {
                return _internal;
            }

            set
            {
                _internal = value;
            }
        }

        [SerializeField]
        private List<Crate> _crates = new List<Crate>();
        public List<Crate> Crates
        {
            get
            {
                return _crates;
            }

            set
            {
                _crates = value;
            }
        }

        [SerializeField]
        private List<DataCard> _dataCards = new List<DataCard>();
        public List<DataCard> DataCards
        {
            get
            {
                return _dataCards;
            }

            set
            {
                _dataCards = value;
            }
        }

        [SerializeField]
        private List<string> _tags = new List<string>();
        public List<string> Tags
        {
            get
            {
                return _tags;
            }

            set
            {
                _tags = value;
            }
        }

        [System.Serializable]
        public struct ChangeLog
        {
            public string version;
            public string title;
            [TextArea(4, 20)]
            public string text;
            [Newtonsoft.Json.JsonConstructor]
            public ChangeLog(string version, string title, string text)
            {
                this.version = version;
                this.title = title;
                this.text = text;
            }
        }

        [SerializeField]
        private List<ChangeLog> _changeLogs = new List<ChangeLog>();
        public List<ChangeLog> ChangeLogs
        {
            get
            {
                return _changeLogs;
            }
        }

#if UNITY_EDITOR
        [SerializeField]
        private List<string> _crateTitles = new List<string>();
        [SerializeField]
        private List<string> _datacardTitles = new List<string>();
#endif
        public static readonly string PALLET_JSON_FILENAME = "pallet.json";
        public override void GenerateBarcodeInternal(bool forceGeneration = false)
        {
            Barcode.GenerateID(forceGeneration, Author, Title.Replace(".", ""));
            foreach (var crate in Crates)
            {
                crate.GenerateBarcode(true);
            }
        }

        public void GetScannables(ref List<Scannable> scannables)
        {
            scannables.Clear();
            scannables.AddRange(Crates);
            scannables.AddRange(DataCards);
        }

        [SerializeField]
        private List<PalletReference> _palletDependencies = new List<PalletReference>();
        public List<PalletReference> PalletDependencies
        {
            get
            {
                return _palletDependencies;
            }
        }

        public override void Pack(ObjectStore store, JObject json)
        {
            json.Add("barcode", Barcode.ID);
            if (Barcode.IsValid(BarcodeOld))
                json.Add("barcodeOld", BarcodeOld.ID);
            json.Add("title", Title);
            json.Add("description", Description);
            json.Add("unlockable", Unlockable);
            json.Add("redacted", Redacted);
            json.Add("author", Author);
            json.Add("version", Version);
            json.Add("sdkVersion", SDKVersion);
            json.Add("internal", Internal);
            var jsonCrateArray = new JArray();
            foreach (var crate in Crates)
            {
                if (crate != null)
                {
                    jsonCrateArray.Add(store.PackReference(crate));
                }
            }

            json.Add(new JProperty("crates", jsonCrateArray));
            var jsonDataCardArray = new JArray();
            foreach (var dataCard in DataCards)
            {
                if (dataCard != null)
                {
                    jsonDataCardArray.Add(store.PackReference(dataCard));
                }
            }

            json.Add(new JProperty("dataCards", jsonDataCardArray));
            json.Add(new JProperty("tags", new JArray(Tags)));
            var changelogArray = new JArray();
            foreach (var changelog in ChangeLogs)
            {
                JObject logObject = new JObject();
                logObject.Add("version", changelog.version);
                logObject.Add("title", changelog.title);
                logObject.Add("text", changelog.text);
                changelogArray.Add(logObject);
            }

            json.Add(new JProperty("changelogs", changelogArray));
        }

        public override void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("barcode", objectId, out JToken barcodeValue))
            {
                Barcode = new Barcode(barcodeValue.ToObject<string>());
            }

            if (store.TryGetJSON("barcodeOld", objectId, out JToken barcodeOldValue) && Barcode.IsValid(barcodeOldValue.ToObject<string>()))
            {
                BarcodeOld = new Barcode(barcodeOldValue.ToObject<string>());
            }

            if (store.TryGetJSON("title", objectId, out JToken titleValue))
            {
                name = titleValue.ToObject<string>();
                Title = titleValue.ToObject<string>();
            }

            if (store.TryGetJSON("description", objectId, out JToken descValue))
            {
                Description = descValue.ToObject<string>();
            }

            if (store.TryGetJSON("unlockable", objectId, out JToken unlockValue))
            {
                Unlockable = unlockValue.ToObject<bool>();
            }

            if (store.TryGetJSON("redacted", objectId, out JToken redaValue))
            {
                Redacted = redaValue.ToObject<bool>();
            }

            if (store.TryGetJSON("author", objectId, out JToken authorValue))
            {
                Author = authorValue.ToObject<string>();
            }

            if (store.TryGetJSON("version", objectId, out JToken versionValue))
            {
                Version = versionValue.ToObject<string>();
            }

            if (store.TryGetJSON("sdkVersion", objectId, out JToken sdkVersionValue))
            {
                SDKVersion = sdkVersionValue.ToObject<string>();
            }

            if (store.TryGetJSON("internal", objectId, out JToken internalValue))
            {
                Internal = internalValue.ToObject<bool>();
            }

            if (store.TryGetJSON("crates", objectId, out JToken cratesValue))
            {
                JArray arr = (JArray)cratesValue;
                Crates = new List<Crate>();
                foreach (var crateValue in arr)
                {
                    store.TryCreateFromReference(crateValue, out Crate crate, t => Crate.CreateCrate(t, null, "", new MarrowAsset(), false));
                    crate.Pallet = this;
                    Crates.Add(crate);
                }
            }

            if (store.TryGetJSON("dataCards", objectId, out JToken dataCardsValue))
            {
                JArray arr = (JArray)dataCardsValue;
                DataCards = new List<DataCard>();
                foreach (var dataCardValue in arr)
                {
                    store.TryCreateFromReference(dataCardValue, out DataCard dataCard, t => DataCard.CreateDataCard(t, null, "", false));
                    dataCard.Pallet = this;
                    DataCards.Add(dataCard);
                }
            }

            if (store.TryGetJSON("tags", objectId, out JToken tagsValue))
            {
                JArray arr = (JArray)tagsValue;
                Tags = new List<string>();
                foreach (var tagValue in arr)
                {
                    Tags.Add(tagValue.ToObject<string>());
                }
            }

            if (store.TryGetJSON("changelogs", objectId, out JToken changeLogsValue))
            {
                JArray arr = (JArray)changeLogsValue;
                ChangeLogs.Clear();
                foreach (var changeLogValue in arr)
                {
                    string version = changeLogValue["version"].ToObject<string>();
                    string title = changeLogValue["title"].ToObject<string>();
                    string text = changeLogValue["text"].ToObject<string>();
                    ChangeLogs.Add(new ChangeLog(version, title, text));
                }
            }
        }

        public static Pallet CreatePallet(string title, string author, bool generateBarcode = true)
        {
            Pallet pallet = ScriptableObject.CreateInstance<Pallet>();
            pallet.Title = title;
            pallet.Author = author;
            if (generateBarcode)
            {
                pallet.GenerateBarcode();
            }

            return pallet;
        }

        public void OnBeforeSerialize()
        {
#if UNITY_EDITOR
            _crateTitles.Clear();
            foreach (var crate in Crates)
            {
                if (crate != null)
                    _crateTitles.Add($"{Crate.GetCrateName(crate.GetType())}  {crate.Title}");
            }

            _datacardTitles.Clear();
            foreach (var dataCard in DataCards)
            {
                if (dataCard != null)
                    _datacardTitles.Add($"{dataCard.GetType().Name}  {dataCard.Title}");
            }
#endif
        }

        public void OnAfterDeserialize()
        {
#if UNITY_EDITOR
#endif
        }

#if UNITY_EDITOR
        [ContextMenu("Save Json to File")]
        private void SaveJsonToAssetDatabase()
        {
            string palletPath = AssetDatabase.GetAssetPath(this);
            palletPath = System.IO.Path.GetDirectoryName(palletPath);
            string palletJsonPath = System.IO.Path.Combine(palletPath, "_Pallet_" + MarrowSDK.SanitizeName(this.Barcode) + ".json");
            PalletPacker.PackAndSaveToJson(this, palletJsonPath);
            AssetDatabase.Refresh();
        }

        [ContextMenu("Sort Contents")]
        public void SortCrates()
        {
            Crates.RemoveAll(item => item == null);
            Crates = Crates.OrderBy(crate => crate.GetType().Name).ThenBy(crate =>
            {
                var cratePath = AssetDatabase.GetAssetPath(crate);
                var crateFilename = System.IO.Path.GetFileName(cratePath);
                return crateFilename;
            }).ToList();
            DataCards.RemoveAll(item => item == null);
            DataCards = DataCards.OrderBy(dataCard => dataCard.GetType().Name).ThenBy(dataCard =>
            {
                var dataCardPath = AssetDatabase.GetAssetPath(dataCard);
                var dataCardFilename = System.IO.Path.GetFileName(dataCardPath);
                return dataCardFilename;
            }).ToList();
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        [ContextMenu("Fix Names")]
        public void FixNames()
        {
            AssetDatabase.StartAssetEditing();
            var palletItems = new List<Scannable>();
            palletItems.Add(this);
            palletItems.AddRange(Crates);
            palletItems.AddRange(DataCards);
            foreach (var scannable in palletItems)
            {
                string currentPath = AssetDatabase.GetAssetPath(scannable);
                string currentFileName = System.IO.Path.GetFileName(currentPath);
                string newFileName = scannable.GetAssetFilename();
                if (currentFileName.Substring(0, currentFileName.IndexOf('.')) != scannable.GetAssetFilenameTitle())
                    newFileName = $"{currentFileName.Substring(0, currentFileName.IndexOf('.'))}.{scannable.GetFullAssetExtension()}";
                if (!currentFileName.EndsWith(scannable.GetFullAssetExtension()))
                {
                    AssetDatabase.RenameAsset(currentPath, newFileName);
                }
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            AssetDatabase.StopAssetEditing();
        }

        public override string GetAssetExtension()
        {
            return "pallet";
        }

        public static string GetAssetExtensionStatic()
        {
            return "pallet";
        }

        public override string GetAssetFilename()
        {
            return $"_{base.GetAssetFilename()}";
        }
#endif
    }
}