using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IMessage, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>
	{
		private static readonly MessageParser<ServiceDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec;

		private readonly RepeatedField<MethodDescriptorProto> method_;

		private ServiceOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<ServiceDescriptorProto> Parser
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
		public RepeatedField<MethodDescriptorProto> Method
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ServiceOptions Options
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
		public ServiceDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public ServiceDescriptorProto(ServiceDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public ServiceDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(ServiceDescriptorProto other)
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
		public void MergeFrom(ServiceDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
