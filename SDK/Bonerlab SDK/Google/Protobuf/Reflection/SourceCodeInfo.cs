using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>
			{
				private static readonly MessageParser<Location> _parser;

				private UnknownFieldSet _unknownFields;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				private static readonly FieldCodec<int> _repeated_span_codec;

				private readonly RepeatedField<int> span_;

				private static readonly string LeadingCommentsDefaultValue;

				private string leadingComments_;

				private static readonly string TrailingCommentsDefaultValue;

				private string trailingComments_;

				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

				private readonly RepeatedField<string> leadingDetachedComments_;

				[DebuggerNonUserCode]
				public static MessageParser<Location> Parser
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
				public RepeatedField<int> Path
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public RepeatedField<int> Span
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public string LeadingComments
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
				public bool HasLeadingComments
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public string TrailingComments
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
				public bool HasTrailingComments
				{
					get
					{
						return default(bool);
					}
				}

				[DebuggerNonUserCode]
				public RepeatedField<string> LeadingDetachedComments
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public Location()
					: base()
				{
				}

				[DebuggerNonUserCode]
				public Location(Location other)
					: this()
				{
				}

				[DebuggerNonUserCode]
				public Location Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[DebuggerNonUserCode]
				public bool Equals(Location other)
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
				public void MergeFrom(Location other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<SourceCodeInfo> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<Types.Location> _repeated_location_codec;

		private readonly RepeatedField<Types.Location> location_;

		[DebuggerNonUserCode]
		public static MessageParser<SourceCodeInfo> Parser
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
		public RepeatedField<Types.Location> Location
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo(SourceCodeInfo other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(SourceCodeInfo other)
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
		public void MergeFrom(SourceCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
