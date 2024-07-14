 
using System;
 
 
 
 
using UnityEngine;

 

#if UNITY_EDITOR
  

#endif
namespace SLZ.Marrow.Warehouse
{
    public interface ICrateReference
    {
        Barcode Barcode { get; set; }

        Crate Crate { get; }

        bool TryGetCrate(out Crate crate);
#if UNITY_EDITOR
        Type CrateType { get; }
#endif
    }

    [Serializable]
    public class CrateReference : ScannableReference<Crate>
    {
        public CrateReference() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public CrateReference(string barcode) : base(barcode)
        {
        }

        public Crate Crate
        {
            get
            {
                TryGetCrate(out var retCrate);
                return retCrate;
            }
        }

        public bool TryGetCrate(out Crate crate)
        {
            crate = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetCrate(Barcode, out crate);
            }

            return success;
        }

        public static bool IsValid(CrateReference crateReference)
        {
            return crateReference != null && Barcode.IsValid(crateReference.Barcode);
        }
    }

    [Serializable]
    public class CrateReferenceT<T> : ScannableReference<Crate> where T : Crate
    {
        public CrateReferenceT() : base(Warehouse.Barcode.EmptyBarcode())
        {
        }

        public CrateReferenceT(string barcode) : base(barcode)
        {
        }

        public new T Crate
        {
            get
            {
                TryGetCrate(out var retCrate);
                return retCrate;
            }
        }

        public bool TryGetCrate(out T crate)
        {
            crate = null;
            bool success = false;
            if (AssetWarehouse.ready)
            {
                success = AssetWarehouse.Instance.TryGetCrate<T>(Barcode, out crate);
            }

            return success;
        }
    }

    [Serializable]
    public class GenericCrateReference : CrateReferenceT<Crate>
    {
        public GenericCrateReference(string barcode) : base(barcode)
        {
        }

        public GenericCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }

    [Serializable]
    public class GameObjectCrateReference : CrateReferenceT<GameObjectCrate>
    {
        public GameObjectCrateReference(string barcode) : base(barcode)
        {
        }

        public GameObjectCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }

    [Serializable]
    public class SpawnableCrateReference : CrateReferenceT<SpawnableCrate>
    {
        public SpawnableCrateReference(string barcode) : base(barcode)
        {
        }

        public SpawnableCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }

    [Serializable]
    public class AvatarCrateReference : CrateReferenceT<AvatarCrate>
    {
        public AvatarCrateReference(string barcode) : base(barcode)
        {
        }

        public AvatarCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }

    [Serializable]
    public class LevelCrateReference : CrateReferenceT<LevelCrate>
    {
        public LevelCrateReference(string barcode) : base(barcode)
        {
        }

        public LevelCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }

    [Serializable]
    public class VFXCrateReference : CrateReferenceT<VFXCrate>
    {
        public VFXCrateReference(string barcode) : base(barcode)
        {
        }

        public VFXCrateReference() : base(Barcode.EmptyBarcode())
        {
        }
    }
}