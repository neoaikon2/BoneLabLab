namespace TMPro
{
	public struct KerningPairKey
	{
		public uint ascii_Left;

		public uint ascii_Right;

		public uint key;

		public KerningPairKey(uint ascii_left, uint ascii_right)
		{
			this.key = default(uint);
			this.ascii_Right = default(uint);
			this.ascii_Left = default(uint);
		}
	}
}
