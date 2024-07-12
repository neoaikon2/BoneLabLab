using System.Collections.Generic;

namespace Google.Protobuf
{
	public sealed class UnknownFieldSet
	{
		private readonly IDictionary<int, UnknownField> fields;

		private int lastFieldNumber;

		private UnknownField lastField;

		internal UnknownFieldSet()
			: base()
		{
		}

		internal bool HasField(int field)
		{
			return default(bool);
		}

		public void WriteTo(CodedOutputStream output)
		{
		}

		public int CalculateSize()
		{
			return default(int);
		}

		public override bool Equals(object other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		private UnknownField GetOrAddField(int number)
		{
			return null;
		}

		internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field)
		{
			return null;
		}

		private bool MergeFieldFrom(CodedInputStream input)
		{
			return default(bool);
		}

		public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, CodedInputStream input)
		{
			return null;
		}

		private UnknownFieldSet MergeFrom(UnknownFieldSet other)
		{
			return null;
		}

		public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other)
		{
			return null;
		}

		private UnknownFieldSet MergeField(int number, UnknownField field)
		{
			return null;
		}

		public static UnknownFieldSet Clone(UnknownFieldSet other)
		{
			return null;
		}
	}
}
