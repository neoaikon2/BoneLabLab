using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>
	{
		private static readonly MessageParser<FileDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly string PackageDefaultValue;

		private string package_;

		private static readonly FieldCodec<string> _repeated_dependency_codec;

		private readonly RepeatedField<string> dependency_;

		private static readonly FieldCodec<int> _repeated_publicDependency_codec;

		private readonly RepeatedField<int> publicDependency_;

		private static readonly FieldCodec<int> _repeated_weakDependency_codec;

		private readonly RepeatedField<int> weakDependency_;

		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec;

		private readonly RepeatedField<DescriptorProto> messageType_;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec;

		private readonly RepeatedField<ServiceDescriptorProto> service_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_;

		private FileOptions options_;

		private SourceCodeInfo sourceCodeInfo_;

		private static readonly string SyntaxDefaultValue;

		private string syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorProto> Parser
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
		public string Package
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
		public bool HasPackage
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<string> Dependency
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> PublicDependency
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> MessageType
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
		public RepeatedField<ServiceDescriptorProto> Service
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
		public FileOptions Options
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
		public SourceCodeInfo SourceCodeInfo
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
		public bool HasSourceCodeInfo
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public string Syntax
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
		public bool HasSyntax
		{
			get
			{
				return default(bool);
			}
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto(FileDescriptorProto other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorProto other)
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
		public void MergeFrom(FileDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
