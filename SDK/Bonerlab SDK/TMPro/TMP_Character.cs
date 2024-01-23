using System;
using UnityEngine.TextCore;

namespace TMPro
{
	[Serializable]
	public class TMP_Character : TMP_TextElement
	{
		public TMP_Character()
			: base()
		{
		}

		public TMP_Character(uint unicode, Glyph glyph)
			: this()
		{
		}

		public TMP_Character(uint unicode, TMP_FontAsset fontAsset, Glyph glyph)
			: this()
		{
		}

		internal TMP_Character(uint unicode, uint glyphIndex)
			: this()
		{
		}
	}
}
