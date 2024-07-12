using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphAdjustmentRecord
	{
		[SerializeField]
		internal uint m_GlyphIndex;

		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord;

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

		public TMP_GlyphValueRecord glyphValueRecord
		{
			get
			{
				return default(TMP_GlyphValueRecord);
			}
			set
			{
			}
		}

		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			this.m_GlyphValueRecord = default(TMP_GlyphValueRecord);
			this.m_GlyphIndex = default(uint);
		}

		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			this.m_GlyphValueRecord = default(TMP_GlyphValueRecord);
			this.m_GlyphIndex = default(uint);
		}
	}
}
