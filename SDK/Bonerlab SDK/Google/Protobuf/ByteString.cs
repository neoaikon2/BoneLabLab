using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Protobuf
{
	[DefaultMember("Item")]
	public sealed class ByteString : IEnumerable<byte>, IEnumerable, IEquatable<ByteString>
	{
		private static readonly ByteString empty;

		private readonly byte[] bytes;

		public static ByteString Empty
		{
			get
			{
				return null;
			}
		}

		public int Length
		{
			get
			{
				return default(int);
			}
		}

		internal static ByteString AttachBytes(byte[] bytes)
		{
			return null;
		}

		private ByteString(byte[] bytes)
			: base()
		{
		}

		public string ToBase64()
		{
			return null;
		}

		public static ByteString CopyFrom(params byte[] bytes)
		{
			bytes = default(byte[]);
			return null;
		}

		public static ByteString CopyFrom(byte[] bytes, int offset, int count)
		{
			return null;
		}

		public IEnumerator<byte> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public CodedInputStream CreateCodedInput()
		{
			return null;
		}

		public static bool operator ==(ByteString lhs, ByteString rhs)
		{
			return default(bool);
		}

		public static bool operator !=(ByteString lhs, ByteString rhs)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public bool Equals(ByteString other)
		{
			return default(bool);
		}

		internal void WriteRawBytesTo(CodedOutputStream outputStream)
		{
		}
	}
}
