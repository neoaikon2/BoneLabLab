using System;
using System.IO;
using System.Text;

namespace Google.Protobuf
{
	public sealed class CodedOutputStream : IDisposable
	{
		public sealed class OutOfSpaceException : IOException
		{
			internal OutOfSpaceException()
				: base()
			{
			}
		}

		internal static readonly Encoding Utf8Encoding;

		public static readonly int DefaultBufferSize;

		private readonly bool leaveOpen;

		private readonly byte[] buffer;

		private readonly int limit;

		private int position;

		private readonly Stream output;

		public int SpaceLeft
		{
			get
			{
				return default(int);
			}
		}

		public static int ComputeUInt64Size(ulong value)
		{
			return default(int);
		}

		public static int ComputeInt64Size(long value)
		{
			return default(int);
		}

		public static int ComputeInt32Size(int value)
		{
			return default(int);
		}

		public static int ComputeFixed64Size(ulong value)
		{
			return default(int);
		}

		public static int ComputeFixed32Size(uint value)
		{
			return default(int);
		}

		public static int ComputeStringSize(string value)
		{
			return default(int);
		}

		public static int ComputeMessageSize(IMessage value)
		{
			return default(int);
		}

		public static int ComputeBytesSize(ByteString value)
		{
			return default(int);
		}

		public static int ComputeEnumSize(int value)
		{
			return default(int);
		}

		public static int ComputeLengthSize(int length)
		{
			return default(int);
		}

		public static int ComputeRawVarint32Size(uint value)
		{
			return default(int);
		}

		public static int ComputeRawVarint64Size(ulong value)
		{
			return default(int);
		}

		public static int ComputeTagSize(int fieldNumber)
		{
			return default(int);
		}

		public CodedOutputStream(byte[] flatArray)
			: base()
		{
		}

		private CodedOutputStream(byte[] buffer, int offset, int length)
			: base()
		{
		}

		private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen)
			: base()
		{
		}

		public CodedOutputStream(Stream output)
			: base()
		{
		}

		public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen)
			: base()
		{
		}

		public void WriteDouble(double value)
		{
		}

		public void WriteFloat(float value)
		{
		}

		public void WriteUInt64(ulong value)
		{
		}

		public void WriteInt64(long value)
		{
		}

		public void WriteInt32(int value)
		{
		}

		public void WriteFixed64(ulong value)
		{
		}

		public void WriteFixed32(uint value)
		{
		}

		public void WriteBool(bool value)
		{
		}

		public void WriteString(string value)
		{
		}

		public void WriteMessage(IMessage value)
		{
		}

		public void WriteBytes(ByteString value)
		{
		}

		public void WriteEnum(int value)
		{
		}

		public void WriteLength(int length)
		{
		}

		public void WriteTag(int fieldNumber, WireFormat.WireType type)
		{
		}

		public void WriteTag(uint tag)
		{
		}

		public void WriteRawTag(byte b1)
		{
		}

		public void WriteRawTag(byte b1, byte b2)
		{
		}

		internal void WriteRawVarint32(uint value)
		{
		}

		internal void WriteRawVarint64(ulong value)
		{
		}

		internal void WriteRawLittleEndian32(uint value)
		{
		}

		internal void WriteRawLittleEndian64(ulong value)
		{
		}

		internal void WriteRawByte(byte value)
		{
		}

		internal void WriteRawBytes(byte[] value)
		{
		}

		internal void WriteRawBytes(byte[] value, int offset, int length)
		{
		}

		private void RefreshBuffer()
		{
		}

		public void Dispose()
		{
		}

		public void Flush()
		{
		}

		public void CheckNoSpaceLeft()
		{
		}
	}
}
