using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Option : IMessage<Option>, IMessage, IEquatable<Option>, IDeepCloneable<Option>
	{
		private static readonly MessageParser<Option> _parser;

		private UnknownFieldSet _unknownFields;

		private string name_;

		private Any value_;

		[DebuggerNonUserCode]
		public static MessageParser<Option> Parser
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
		public Any Value
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
		public Option()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Option(Option other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Option Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Option other)
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
		public void MergeFrom(Option other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
