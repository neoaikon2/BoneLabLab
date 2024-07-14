using System;
 
 
 
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public class PalletReference : ScannableReference<Pallet>
    {
        public PalletReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public PalletReference(string barcode) : base(barcode)
        {
        }

        public Pallet Pallet
        {
            get
            {
                TryGetPallet(out var retPallet);
                return retPallet;
            }
        }

        public bool TryGetPallet(out Pallet pallet)
        {
            pallet = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetPallet(Barcode, out pallet);
            }

            return success;
        }

        public static bool IsValid(PalletReference palletReference)
        {
            return palletReference != null && Barcode.IsValid(palletReference.Barcode);
        }
    }
}