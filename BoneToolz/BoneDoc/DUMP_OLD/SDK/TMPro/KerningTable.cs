using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TMPro
{
	[Serializable]
	public class KerningTable
	{
		public List<KerningPair> kerningPairs;

		public void AddKerningPair()
		{
		}

		public int AddKerningPair(uint first, uint second, float offset)
		{
			return default(int);
		}

		public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments)
		{
			return default(int);
		}

		public void RemoveKerningPair(int left, int right)
		{
		}

		public void RemoveKerningPair(int index)
		{
		}

		public void SortKerningPairs()
		{
		}

		public KerningTable()
			: base()
		{
		}
	}
}
