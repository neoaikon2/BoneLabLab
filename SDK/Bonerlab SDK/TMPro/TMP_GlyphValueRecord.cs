using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphValueRecord
	{
		[SerializeField]
		internal float m_XPlacement;

		[SerializeField]
		internal float m_YPlacement;

		[SerializeField]
		internal float m_XAdvance;

		[SerializeField]
		internal float m_YAdvance;

		public float xPlacement
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float yPlacement
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float xAdvance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float yAdvance
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			this.m_YAdvance = default(float);
			this.m_XAdvance = default(float);
			this.m_YPlacement = default(float);
			this.m_XPlacement = default(float);
		}

		internal TMP_GlyphValueRecord(GlyphValueRecord_Legacy valueRecord)
		{
			this.m_YAdvance = default(float);
			this.m_XAdvance = default(float);
			this.m_YPlacement = default(float);
			this.m_XPlacement = default(float);
		}

		internal TMP_GlyphValueRecord(GlyphValueRecord valueRecord)
		{
			this.m_YAdvance = default(float);
			this.m_XAdvance = default(float);
			this.m_YPlacement = default(float);
			this.m_XPlacement = default(float);
		}

		public static TMP_GlyphValueRecord operator +(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b)
		{
			return default(TMP_GlyphValueRecord);
		}
	}
}
