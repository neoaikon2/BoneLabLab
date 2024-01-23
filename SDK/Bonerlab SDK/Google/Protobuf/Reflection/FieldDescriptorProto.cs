using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum Type
			{
				[OriginalName("TYPE_DOUBLE")]
				Double = 1,
				[OriginalName("TYPE_FLOAT")]
				Float = 2,
				[OriginalName("TYPE_INT64")]
				Int64 = 3,
				[OriginalName("TYPE_UINT64")]
				Uint64 = 4,
				[OriginalName("TYPE_INT32")]
				Int32 = 5,
				[OriginalName("TYPE_FIXED64")]
				Fixed64 = 6,
				[OriginalName("TYPE_FIXED32")]
				Fixed32 = 7,
				[OriginalName("TYPE_BOOL")]
				Bool = 8,
				[OriginalName("TYPE_STRING")]
				String = 9,
				[OriginalName("TYPE_GROUP")]
				Group = 10,
				[OriginalName("TYPE_MESSAGE")]
				Message = 11,
				[OriginalName("TYPE_BYTES")]
				Bytes = 12,
				[OriginalName("TYPE_UINT32")]
				Uint32 = 13,
				[OriginalName("TYPE_ENUM")]
				Enum = 14,
				[OriginalName("TYPE_SFIXED32")]
				Sfixed32 = 15,
				[OriginalName("TYPE_SFIXED64")]
				Sfixed64 = 16,
				[OriginalName("TYPE_SINT32")]
				Sint32 = 17,
				[OriginalName("TYPE_SINT64")]
				Sint64 = 18
			}

			internal enum Label
			{
				[OriginalName("LABEL_OPTIONAL")]
				Optional = 1,
				[OriginalName("LABEL_REQUIRED")]
				Required = 2,
				[OriginalName("LABEL_REPEATED")]
				Repeated = 3
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly int NumberDefaultValue;

		private int number_;

		private static readonly Types.Label LabelDefaultValue;

		private Types.Label label_;

		private static readonly Types.Type TypeDefaultValue;

		private Types.Type type_;

		private static readonly string TypeNameDefaultValue;

		private string typeName_;

		private static readonly string ExtendeeDefaultValue;

		private string extendee_;

		private static readonly string DefaultValueDefaultValue;

		private string defaultValue_;

		private static readonly int OneofIndexDefaultValue;

		private int oneofIndex_;

		private static readonly string JsonNameDefaultValue;

		private string jsonName_;

		private FieldOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldDescriptorProto> Parser
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
		public bool HasName
		{
			get
			{
				return default(bool);
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
		public bool HasNumber
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public Types.Label Label
		{
			get
			{
				return default(Types.Label);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasLabel
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public Types.Type Type
		{
			get
			{
				return default(Types.Type);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string TypeName
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
		public bool HasTypeName
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string Extendee
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
		public bool HasExtendee
		{
			get
			{
				return default(bool);
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
		public bool HasDefaultValue
		{
			get
			{
				return default(bool);
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
		public bool HasOneofIndex
		{
			get
			{
				return default(bool);
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
		public bool HasJsonName
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public FieldOptions Options
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
		public bool HasOptions
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto(FieldDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldDescriptorProto other)
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
		public void MergeFrom(FieldDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
