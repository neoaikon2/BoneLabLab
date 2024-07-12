using System.Collections.Generic;

namespace Google.Protobuf
{
	internal sealed class UnknownField
	{
		private List<ulong> varintList;

		private List<uint> fixed32List;

		private List<ulong> fixed64List;

		private List<ByteString> lengthDelimitedList;

		private List<UnknownFieldSet> groupList;

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		internal void WriteTo(int fieldNumber, CodedOutputStream output)
		{
		}

		internal int GetSerializedSize(int fieldNumber)
		{
			return default(int);
		}

		internal UnknownField MergeFrom(UnknownField other)
		{
			return null;
		}

		private static List<T> AddAll<T>(List<T> current, IList<T> extras)
		{
			return null;
		}

		internal UnknownField AddVarint(ulong value)
		{
			return null;
		}

		internal UnknownField AddFixed32(uint value)
		{
			return null;
		}

		internal UnknownField AddFixed64(ulong value)
		{
			return null;
		}

		internal UnknownField AddLengthDelimited(ByteString value)
		{
			return null;
		}

		internal UnknownField AddGroup(UnknownFieldSet value)
		{
			return null;
		}

		private static List<T> Add<T>(List<T> list, T value)
		{
			return null;
		}

		public UnknownField()
			: base()
		{
		}
	}
}
