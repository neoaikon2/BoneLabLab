using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>
	{
		private static readonly MessageParser<EnumValue> _parser;

		private UnknownFieldSet _unknownFields;

		private string name_;

		private int number_;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumValue> Parser
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
		public EnumValue()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public EnumValue(EnumValue other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public EnumValue Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValue other)
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
		public void MergeFrom(EnumValue other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
