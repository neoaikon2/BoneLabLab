using System;
using System.IO;

namespace WebSocketSharp.Net
{
	internal class RequestStream : Stream
	{
		private long _bodyLeft;

		private byte[] _buffer;

		private int _count;

		private bool _disposed;

		private int _offset;

		private Stream _stream;

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

		internal RequestStream(Stream stream, byte[] buffer, int offset, int count, long contentLength)
			: base()
		{
		}

		private int fillFromBuffer(byte[] buffer, int offset, int count)
		{
			return default(int);
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
