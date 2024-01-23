using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class EnumReservedRange : IMessage<EnumReservedRange>, IMessage, IEquatable<EnumReservedRange>, IDeepCloneable<EnumReservedRange>
			{
				private static readonly MessageParser<EnumReservedRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<EnumReservedRange> Parser
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
				public int Start
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
				public bool HasStart
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public int End
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
				public bool HasEnd
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public EnumReservedRange()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public EnumReservedRange(EnumReservedRange other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public EnumReservedRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(EnumReservedRange other)
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
				public void MergeFrom(EnumReservedRange other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<EnumDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec;

		private readonly RepeatedField<EnumValueDescriptorProto> value_;

		private EnumOptions options_;

		private static readonly FieldCodec<Types.EnumReservedRange> _repeated_reservedRange_codec;

		private readonly RepeatedField<Types.EnumReservedRange> reservedRange_;

		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		private readonly RepeatedField<string> reservedName_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumDescriptorProto> Parser
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
		public RepeatedField<EnumValueDescriptorProto> Value
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public EnumOptions Options
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
		public EnumDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto(EnumDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumDescriptorProto other)
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
		public void MergeFrom(EnumDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
