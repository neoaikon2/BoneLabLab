namespace TMPro
{
	public struct GlyphPairKey
	{
		public uint firstGlyphIndex;

		public uint secondGlyphIndex;

		public uint key;

		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
			this.key = default(uint);
			this.secondGlyphIndex = default(uint);
			this.firstGlyphIndex = default(uint);
		}

		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
			this.key = default(uint);
			this.secondGlyphIndex = default(uint);
			this.firstGlyphIndex = default(uint);
		}
	}
}
