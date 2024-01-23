using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		[SerializeField]
		[FormerlySerializedAs("AscII_Left")]
		private uint m_FirstGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		[SerializeField]
		[FormerlySerializedAs("AscII_Right")]
		private uint m_SecondGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		[FormerlySerializedAs("XadvanceOffset")]
		public float xOffset;

		internal static KerningPair empty;

		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;

		public uint firstGlyph
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			get
			{
				return default(GlyphValueRecord_Legacy);
			}
		}

		public uint secondGlyph
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			get
			{
				return default(GlyphValueRecord_Legacy);
			}
		}

		public bool ignoreSpacingAdjustments
		{
			get
			{
				return default(bool);
			}
		}

		public KerningPair()
			: base()
		{
		}

		public KerningPair(uint left, uint right, float offset)
			: this()
		{
		}

		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
			: this()
		{
		}

		internal void ConvertLegacyKerningData()
		{
		}
	}
}
