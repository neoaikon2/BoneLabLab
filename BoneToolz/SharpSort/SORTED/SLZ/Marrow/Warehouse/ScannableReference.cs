using System;
 
 
 
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    [Serializable]
    public abstract class ScannableReference
    {
        [SerializeField]
        protected Barcode _barcode = Barcode.EmptyBarcode();
        public Barcode Barcode { get => _barcode; set => _barcode = value; }
        public virtual Type ScannableType { get => typeof(Scannable); }

        public ScannableReference()
        {
        }

        public ScannableReference(string barcode)
        {
            this.Barcode = new Barcode(barcode);
        }

        public Scannable Scannable
        {
            get
            {
                Scannable retScannable = null;
                if (AssetWarehouse.ready)
                {
                    AssetWarehouse.Instance.TryGetScannable(Barcode, out retScannable);
                }

                return retScannable;
            }
        }

        public bool TryGetScannable(out Scannable scannable)
        {
            scannable = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetScannable(Barcode, out scannable);
            }

            return success;
        }

        public bool IsValid()
        {
            return Barcode.IsValid();
        }

        public static bool IsValid(ScannableReference scannableReference)
        {
            return scannableReference != null && Barcode.IsValid(scannableReference.Barcode);
        }
    }

    [Serializable]
    public class ScannableReference<T> : ScannableReference where T : Scannable
    {
        public override Type ScannableType { get => typeof(T); }

        public ScannableReference() : base()
        {
        }

        public ScannableReference(string barcode) : base(barcode)
        {
        }

        public new T Scannable
        {
            get
            {
                T retScannable = null;
                if (AssetWarehouse.ready)
                {
                    AssetWarehouse.Instance.TryGetScannable<T>(Barcode, out retScannable);
                }

                return retScannable;
            }
        }

        public bool TryGetScannable(out T scannable)
        {
            scannable = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetScannable<T>(Barcode, out scannable);
            }

            return success;
        }
    }
}