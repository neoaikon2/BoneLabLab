using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TMPro
{
	public static class TMP_FontUtilities
	{
		private static List<int> k_searchedFontAssets;

		public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, [Out] TMP_Character character)
		{
			return null;
		}

		public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, [Out] TMP_Character character)
		{
			return null;
		}

		private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, [Out] TMP_Character character)
		{
			return null;
		}

		private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, [Out] TMP_Character character)
		{
			return null;
		}
	}
}
