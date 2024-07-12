namespace TMPro
{
	public struct TMP_FontStyleStack
	{
		public byte bold;

		public byte italic;

		public byte underline;

		public byte strikethrough;

		public byte highlight;

		public byte superscript;

		public byte subscript;

		public byte uppercase;

		public byte lowercase;

		public byte smallcaps;

		public void Clear()
		{
		}

		public byte Add(FontStyles style)
		{
			return default(byte);
		}

		public byte Remove(FontStyles style)
		{
			return default(byte);
		}
	}
}
