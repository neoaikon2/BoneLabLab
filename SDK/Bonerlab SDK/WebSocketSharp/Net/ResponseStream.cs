using System;
using System.IO;

namespace WebSocketSharp.Net
{
	internal class ResponseStream : Stream
	{
		private MemoryStream _bodyBuffer;

		private static readonly byte[] _crlf;

		private bool _disposed;

		private Stream _innerStream;

		private static readonly byte[] _lastChunk;

		private static readonly int _maxHeadersLength;

		private HttpListenerResponse _response;

		private bool _sendChunked;

		private Action<byte[], int, int> _write;

		private Action<byte[], int, int> _writeBody;

		private Action<byte[], int, int> _writeChunked;

		public override bool CanRead
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanSeek
		{
			get
			{
				return default(bool);
			}
		}

		public override bool CanWrite
		{
			get
			{
				return default(bool);
			}
		}

		public override long Length
		{
			get
			{
				return default(long);
			}
		}

		public override long Position
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		static ResponseStream()
		{
		}

		internal ResponseStream(Stream innerStream, HttpListenerResponse response, bool ignoreWriteExceptions)
			: base()
		{
		}

		private bool flush(bool closing)
		{
			return default(bool);
		}

		private void flushBody(bool closing)
		{
		}

		private bool flushHeaders()
		{
			return default(bool);
		}

		private static byte[] getChunkSizeBytes(int size)
		{
			return null;
		}

		private void writeChunked(byte[] buffer, int offset, int count)
		{
		}

		private void writeChunkedWithoutThrowingException(byte[] buffer, int offset, int count)
		{
		}

		private void writeWithoutThrowingException(byte[] buffer, int offset, int count)
		{
		}

		internal void Close(bool force)
		{
		}

		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void Close()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
