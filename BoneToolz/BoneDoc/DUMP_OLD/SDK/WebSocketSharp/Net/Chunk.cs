namespace WebSocketSharp.Net
{
	internal class Chunk
	{
		private byte[] _data;

		private int _offset;

		public int ReadLeft
		{
			get
			{
				return default(int);
			}
		}

		public Chunk(byte[] data)
			: base()
		{
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
}
