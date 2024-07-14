using System;
 
 
 
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public class DataCardReference : ScannableReference<DataCard>
    {
        public DataCardReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public DataCardReference(string barcode) : base(barcode)
        {
        }

        public DataCard DataCard
        {
            get
            {
                TryGetDataCard(out var retDataCard);
                return retDataCard;
            }
        }

        public bool TryGetDataCard(out DataCard dataCard)
        {
            dataCard = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetDataCard(Barcode, out dataCard);
            }

            return success;
        }

        public static bool IsValid(DataCardReference dataCardReference)
        {
            return dataCardReference != null && Barcode.IsValid(dataCardReference.Barcode);
        }
    }

    [Serializable]
    public class DataCardReference<T> : ScannableReference<DataCard> where T : DataCard
    {
        public DataCardReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public DataCardReference(string barcode) : base(barcode)
        {
        }

        public new T DataCard
        {
            get
            {
                TryGetDataCard(out var retDataCard);
                return retDataCard;
            }
        }

        public bool TryGetDataCard(out T dataCard)
        {
            dataCard = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetDataCard<T>(Barcode, out dataCard);
            }

            return success;
        }
    }

    [Serializable]
    public class BoneTagReference : DataCardReference<BoneTag>
    {
        public BoneTagReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public BoneTagReference(string barcode) : base(barcode)
        {
        }
    }

    [Serializable]
    public class MonoDiscReference : DataCardReference<MonoDisc>
    {
        public MonoDiscReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public MonoDiscReference(string barcode) : base(barcode)
        {
        }
    }
}