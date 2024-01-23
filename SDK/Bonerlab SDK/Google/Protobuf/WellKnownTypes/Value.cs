using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>
	{
		public enum KindOneofCase
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}

		private static readonly MessageParser<Value> _parser;

		private UnknownFieldSet _unknownFields;

		private object kind_;

		private KindOneofCase kindCase_;

		[DebuggerNonUserCode]
		public static MessageParser<Value> Parser
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
		public NullValue NullValue
		{
			get
			{
				return default(NullValue);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double NumberValue
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string StringValue
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
		public bool BoolValue
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
		public Struct StructValue
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
		public ListValue ListValue
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
		public KindOneofCase KindCase
		{
			get
			{
				return default(KindOneofCase);
			}
		}

		[DebuggerNonUserCode]
		public Value()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Value(Value other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Value Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Value other)
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
		public void MergeFrom(Value other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
