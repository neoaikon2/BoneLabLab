using System.Collections.Generic;
using System.Text;

namespace WebSocketSharp.Net
{
	internal class ChunkStream
	{
		private int _chunkRead;

		private int _chunkSize;

		private List<Chunk> _chunks;

		private bool _gotIt;

		private WebHeaderCollection _headers;

		private StringBuilder _saved;

		private bool _sawCr;

		private InputChunkState _state;

		private int _trailerState;

		public bool WantsMore
		{
			get
			{
				return default(bool);
			}
		}

		public ChunkStream(WebHeaderCollection headers)
			: base()
		{
		}

		private int read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		private InputChunkState seekCrLf(byte[] buffer, int offset, int length)
		{
			return default(InputChunkState);
		}

		private InputChunkState setChunkSize(byte[] buffer, int offset, int length)
		{
			return default(InputChunkState);
		}

		private InputChunkState setTrailer(byte[] buffer, int offset, int length)
		{
			return default(InputChunkState);
		}

		private static void throwProtocolViolation(string message)
		{
		}

		private void write(byte[] buffer, int offset, int length)
		{
		}

		private InputChunkState writeData(byte[] buffer, int offset, int length)
		{
			return default(InputChunkState);
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		public void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
