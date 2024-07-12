using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset]
	public class TMP_Settings : ScriptableObject
	{
		public class LineBreakingTable
		{
			public Dictionary<int, char> leadingCharacters;

			public Dictionary<int, char> followingCharacters;

			public LineBreakingTable()
				: base()
			{
			}
		}

		private static TMP_Settings s_Instance;

		[SerializeField]
		private bool m_enableWordWrapping;

		[SerializeField]
		private bool m_enableKerning;

		[SerializeField]
		private bool m_enableExtraPadding;

		[SerializeField]
		private bool m_enableTintAllSprites;

		[SerializeField]
		private bool m_enableParseEscapeCharacters;

		[SerializeField]
		private bool m_EnableRaycastTarget;

		[SerializeField]
		private bool m_GetFontFeaturesAtRuntime;

		[SerializeField]
		private int m_missingGlyphCharacter;

		[SerializeField]
		private bool m_warningsDisabled;

		[SerializeField]
		private TMP_FontAsset m_defaultFontAsset;

		[SerializeField]
		private string m_defaultFontAssetPath;

		[SerializeField]
		private float m_defaultFontSize;

		[SerializeField]
		private float m_defaultAutoSizeMinRatio;

		[SerializeField]
		private float m_defaultAutoSizeMaxRatio;

		[SerializeField]
		private Vector2 m_defaultTextMeshProTextContainerSize;

		[SerializeField]
		private Vector2 m_defaultTextMeshProUITextContainerSize;

		[SerializeField]
		private bool m_autoSizeTextContainer;

		[SerializeField]
		private bool m_IsTextObjectScaleStatic;

		[SerializeField]
		private List<TMP_FontAsset> m_fallbackFontAssets;

		[SerializeField]
		private bool m_matchMaterialPreset;

		[SerializeField]
		private TMP_SpriteAsset m_defaultSpriteAsset;

		[SerializeField]
		private string m_defaultSpriteAssetPath;

		[SerializeField]
		private bool m_enableEmojiSupport;

		[SerializeField]
		private uint m_MissingCharacterSpriteUnicode;

		[SerializeField]
		private string m_defaultColorGradientPresetsPath;

		[SerializeField]
		private TMP_StyleSheet m_defaultStyleSheet;

		[SerializeField]
		private string m_StyleSheetsResourcePath;

		[SerializeField]
		private TextAsset m_leadingCharacters;

		[SerializeField]
		private TextAsset m_followingCharacters;

		[SerializeField]
		private LineBreakingTable m_linebreakingRules;

		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		public static string version
		{
			get
			{
				return null;
			}
		}

		public static bool enableWordWrapping
		{
			get
			{
				return default(bool);
			}
		}

		public static bool enableKerning
		{
			get
			{
				return default(bool);
			}
		}

		public static bool enableExtraPadding
		{
			get
			{
				return default(bool);
			}
		}

		public static bool enableTintAllSprites
		{
			get
			{
				return default(bool);
			}
		}

		public static bool enableParseEscapeCharacters
		{
			get
			{
				return default(bool);
			}
		}

		public static bool enableRaycastTarget
		{
			get
			{
				return default(bool);
			}
		}

		public static bool getFontFeaturesAtRuntime
		{
			get
			{
				return default(bool);
			}
		}

		public static int missingGlyphCharacter
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public static bool warningsDisabled
		{
			get
			{
				return default(bool);
			}
		}

		public static TMP_FontAsset defaultFontAsset
		{
			get
			{
				return null;
			}
		}

		public static string defaultFontAssetPath
		{
			get
			{
				return null;
			}
		}

		public static float defaultFontSize
		{
			get
			{
				return default(float);
			}
		}

		public static float defaultTextAutoSizingMinRatio
		{
			get
			{
				return default(float);
			}
		}

		public static float defaultTextAutoSizingMaxRatio
		{
			get
			{
				return default(float);
			}
		}

		public static Vector2 defaultTextMeshProTextContainerSize
		{
			get
			{
				return default(Vector2);
			}
		}

		public static Vector2 defaultTextMeshProUITextContainerSize
		{
			get
			{
				return default(Vector2);
			}
		}

		public static bool autoSizeTextContainer
		{
			get
			{
				return default(bool);
			}
		}

		public static bool isTextObjectScaleStatic
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static List<TMP_FontAsset> fallbackFontAssets
		{
			get
			{
				return null;
			}
		}

		public static bool matchMaterialPreset
		{
			get
			{
				return default(bool);
			}
		}

		public static TMP_SpriteAsset defaultSpriteAsset
		{
			get
			{
				return null;
			}
		}

		public static string defaultSpriteAssetPath
		{
			get
			{
				return null;
			}
		}

		public static bool enableEmojiSupport
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static uint missingCharacterSpriteUnicode
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public static string defaultColorGradientPresetsPath
		{
			get
			{
				return null;
			}
		}

		public static TMP_StyleSheet defaultStyleSheet
		{
			get
			{
				return null;
			}
		}

		public static string styleSheetsResourcePath
		{
			get
			{
				return null;
			}
		}

		public static TextAsset leadingCharacters
		{
			get
			{
				return null;
			}
		}

		public static TextAsset followingCharacters
		{
			get
			{
				return null;
			}
		}

		public static LineBreakingTable linebreakingRules
		{
			get
			{
				return null;
			}
		}

		public static bool useModernHangulLineBreakingRules
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static TMP_Settings instance
		{
			get
			{
				return null;
			}
		}

		public static TMP_Settings LoadDefaultSettings()
		{
			return null;
		}

		public static TMP_Settings GetSettings()
		{
			return null;
		}

		public static TMP_FontAsset GetFontAsset()
		{
			return null;
		}

		public static TMP_SpriteAsset GetSpriteAsset()
		{
			return null;
		}

		public static TMP_StyleSheet GetStyleSheet()
		{
			return null;
		}

		public static void LoadLinebreakingRules()
		{
		}

		private static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			return null;
		}

		public TMP_Settings()
			: base()
		{
		}
	}
}
