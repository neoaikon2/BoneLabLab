using System;
using System.IO;

namespace WebSocketSharp.Net
{
	internal class ChunkedRequestStream : RequestStream
	{
		private static readonly int _bufferLength;

		private HttpListenerContext _context;

		private ChunkStream _decoder;

		private bool _disposed;

		private bool _noMoreData;

		static ChunkedRequestStream()
		{
		}

		internal ChunkedRequestStream(Stream stream, byte[] buffer, int offset, int count, HttpListenerContext context) : base(stream, buffer, offset, count, 0)
		{			
		}

		private void onRead(IAsyncResult asyncResult)
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void Close()
		{
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
}
