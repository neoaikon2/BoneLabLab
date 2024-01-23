using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>
			{
				private static readonly MessageParser<Annotation> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				private static readonly string SourceFileDefaultValue;

				private string sourceFile_;

				private static readonly int BeginDefaultValue;

				private int begin_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<Annotation> Parser
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
				public string SourceFile
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
				public bool HasSourceFile
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public int Begin
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
				public bool HasBegin
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
				public Annotation()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public Annotation(Annotation other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public Annotation Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(Annotation other)
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
				public void MergeFrom(Annotation other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<GeneratedCodeInfo> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec;

		private readonly RepeatedField<Types.Annotation> annotation_;

		[DebuggerNonUserCode]
		public static MessageParser<GeneratedCodeInfo> Parser
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
		public GeneratedCodeInfo()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo(GeneratedCodeInfo other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(GeneratedCodeInfo other)
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
		public void MergeFrom(GeneratedCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
