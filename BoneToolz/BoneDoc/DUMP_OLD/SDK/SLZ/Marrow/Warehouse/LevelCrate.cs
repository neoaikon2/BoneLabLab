using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.Warehouse
{
	public class LevelCrate : Crate
	{
		[FormerlySerializedAs("_assetReference")]
		[SerializeField]
		private MarrowScene _mainAsset;

		[SerializeField]
		private List<MarrowScene> _additionalAssetReferences;

		[Tooltip("Level has multiple scenes")]
		[SerializeField]
		private bool _multiScene;

		[Tooltip("Scenes that also load in when the root scene loads, and will stay always loaded in until level change")]
		[SerializeField]
		private List<MarrowScene> _persistentScenes;

		[Tooltip("Scenes that will be loaded dynamically in the level, for example: Chunk scenes loaded through a Chunk Trigger. All chunked scenes must be included here or they will not be included in the build")]
		[SerializeField]
		private List<MarrowScene> _chunkScenes;

		[Tooltip("Scenes that will ONLY load in the editor at design time, outside of playmode. They will NOT load in during builds, and will NOT be included in builds")]
		[SerializeField]
		private List<MarrowScene> _editorScenes;

		public override MarrowAsset MainAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowScene MainScene
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MultiScene
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<MarrowScene> PersistentScenes
		{
			get
			{
				return null;
			}
		}

		public List<MarrowScene> ChunkScenes
		{
			get
			{
				return null;
			}
		}

		public List<MarrowScene> EditorScenes
		{
			get
			{
				return null;
			}
		}

		public override Type AssetType
		{
			get
			{
				return null;
			}
		}

		public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public override List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, string objectId)
		{
		}

		public LevelCrate()
			: base()
		{
		}
	}
}
