using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IMessage<EnumValueOptions>, IMessage, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>
	{
		private static readonly MessageParser<EnumValueOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<EnumValueOptions> _extensions;

		private int _hasBits0;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumValueOptions> Parser
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
		public EnumValueOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueOptions(EnumValueOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValueOptions other)
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
		public void MergeFrom(EnumValueOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
