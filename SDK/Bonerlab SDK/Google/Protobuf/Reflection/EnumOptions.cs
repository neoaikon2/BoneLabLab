using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using IMessage = Google.Protobuf.IMessage;
namespace Google.Protobuf.Reflection
{
	internal sealed class EnumOptions : IExtendableMessage<EnumOptions>, IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>
	{


		private static readonly MessageParser<EnumOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<EnumOptions> _extensions;

		private int _hasBits0;

		private static readonly bool AllowAliasDefaultValue;

		private bool allowAlias_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumOptions> Parser
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
		public bool AllowAlias
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
		public bool HasAllowAlias
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
		public EnumOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public EnumOptions(EnumOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public EnumOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumOptions other)
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
		public void MergeFrom(EnumOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
