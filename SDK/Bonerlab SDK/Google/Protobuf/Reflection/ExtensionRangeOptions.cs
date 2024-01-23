using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IMessage<ExtensionRangeOptions>, IMessage, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>
	{
		private static readonly MessageParser<ExtensionRangeOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<ExtensionRangeOptions> _extensions;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<ExtensionRangeOptions> Parser
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
		public ExtensionRangeOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public ExtensionRangeOptions(ExtensionRangeOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public ExtensionRangeOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(ExtensionRangeOptions other)
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
		public void MergeFrom(ExtensionRangeOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
