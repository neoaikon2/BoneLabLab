using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class MessageOptions : IExtendableMessage<MessageOptions>, IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>
	{
		private static readonly MessageParser<MessageOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<MessageOptions> _extensions;

		private int _hasBits0;

		private static readonly bool MessageSetWireFormatDefaultValue;

		private bool messageSetWireFormat_;

		private static readonly bool NoStandardDescriptorAccessorDefaultValue;

		private bool noStandardDescriptorAccessor_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool MapEntryDefaultValue;

		private bool mapEntry_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<MessageOptions> Parser
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
		public bool MessageSetWireFormat
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
		public bool HasMessageSetWireFormat
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool NoStandardDescriptorAccessor
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
		public bool HasNoStandardDescriptorAccessor
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool Deprecated
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
		public bool HasDeprecated
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool MapEntry
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
		public bool HasMapEntry
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public MessageOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public MessageOptions(MessageOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public MessageOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(MessageOptions other)
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
		public void MergeFrom(MessageOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
