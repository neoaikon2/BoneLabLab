using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_SpriteCharacter : TMP_TextElement
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_HashCode;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int hashCode
		{
			get
			{
				return default(int);
			}
		}

		public TMP_SpriteCharacter()
			: base()
		{
		}

		public TMP_SpriteCharacter(uint unicode, TMP_SpriteGlyph glyph)
			: this()
		{
		}

		public TMP_SpriteCharacter(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph)
			: this()
		{
		}

		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex)
			: this()
		{
		}
	}
}
