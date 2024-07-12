using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Serialize;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow
{
	public class MarrowSettings : ScriptableObject, IPackable, IPackedAssets
	{
		[SerializeField]
		private string _gameTitle;

		[Tooltip("Content for this Marrow Game")]
		[SerializeField]
		private List<PalletReference> _gamePallets;

		[Tooltip("Individual Content for this Marrow Game")]
		[SerializeField]
		private List<PalletReference> _standalonePallets;

		[SerializeField]
		private LevelCrateReference _defaultLoadingLevel;

		[SerializeField]
		private SpawnableCrateReference _defaultControllerRig;

		[SerializeField]
		private SpawnableCrateReference _defaultPlayerRig;

		[SerializeField]
		private SpawnableCrateReference _uiEventSystem;

		[SerializeField]
		private MarrowAssetT<AudioMixer> _defaultAudioMixer;

		[SerializeField]
		private Spawnable _audioPlayer;

		[SerializeField]
		private DataCardReference<BoneTag> _playerTag;

		[SerializeField]
		private DataCardReference<BoneTag> _beingTag;

		[SerializeField]
		private DataCardReference<MonoDisc> _loadMusic;

		[SerializeField]
		private DataCardReference<MonoDisc> _loadAmbience;

		[SerializeField]
		private DataCardReference<MonoDisc> _defaultAmbience;

		[SerializeField]
		private string _buildPlatform;

		public static readonly string settingsKey;

		private static MarrowSettings _runtimeInstance;

		private List<PackedAsset> _packedAssets;

		public string GameTitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<PalletReference> GamePallets
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public List<PalletReference> StandalonePallets
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public LevelCrateReference DefaultLoadingLevel
		{
			get
			{
				return null;
			}
		}

		public SpawnableCrateReference DefaultControllerRig
		{
			get
			{
				return null;
			}
		}

		public SpawnableCrateReference DefaultPlayerRig
		{
			get
			{
				return null;
			}
		}

		public SpawnableCrateReference UIEventSystem
		{
			get
			{
				return null;
			}
		}

		public MarrowAssetT<AudioMixer> DefaultAudioMixer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Spawnable AudioPlayer
		{
			get
			{
				return default(Spawnable);
			}
		}

		public DataCardReference<BoneTag> PlayerTag
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DataCardReference<BoneTag> BeingTag
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DataCardReference<MonoDisc> DefaultLoadMusic
		{
			get
			{
				return null;
			}
		}

		public DataCardReference<MonoDisc> LoadAmbience
		{
			get
			{
				return null;
			}
		}

		public DataCardReference<MonoDisc> DefaultAmbience
		{
			get
			{
				return null;
			}
		}

		public string BuildPlatform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static MarrowSettings RuntimeInstance
		{
			get
			{
				return null;
			}
		}

		public List<PackedAsset> PackedAssets
		{
			get
			{
				return null;
			}
		}

		public static UniTask<MarrowSettings> LoadSettings()
		{
			return default(UniTask<MarrowSettings>);
		}

		private static UniTask<MarrowSettings> LoadRuntimeSettings()
		{
			return default(UniTask<MarrowSettings>);
		}

		public static void UnloadRuntimeSettings()
		{
		}

		private static void SimulatePlaymodeAssets()
		{
		}

		private UniTask PreloadAssets()
		{
			return default(UniTask);
		}

		private UniTask Initialize()
		{
			return default(UniTask);
		}

		public void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		public virtual void Pack(ObjectStore store, JObject json)
		{
		}

		public virtual void Unpack(ObjectStore store, string objectId)
		{
		}

		public void GeneratePackedAssets(bool saveAsset = true)
		{
			throw new System.NotImplementedException();
		}

		public MarrowSettings()
			: base()
		{
		}
	}
}
