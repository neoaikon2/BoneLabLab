using System;
 
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;
using SLZ.Serialize;
 
#if UNITY_EDITOR
using UnityEditor;

#endif
namespace SLZ.Marrow.Warehouse
{
    public abstract class DataCard : Scannable
    {
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
        private MarrowAssetT<DataCard> _dataCardAsset;
        public MarrowAssetT<DataCard> DataCardAsset
        {
            get
            {
                return _dataCardAsset;
            }

            set
            {
                _dataCardAsset = value;
            }
        }

        public override void GenerateBarcodeInternal(bool forceGeneration = false)
        {
            Barcode.GenerateID(forceGeneration, Pallet.Barcode.ID, this.GetType().Name, Title.Replace(".", ""));
        }

        public virtual bool IsBundledDataCard()
        {
            return true;
        }

        public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
        {
            base.ImportPackedAssets(packedAssets);
        }

        public override List<PackedAsset> ExportPackedAssets()
        {
            base.ExportPackedAssets();
#if UNITY_EDITOR
            SetupDataCardAsset();
#endif
            return PackedAssets;
        }

#if UNITY_EDITOR
        private void SetupDataCardAsset()
        {
            if (this.IsBundledDataCard() && (DataCardAsset == null || string.IsNullOrEmpty(DataCardAsset.AssetGUID)))
            {
                var dataCardPath = UnityEditor.AssetDatabase.GetAssetPath(this);
                var dataCardGuid = UnityEditor.AssetDatabase.AssetPathToGUID(dataCardPath);
                DataCardAsset = new MarrowAssetT<DataCard>(dataCardGuid);
            }
        }

        public override void GeneratePackedAssets(bool saveAsset = true)
        {
            base.GeneratePackedAssets(saveAsset);
            SetupDataCardAsset();
            EditorUtility.SetDirty(this);
            if (saveAsset)
            {
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

#endif
        public override void Pack(ObjectStore store, JObject json)
        {
            base.Pack(store, json);
#if UNITY_EDITOR
            if (this.IsBundledDataCard())
            {
                SetupDataCardAsset();
            }

#endif
            if (this.IsBundledDataCard() && DataCardAsset != null && !string.IsNullOrEmpty(DataCardAsset.AssetGUID))
            {
                json.Add("dataCardAsset", DataCardAsset.AssetGUID);
            }
        }

        public override void Unpack(ObjectStore store, string objectId)
        {
            base.Unpack(store, objectId);
            if (this.IsBundledDataCard())
            {
                if (store.TryGetJSON("dataCardAsset", objectId, out JToken dataCardAssetValue))
                {
                    DataCardAsset = new MarrowAssetT<DataCard>(dataCardAssetValue.ToString());
                }
            }
        }

        public static DataCard CreateDataCard(System.Type type, Pallet pallet, string title, bool generateBarcode = true)
        {
            DataCard dataCard = null;
            if (typeof(DataCard).IsAssignableFrom(type))
            {
                dataCard = (DataCard)ScriptableObject.CreateInstance(type);
                dataCard.Title = title;
                dataCard.Pallet = pallet;
                if (generateBarcode)
                {
                    dataCard.GenerateBarcode();
                    dataCard.SlimCode.GenerateGuid();
                }
            }

            return dataCard;
        }

        public static T CreateDataCard<T>(Pallet pallet, string title, bool generateBarcode = true)
            where T : DataCard
        {
            return (T)CreateDataCard(typeof(T), pallet, title, generateBarcode);
        }
    }
}