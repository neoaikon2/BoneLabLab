using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord
	{
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[SerializeField]
		internal FontFeatureLookupFlags m_FeatureLookupFlags;

		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			get
			{
				return default(TMP_GlyphAdjustmentRecord);
			}
			set
			{
			}
		}

		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			get
			{
				return default(TMP_GlyphAdjustmentRecord);
			}
			set
			{
			}
		}

		public FontFeatureLookupFlags featureLookupFlags
		{
			get
			{
				return default(FontFeatureLookupFlags);
			}
			set
			{
			}
		}

		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
			: base()
		{
		}

		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
			: base()
		{
		}
	}
}
