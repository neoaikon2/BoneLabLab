using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public class MonoDisc : DataCard
	{
		[SerializeField]
		private MarrowAssetT<AudioClip> _audioClip;

		public MarrowAssetT<AudioClip> AudioClip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool IsBundledDataCard()
		{
			return default(bool);
		}

		public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public override List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		public MonoDisc()
			: base()
		{
		}
	}
}
