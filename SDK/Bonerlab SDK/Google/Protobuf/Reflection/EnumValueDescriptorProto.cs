using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>
	{
		private static readonly MessageParser<EnumValueDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly int NumberDefaultValue;

		private int number_;

		private EnumValueOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumValueDescriptorProto> Parser
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
		public EnumValueOptions Options
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
		public EnumValueDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto(EnumValueDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValueDescriptorProto other)
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
		public void MergeFrom(EnumValueDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
