using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>
			{
				private static readonly MessageParser<NamePart> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly string NamePart_DefaultValue;

				private string namePart_;

				private static readonly bool IsExtensionDefaultValue;

				private bool isExtension_;

				[DebuggerNonUserCode]
				public static MessageParser<NamePart> Parser
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
				public string NamePart_
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
				public bool HasNamePart_
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public bool IsExtension
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
				public bool HasIsExtension
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public NamePart()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public NamePart(NamePart other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public NamePart Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(NamePart other)
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
				public void MergeFrom(NamePart other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<UninterpretedOption> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec;

		private readonly RepeatedField<Types.NamePart> name_;

		private static readonly string IdentifierValueDefaultValue;

		private string identifierValue_;

		private static readonly ulong PositiveIntValueDefaultValue;

		private ulong positiveIntValue_;

		private static readonly long NegativeIntValueDefaultValue;

		private long negativeIntValue_;

		private static readonly double DoubleValueDefaultValue;

		private double doubleValue_;

		private static readonly ByteString StringValueDefaultValue;

		private ByteString stringValue_;

		private static readonly string AggregateValueDefaultValue;

		private string aggregateValue_;

		[DebuggerNonUserCode]
		public static MessageParser<UninterpretedOption> Parser
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
		public string IdentifierValue
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
		public bool HasIdentifierValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public ulong PositiveIntValue
		{
			get
			{
				return default(ulong);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPositiveIntValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public long NegativeIntValue
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasNegativeIntValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public double DoubleValue
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
		public bool HasDoubleValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public ByteString StringValue
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
		public bool HasStringValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string AggregateValue
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
		public bool HasAggregateValue
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public UninterpretedOption()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption(UninterpretedOption other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(UninterpretedOption other)
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
		public void MergeFrom(UninterpretedOption other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
