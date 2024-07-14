 
 
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Utilities;
using SLZ.Serialize;
using UnityEngine;
 
#if UNITY_EDITOR
using UnityEditor;

#endif
namespace SLZ.Marrow.Warehouse
{
    public interface IReadOnlyScannable
    {
        Barcode Barcode { get; }

        string Title { get; }

        string Description { get; }
    }

    public interface IScannable : IReadOnlyScannable, IPackable, IPackedAssets
    {
        bool Unlockable { get; }

        bool Redacted { get; }

        void GenerateBarcode(bool forceGeneration = false);
        void GenerateBarcodeInternal(bool forceGeneration = false);
    }

    public interface IPackedAssets
    {
        public List<PackedAsset> PackedAssets { get; }

        void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets);
        List<PackedAsset> ExportPackedAssets();
#if UNITY_EDITOR
        void GeneratePackedAssets(bool saveAsset = true);
#endif
    }

    public abstract class Scannable : ScriptableObject, IScannable
    {
        [SerializeField]
        private Barcode _barcode;
        public Barcode Barcode
        {
            get
            {
                return _barcode;
            }

            set
            {
                _barcode = value;
            }
        }

        [SerializeField]
        private Barcode _barcodeOld;
        public Barcode BarcodeOld
        {
            get
            {
                return _barcodeOld;
            }

            set
            {
                _barcodeOld = value;
            }
        }

        [SerializeField]
        private MarrowGuid _slimCode;
        public MarrowGuid SlimCode
        {
            get
            {
                return _slimCode;
            }

            set
            {
                _slimCode = value;
            }
        }

        [SerializeField]
        [Delayed]
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        [SerializeField]
        [Delayed]
        private string _description = "";
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        [SerializeField]
        [Tooltip("Locks the crate from the user until it is unlocked")]
        private bool _unlockable = false;
        public bool Unlockable
        {
            get
            {
                return _unlockable;
            }

            set
            {
                _unlockable = value;
            }
        }

        [SerializeField]
        [Tooltip("Hides the crate from Menus")]
        private bool _redacted = false;
        public bool Redacted
        {
            get
            {
                return _redacted;
            }

            set
            {
                _redacted = value;
            }
        }

        public void GenerateBarcode(bool forceGeneration = false)
        {
            if (Barcode == null || !Barcode.IsValid())
            {
                Barcode = new Barcode();
            }

            GenerateBarcodeInternal(forceGeneration);
        }

        public abstract void GenerateBarcodeInternal(bool forceGeneration = false);
        private List<PackedAsset> _packedAssets = new List<PackedAsset>();
        public List<PackedAsset> PackedAssets { get => _packedAssets; }

        public virtual void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
        {
            PackedAssets.Clear();
            foreach (var kvp in packedAssets)
            {
                PackedAssets.Add(kvp.Value);
            }
        }

        public virtual List<PackedAsset> ExportPackedAssets()
        {
            PackedAssets.Clear();
            return PackedAssets;
        }

        public virtual void Pack(ObjectStore store, JObject json)
        {
            json.Add("barcode", Barcode.ID);
            if (Barcode.IsValid(BarcodeOld))
                json.Add("barcodeOld", BarcodeOld.ID);
            if (SlimCode.IsValid())
                json.Add("slimCode", SlimCode.ToHexString());
            json.Add("title", Title);
            json.Add("description", Description);
            json.Add("unlockable", Unlockable);
            json.Add("redacted", Redacted);
            PackJsonPackedAssets(json);
        }

        public virtual void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("barcode", objectId, out JToken barcodeValue))
            {
                Barcode = new Barcode(barcodeValue.ToObject<string>());
            }

            if (store.TryGetJSON("barcodeOld", objectId, out JToken barcodeOldValue) && Barcode.IsValid(barcodeOldValue.ToObject<string>()))
            {
                BarcodeOld = new Barcode(barcodeOldValue.ToObject<string>());
            }

            if (store.TryGetJSON("slimCode", objectId, out JToken slimCodeValue))
            {
                SlimCode = new MarrowGuid(slimCodeValue.ToString());
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

            UnpackJsonPackedAssets(store, objectId);
        }

        public void PackJsonPackedAssets(JObject json)
        {
            ExportPackedAssets();
            var packedAssetsArray = new JArray();
            foreach (var packedAsset in PackedAssets)
            {
                var packedAssetJObject = new JObject
                {
                    {
                        "title",
                        packedAsset.title
                    },
                };
                if (packedAsset.marrowAsset != null)
                {
                    packedAssetJObject.Add(new JProperty("guid", packedAsset.marrowAsset.AssetGUID));
                }

                if (packedAsset.HasSubAssets())
                {
                    packedAssetJObject.Add(new JProperty("subAssets", new JArray(packedAsset.subAssets.Select(p => p.subAsset.AssetGUID))));
                }

                if (packedAsset.marrowAsset != null || packedAsset.subAssets.Count > 0)
                    packedAssetsArray.Add(packedAssetJObject);
            }

            json.Add(new JProperty("packedAssets", packedAssetsArray));
        }

        public void UnpackJsonPackedAssets(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("packedAssets", objectId, out JToken packedAssetsValue))
            {
                var packedAssets = new Dictionary<string, PackedAsset>();
                foreach (var arrayToken in (JArray)packedAssetsValue)
                {
                    if (((JObject)arrayToken).TryGetValue("title", out var titleToken))
                    {
                        var packedAsset = new PackedAsset();
                        packedAsset.title = titleToken.ToObject<string>();
                        if (((JObject)arrayToken).TryGetValue("guid", out var guidToken))
                        {
                            packedAsset.marrowAsset = new MarrowAsset(guidToken.ToObject<string>());
                            packedAsset.assetType = typeof(UnityEngine.Object);
                        }

                        if (((JObject)arrayToken).TryGetValue("subAssets", out var subAssetsToken))
                        {
                            List<PackedSubAsset> subAssets = new List<PackedSubAsset>();
                            for (var i = 0; i < ((JArray)subAssetsToken).Count; i++)
                            {
                                var subAssetToken = ((JArray)subAssetsToken)[i];
                                subAssets.Add(new PackedSubAsset($"{i}", new MarrowAsset(subAssetToken.ToObject<string>())));
                            }

                            packedAsset.subAssets = subAssets;
                        }

                        if ((packedAsset.marrowAsset != null || packedAsset.HasSubAssets()) && !packedAssets.ContainsKey(packedAsset.title))
                        {
                            packedAssets[packedAsset.title] = packedAsset;
                        }
                    }
                }

                ImportPackedAssets(packedAssets);
            }
        }

