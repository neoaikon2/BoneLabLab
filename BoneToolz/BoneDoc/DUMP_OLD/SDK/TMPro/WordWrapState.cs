using UnityEngine;

namespace TMPro
{
	public struct WordWrapState
	{
		public int previous_WordBreak;

		public int total_CharacterCount;

		public int visible_CharacterCount;

		public int visible_SpriteCount;

		public int visible_LinkCount;

		public int firstCharacterIndex;

		public int firstVisibleCharacterIndex;

		public int lastCharacterIndex;

		public int lastVisibleCharIndex;

		public int lineNumber;

		public float maxCapHeight;

		public float maxAscender;

		public float maxDescender;

		public float startOfLineAscender;

		public float maxLineAscender;

		public float maxLineDescender;

		public float pageAscender;

		public HorizontalAlignmentOptions horizontalAlignment;

		public float marginLeft;

		public float marginRight;

		public float xAdvance;

		public float preferredWidth;

		public float preferredHeight;

		public float previousLineScale;

		public int wordCount;

		public FontStyles fontStyle;

		public int italicAngle;

		public float fontScaleMultiplier;

		public float currentFontSize;

		public float baselineOffset;

		public float lineOffset;

		public bool isDrivenLineSpacing;

		public float glyphHorizontalAdvanceAdjustment;

		public float cSpace;

		public float mSpace;

		public TMP_TextInfo textInfo;

		public TMP_LineInfo lineInfo;

		public Color32 vertexColor;

		public Color32 underlineColor;

		public Color32 strikethroughColor;

		public Color32 highlightColor;

		public TMP_FontStyleStack basicStyleStack;

		public TMP_TextProcessingStack<int> italicAngleStack;

		public TMP_TextProcessingStack<Color32> colorStack;

		public TMP_TextProcessingStack<Color32> underlineColorStack;

		public TMP_TextProcessingStack<Color32> strikethroughColorStack;

		public TMP_TextProcessingStack<Color32> highlightColorStack;

		public TMP_TextProcessingStack<HighlightState> highlightStateStack;

		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack;

		public TMP_TextProcessingStack<float> sizeStack;

		public TMP_TextProcessingStack<float> indentStack;

		public TMP_TextProcessingStack<FontWeight> fontWeightStack;

		public TMP_TextProcessingStack<int> styleStack;

		public TMP_TextProcessingStack<float> baselineStack;

		public TMP_TextProcessingStack<int> actionStack;

		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack;

		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack;

		public int spriteAnimationID;

		public TMP_FontAsset currentFontAsset;

		public TMP_SpriteAsset currentSpriteAsset;

		public Material currentMaterial;

		public int currentMaterialIndex;

		public Extents meshExtents;

		public bool tagNoParsing;

		public bool isNonBreakingSpace;
	}
}
