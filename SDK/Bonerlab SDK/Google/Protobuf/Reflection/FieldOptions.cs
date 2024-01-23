using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FieldOptions : IExtendableMessage<FieldOptions>, IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum CType
			{
				[OriginalName("STRING")]
				String = 0,
				[OriginalName("CORD")]
				Cord = 1,
				[OriginalName("STRING_PIECE")]
				StringPiece = 2
			}

			internal enum JSType
			{
				[OriginalName("JS_NORMAL")]
				JsNormal = 0,
				[OriginalName("JS_STRING")]
				JsString = 1,
				[OriginalName("JS_NUMBER")]
				JsNumber = 2
			}
		}

		private static readonly MessageParser<FieldOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<FieldOptions> _extensions;

		private int _hasBits0;

		private static readonly Types.CType CtypeDefaultValue;

		private Types.CType ctype_;

		private static readonly bool PackedDefaultValue;

		private bool packed_;

		private static readonly Types.JSType JstypeDefaultValue;

		private Types.JSType jstype_;

		private static readonly bool LazyDefaultValue;

		private bool lazy_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool WeakDefaultValue;

		private bool weak_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser
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
		public Types.CType Ctype
		{
			get
			{
				return default(Types.CType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasCtype
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool Packed
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
		public bool HasPacked
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public Types.JSType Jstype
		{
			get
			{
				return default(Types.JSType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJstype
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool Lazy
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
		public bool HasLazy
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
		public bool Weak
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
		public bool HasWeak
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public FieldOptions()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
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
		public void MergeFrom(FieldOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return (TValue)default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return default(bool);
		}
	}
}
