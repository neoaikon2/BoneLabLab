using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_FontFeatureTable
	{
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

		internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SortGlyphPairAdjustmentRecords()
		{
		}

		public TMP_FontFeatureTable()
			: base()
		{
		}
	}
}
