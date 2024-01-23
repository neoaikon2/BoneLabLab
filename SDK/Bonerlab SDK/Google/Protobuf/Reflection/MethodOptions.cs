using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class MethodOptions : IExtendableMessage<MethodOptions>, IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum IdempotencyLevel
			{
				[OriginalName("IDEMPOTENCY_UNKNOWN")]
				IdempotencyUnknown = 0,
				[OriginalName("NO_SIDE_EFFECTS")]
				NoSideEffects = 1,
				[OriginalName("IDEMPOTENT")]
				Idempotent = 2
			}
		}

		private static readonly MessageParser<MethodOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<MethodOptions> _extensions;

		private int _hasBits0;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly Types.IdempotencyLevel IdempotencyLevelDefaultValue;

		private Types.IdempotencyLevel idempotencyLevel_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodOptions> Parser
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
		public Types.IdempotencyLevel IdempotencyLevel
		{
			get
			{
				return default(Types.IdempotencyLevel);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasIdempotencyLevel
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public MethodOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public MethodOptions(MethodOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public MethodOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodOptions other)
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
		public void MergeFrom(MethodOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
