using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Kind
			{
				[OriginalName("TYPE_UNKNOWN")]
				TypeUnknown = 0,
				[OriginalName("TYPE_DOUBLE")]
				TypeDouble = 1,
				[OriginalName("TYPE_FLOAT")]
				TypeFloat = 2,
				[OriginalName("TYPE_INT64")]
				TypeInt64 = 3,
				[OriginalName("TYPE_UINT64")]
				TypeUint64 = 4,
				[OriginalName("TYPE_INT32")]
				TypeInt32 = 5,
				[OriginalName("TYPE_FIXED64")]
				TypeFixed64 = 6,
				[OriginalName("TYPE_FIXED32")]
				TypeFixed32 = 7,
				[OriginalName("TYPE_BOOL")]
				TypeBool = 8,
				[OriginalName("TYPE_STRING")]
				TypeString = 9,
				[OriginalName("TYPE_GROUP")]
				TypeGroup = 10,
				[OriginalName("TYPE_MESSAGE")]
				TypeMessage = 11,
				[OriginalName("TYPE_BYTES")]
				TypeBytes = 12,
				[OriginalName("TYPE_UINT32")]
				TypeUint32 = 13,
				[OriginalName("TYPE_ENUM")]
				TypeEnum = 14,
				[OriginalName("TYPE_SFIXED32")]
				TypeSfixed32 = 15,
				[OriginalName("TYPE_SFIXED64")]
				TypeSfixed64 = 16,
				[OriginalName("TYPE_SINT32")]
				TypeSint32 = 17,
				[OriginalName("TYPE_SINT64")]
				TypeSint64 = 18
			}

			public enum Cardinality
			{
				[OriginalName("CARDINALITY_UNKNOWN")]
				Unknown = 0,
				[OriginalName("CARDINALITY_OPTIONAL")]
				Optional = 1,
				[OriginalName("CARDINALITY_REQUIRED")]
				Required = 2,
				[OriginalName("CARDINALITY_REPEATED")]
				Repeated = 3
			}
		}

		private static readonly MessageParser<Field> _parser;

		private UnknownFieldSet _unknownFields;

		private Types.Kind kind_;

		private Types.Cardinality cardinality_;

		private int number_;

		private string name_;

		private string typeUrl_;

		private int oneofIndex_;

		private bool packed_;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		private string jsonName_;

		private string defaultValue_;

		[DebuggerNonUserCode]
		public static MessageParser<Field> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Types.Kind Kind
		{
			get
			{
				return default(Types.Kind);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Types.Cardinality Cardinality
		{
			get
			{
				return default(Types.Cardinality);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string TypeUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int OneofIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Packed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string JsonName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Field()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Field(Field other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Field Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Field other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return default(int);
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return default(int);
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Field other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
