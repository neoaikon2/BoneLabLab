using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public sealed class CodedInputStream : IDisposable
	{
		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private int bufferSize;

		private int bufferSizeAfterLimit;

		private int bufferPos;

		private readonly Stream input;

		private uint lastTag;

		private uint nextTag;

		private bool hasNextTag;

		private int totalBytesRetired;

		private int currentLimit;

		private int recursionDepth;

		private readonly int recursionLimit;

		private readonly int sizeLimit;

		internal uint LastTag
		{
			get
			{
				return default(uint);
			}
		}

		internal bool DiscardUnknownFields { get; set; }

		internal ExtensionRegistry ExtensionRegistry { get; set; }

		internal bool ReachedLimit
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsAtEnd
		{
			get
			{
				return default(bool);
			}
		}

		public CodedInputStream(byte[] buffer)
			: base()
		{
		}

		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen)
			: base()
		{
		}

		public void Dispose()
		{
		}

		internal void CheckReadEndOfStreamTag()
		{
		}

		public uint PeekTag()
		{
			return default(uint);
		}

		public uint ReadTag()
		{
			return default(uint);
		}

		public void SkipLastField()
		{
		}

		internal void SkipGroup(uint startGroupTag)
		{
		}

		public double ReadDouble()
		{
			return default(double);
		}

		public float ReadFloat()
		{
			return default(float);
		}

		public ulong ReadUInt64()
		{
			return default(ulong);
		}

		public long ReadInt64()
		{
			return default(long);
		}

		public int ReadInt32()
		{
			return default(int);
		}

		public ulong ReadFixed64()
		{
			return default(ulong);
		}

		public uint ReadFixed32()
		{
			return default(uint);
		}

		public bool ReadBool()
		{
			return default(bool);
		}

		public string ReadString()
		{
			return null;
		}

		public void ReadMessage(IMessage builder)
		{
		}

		public ByteString ReadBytes()
		{
			return null;
		}

		public int ReadEnum()
		{
			return default(int);
		}

		public int ReadLength()
		{
			return default(int);
		}

		public bool MaybeConsumeTag(uint tag)
		{
			return default(bool);
		}

		private uint SlowReadRawVarint32()
		{
			return default(uint);
		}

		internal uint ReadRawVarint32()
		{
			return default(uint);
		}

		internal ulong ReadRawVarint64()
		{
			return default(ulong);
		}

		internal uint ReadRawLittleEndian32()
		{
			return default(uint);
		}

		internal ulong ReadRawLittleEndian64()
		{
			return default(ulong);
		}

		internal int PushLimit(int byteLimit)
		{
			return default(int);
		}

		private void RecomputeBufferSizeAfterLimit()
		{
		}

		internal void PopLimit(int oldLimit)
		{
		}

		private bool RefillBuffer(bool mustSucceed)
		{
			return default(bool);
		}

		internal byte ReadRawByte()
		{
			return default(byte);
		}

		internal byte[] ReadRawBytes(int size)
		{
			return null;
		}

		private void SkipRawBytes(int size)
		{
		}

		private void SkipImpl(int amountToSkip)
		{
		}
	}
}
