using System.Diagnostics;
using UnityEngine;

namespace TMPro
{
	[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString(\"X\")})")]
	public struct TMP_CharacterInfo
	{
		public char character;

		public int index;

		public int stringLength;

		public TMP_TextElementType elementType;

		public TMP_TextElement textElement;

		public TMP_FontAsset fontAsset;

		public TMP_SpriteAsset spriteAsset;

		public int spriteIndex;

		public Material material;

		public int materialReferenceIndex;

		public bool isUsingAlternateTypeface;

		public float pointSize;

		public int lineNumber;

		public int pageNumber;

		public int vertexIndex;

		public TMP_Vertex vertex_BL;

		public TMP_Vertex vertex_TL;

		public TMP_Vertex vertex_TR;

		public TMP_Vertex vertex_BR;

		public Vector3 topLeft;

		public Vector3 bottomLeft;

		public Vector3 topRight;

		public Vector3 bottomRight;

		public float origin;

		public float xAdvance;

		public float ascender;

		public float baseLine;

		public float descender;

		internal float adjustedAscender;

		internal float adjustedDescender;

		public float aspectRatio;

		public float scale;

		public Color32 color;

		public Color32 underlineColor;

		public int underlineVertexIndex;

		public Color32 strikethroughColor;

		public int strikethroughVertexIndex;

		public Color32 highlightColor;

		public HighlightState highlightState;

		public FontStyles style;

		public bool isVisible;
	}
}
