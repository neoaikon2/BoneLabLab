using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public class SoundFx : DataCard
	{
		[SerializeField]
		[Tooltip("AudioClip that represents the sound effect. Add multiple to be used as variation sounds")]
		private MarrowAssetT<AudioClip>[] _audioClips;

		private MarrowAssetT<AudioClip>[] _audioClipsCachedRandom;

		private bool randomFirst;

		public MarrowAssetT<AudioClip>[] AudioClips
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
			return false;
		}

		/*
		public override UniTask PreloadAssets()
		{
			return default(UniTask);
		}
		*/

		public UniTask<AudioClip> LoadRandomAudioClip(bool noRepeats = true)
		{
			return default(UniTask<AudioClip>);
		}

		public MarrowAssetT<AudioClip> GetRandomAudioClip(bool noRepeats = true)
		{
			return null;
		}

		private MarrowAssetT<AudioClip> GetRandomAudioClipNoRepeat()
		{
			return null;
		}

		public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public override List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}
	}
}
