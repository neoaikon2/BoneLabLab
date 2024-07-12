using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TMPro
{
	public class TMP_FontAssetUtilities
	{
		private static readonly TMP_FontAssetUtilities s_Instance;

		private static HashSet<int> k_SearchedAssets;

		private static bool k_IsFontEngineInitialized;

		public static TMP_FontAssetUtilities instance
		{
			get
			{
				return null;
			}
		}

		static TMP_FontAssetUtilities()
		{
		}

		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, [Out] bool isAlternativeTypeface)
		{
			return null;
		}

		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, [Out] bool isAlternativeTypeface)
		{
			return null;
		}

		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, [Out] bool isAlternativeTypeface)
		{
			return null;
		}

		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		public TMP_FontAssetUtilities()
			: base()
		{
		}
	}
}
