using System;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	public class TMP_TextElement
	{
		[SerializeField]
		protected TextElementType m_ElementType;

		[SerializeField]
		internal uint m_Unicode;

		internal TMP_Asset m_TextAsset;

		internal Glyph m_Glyph;

		[SerializeField]
		internal uint m_GlyphIndex;

		[SerializeField]
		internal float m_Scale;

		public TextElementType elementType
		{
			get
			{
				return default(TextElementType);
			}
		}

		public uint unicode
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public TMP_Asset textAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Glyph glyph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint glyphIndex
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public TMP_TextElement()
			: base()
		{
		}
	}
}
