using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using Object = UnityEngine.Object;

namespace SLZ.Marrow.Warehouse
{
    public interface ICrate
    {
        MarrowAsset MainAsset { get; set; }

        Type AssetType { get; }
    }

    public abstract class Crate : Scannable, ICrate
    {
        public virtual MarrowAsset MainAsset { get; set; }

        public virtual Type AssetType
        {
            get
            {
                return typeof(UnityEngine.Object);
            }
        }

        [NonSerialized]
        private Pallet _pallet = null;
        public Pallet Pallet
        {
            get
            {
                return _pallet;
            }

            set
            {
                _pallet = value;
            }
        }

        [SerializeField]
        [Delayed]
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

        [SerializeField]
        private TagList _boneTags = new TagList();
        public TagList BoneTags { get => _boneTags; set => _boneTags = value; }

        private static Dictionary<Type, string> _crateNames = new Dictionary<Type, string>();
        public static Dictionary<Type, string> CrateNames
        {
            get
            {
                return _crateNames;
            }
        }

        public static string GetCrateName(Type crateType)
        {
            if (!CrateNames.TryGetValue(crateType, out var crateName))
            {
                crateName = crateType.Name.Replace("Crate", "");
                CrateNames[crateType] = crateName;
            }

            return crateName;
        }

        public override void GenerateBarcodeInternal(bool forceGeneration = false)
        {
            Barcode.GenerateID(forceGeneration, Pallet.Barcode.ID, GetCrateName(this.GetType()), Title.Replace(".", ""));
        }

        public virtual async UniTask<Object> LoadAssetAsync()
        {
            return await MainAsset.LoadAssetAsync<Object>();
        }

        public virtual void LoadAsset(Action<Object> loadCallback)
        {
            MainAsset.LoadAsset(loadCallback);
        }

        public override void Pack(ObjectStore store, JObject json)
        {
            base.Pack(store, json);
            json.Add("mainAsset", MainAsset.AssetGUID);
            json.Add(new JProperty("tags", new JArray(Tags)));
        }

        public override void Unpack(ObjectStore store, string objectId)
        {
            base.Unpack(store, objectId);
            if (store.TryGetJSON("mainAsset", objectId, out JToken marrowAssetValue))
            {
                MainAsset = new MarrowAsset(marrowAssetValue.ToObject<string>());
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
        }

        public static Crate CreateCrate(System.Type type, Pallet pallet, string title, MarrowAsset marrowAsset, bool generateBarcode = true)
        {
            Crate crate = null;
            if (type == typeof(SpawnableCrate) || type == typeof(LevelCrate) || type == typeof(AvatarCrate) || type == typeof(VFXCrate))
            {
                crate = (Crate)ScriptableObject.CreateInstance(type);
                crate.Title = title;
                crate.Pallet = pallet;
                crate.MainAsset = marrowAsset;
                if (generateBarcode)
                {
                    crate.GenerateBarcode();
                    crate.SlimCode.GenerateGuid();
                }
            }

            return crate;
        }

        public static T CreateCrateT<T>(Pallet pallet, string title, MarrowAsset marrowAsset, bool generateBarcode = true)
            where T : Crate
        {
            return (T)CreateCrate(typeof(T), pallet, title, marrowAsset, generateBarcode);
        }
    }

    public abstract class CrateT<T> : Crate where T : UnityEngine.Object
    {
        public override Type AssetType
        {
            get
            {
                return typeof(T);
            }
        }

        public new async UniTask<T> LoadAssetAsync()
        {
            try
            {
                return await MainAsset.LoadAssetAsync<T>();
            }
            catch (Exception e)
            {
                Debug.LogError($"AssetWarehouse: Failed to load MainAsset from Crate({this.GetType().Name}) \"{Pallet.Title}:{Title}\"");
                throw e;
            }
        }

        public void LoadAsset(Action<T> loadCallback)
        {
            MainAsset.LoadAsset(loadCallback);
        }
    }
}