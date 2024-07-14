 
using System.Collections.Generic;
 
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
    public class MonoDisc : DataCard
    {
        [SerializeField]
        private MarrowAssetT<AudioClip> _audioClip = new MarrowAssetT<AudioClip>();
        public MarrowAssetT<AudioClip> AudioClip { get => _audioClip; set => _audioClip = value; }

        public override bool IsBundledDataCard()
        {
            return true;
        }

        public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
        {
            base.ImportPackedAssets(packedAssets);
            if (packedAssets.TryGetValue("AudioClip", out var packedAsset))
                AudioClip = new MarrowAssetT<AudioClip>(packedAsset.marrowAsset.AssetGUID);
        }

        public override List<PackedAsset> ExportPackedAssets()
        {
            base.ExportPackedAssets();
            PackedAssets.Add(new PackedAsset("AudioClip", AudioClip, AudioClip.AssetType, "_audioClip"));
            return PackedAssets;
        }

#if UNITY_EDITOR
        public override void GeneratePackedAssets(bool saveAsset = true)
        {
            base.GeneratePackedAssets(saveAsset);
        }
#endif
    }
}