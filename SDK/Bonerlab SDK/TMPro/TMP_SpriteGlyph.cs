using System;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	public class TMP_SpriteGlyph : Glyph
	{
		public Sprite sprite;

		public TMP_SpriteGlyph()
			: base()
		{
		}

		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
			: this()
		{
		}

		public TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite)
			: this()
		{
		}
	}
}
