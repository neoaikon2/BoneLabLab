using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class ExtensionRange : IMessage<ExtensionRange>, IMessage, IEquatable<ExtensionRange>, IDeepCloneable<ExtensionRange>
			{
				private static readonly MessageParser<ExtensionRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				private ExtensionRangeOptions options_;

				[DebuggerNonUserCode]
				public static MessageParser<ExtensionRange> Parser
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
				public ExtensionRangeOptions Options
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
				public ExtensionRange()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public ExtensionRange(ExtensionRange other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public ExtensionRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(ExtensionRange other)
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
				public void MergeFrom(ExtensionRange other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}

			internal sealed class ReservedRange : IMessage<ReservedRange>, IMessage, IEquatable<ReservedRange>, IDeepCloneable<ReservedRange>
			{
				private static readonly MessageParser<ReservedRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<ReservedRange> Parser
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
				public ReservedRange()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public ReservedRange(ReservedRange other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public ReservedRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(ReservedRange other)
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
				public void MergeFrom(ReservedRange other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<DescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec;

		private readonly RepeatedField<FieldDescriptorProto> field_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_;

		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec;

		private readonly RepeatedField<DescriptorProto> nestedType_;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec;

		private readonly RepeatedField<Types.ExtensionRange> extensionRange_;

		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec;

		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_;

		private MessageOptions options_;

		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec;

		private readonly RepeatedField<Types.ReservedRange> reservedRange_;

		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		private readonly RepeatedField<string> reservedName_;

		[DebuggerNonUserCode]
		public static MessageParser<DescriptorProto> Parser
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
		public RepeatedField<FieldDescriptorProto> Field
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> NestedType
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<OneofDescriptorProto> OneofDecl
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MessageOptions Options
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
		public DescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public DescriptorProto(DescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public DescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(DescriptorProto other)
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
		public void MergeFrom(DescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
