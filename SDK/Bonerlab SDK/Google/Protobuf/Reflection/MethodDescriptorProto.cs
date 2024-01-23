using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>
	{
		private static readonly MessageParser<MethodDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly string InputTypeDefaultValue;

		private string inputType_;

		private static readonly string OutputTypeDefaultValue;

		private string outputType_;

		private MethodOptions options_;

		private static readonly bool ClientStreamingDefaultValue;

		private bool clientStreaming_;

		private static readonly bool ServerStreamingDefaultValue;

		private bool serverStreaming_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodDescriptorProto> Parser
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
		public string InputType
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
		public bool HasInputType
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string OutputType
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
		public bool HasOutputType
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public MethodOptions Options
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
		public bool ClientStreaming
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
		public bool HasClientStreaming
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public bool ServerStreaming
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
		public bool HasServerStreaming
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto(MethodDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodDescriptorProto other)
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
		public void MergeFrom(MethodDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
