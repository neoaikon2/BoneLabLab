namespace WebSocketSharp.Net
{
	internal class ReadBufferState
	{
		private HttpStreamAsyncResult _asyncResult;

		private byte[] _buffer;

		private int _count;

		private int _initialCount;

		private int _offset;

		public HttpStreamAsyncResult AsyncResult
		{
			get
			{
				return null;
			}
		}

		public byte[] Buffer
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int InitialCount
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int Offset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult asyncResult)
			: base()
		{
		}
	}
}
