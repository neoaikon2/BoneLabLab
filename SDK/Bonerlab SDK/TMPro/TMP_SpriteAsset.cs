using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[ExcludeFromPreset]
	public class TMP_SpriteAsset : TMP_Asset
	{
		internal Dictionary<int, int> m_NameLookup;

		internal Dictionary<uint, int> m_GlyphIndexLookup;

		[SerializeField]
		private string m_Version;

		[SerializeField]
		internal FaceInfo m_FaceInfo;

		public Texture spriteSheet;

		[SerializeField]
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable;

		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup;

		[SerializeField]
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable;

		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup;

		public List<TMP_Sprite> spriteInfoList;

		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets;

		internal bool m_IsSpriteAssetLookupTablesDirty;

		private static HashSet<int> k_searchedSpriteAssets;

		public string version
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public FaceInfo faceInfo
		{
			get
			{
				return default(FaceInfo);
			}
			internal set
			{
			}
		}

		public List<TMP_SpriteCharacter> spriteCharacterTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<TMP_SpriteGlyph> spriteGlyphTable
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		private void Awake()
		{
		}

		private Material GetDefaultSpriteMaterial()
		{
			return null;
		}

		public void UpdateLookupTables()
		{
		}

		public int GetSpriteIndexFromHashcode(int hashCode)
		{
			return default(int);
		}

		public int GetSpriteIndexFromUnicode(uint unicode)
		{
			return default(int);
		}

		public int GetSpriteIndexFromName(string name)
		{
			return default(int);
		}

		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, [Out] int spriteIndex)
		{
			return null;
		}

		public void SortGlyphTable()
		{
		}

		internal void SortCharacterTable()
		{
		}

		internal void SortGlyphAndCharacterTables()
		{
		}

		private void UpgradeSpriteAsset()
		{
		}

		public TMP_SpriteAsset()
			: base()
		{
		}
	}
}
