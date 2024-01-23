using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>
	{
		private static readonly MessageParser<ServiceOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<ServiceOptions> _extensions;

		private int _hasBits0;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<ServiceOptions> Parser
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
		public ServiceOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public ServiceOptions(ServiceOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public ServiceOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(ServiceOptions other)
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
		public void MergeFrom(ServiceOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
