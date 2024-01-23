using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>
	{
		private static readonly MessageParser<Enum> _parser;

		private UnknownFieldSet _unknownFields;

		private string name_;

		private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec;

		private readonly RepeatedField<EnumValue> enumvalue_;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		private SourceContext sourceContext_;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Enum> Parser
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
		public SourceContext SourceContext
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
		public Syntax Syntax
		{
			get
			{
				return default(Syntax);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Enum()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Enum(Enum other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Enum Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Enum other)
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
		public void MergeFrom(Enum other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