#if UNITY_EDITOR
        public virtual void GeneratePackedAssets(bool saveAsset = true)
        {
        }

        [ContextMenu("Generate Barcode")]
        private void GenerateBarcodeMenuButton()
        {
            GenerateBarcode(true);
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssetIfDirty(this);
        }

        [ContextMenu("Archive Barcode")]
        private void ArchiveBarcodeMenuButton()
        {
            BarcodeOld = Barcode;
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssetIfDirty(this);
        }

        [ContextMenu("Generate Slimcode")]
        private void GenerateSlimCode()
        {
            var generatedCode = SlimCode;
            generatedCode.GenerateGuid();
            SlimCode = generatedCode;
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssetIfDirty(this);
        }

        public virtual string GetAssetFilename()
        {
            return $"{GetAssetFilenameTitle()}.{GetFullAssetExtension()}";
        }

        public virtual string GetAssetFilenameTitle()
        {
            return Title.Replace(".", "");
        }

        public virtual string GetAssetExtension()
        {
            string typeNameShort = string.Empty;
            foreach (var c in GetType().Name)
            {
                if (char.IsUpper(c))
                    typeNameShort += c;
            }

            typeNameShort = typeNameShort.ToLower();
            return typeNameShort;
        }

        public string GetFullAssetExtension()
        {
            return $"{GetAssetExtension()}.asset";
        }

        public string GetNameNoExtension()
        {
            return name.Replace($".{GetAssetExtension()}", "");
        }
#endif
    }
}