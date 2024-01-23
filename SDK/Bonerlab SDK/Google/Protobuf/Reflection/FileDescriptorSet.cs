using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FileDescriptorSet : IMessage<FileDescriptorSet>, IMessage, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>
	{
		private static readonly MessageParser<FileDescriptorSet> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec;

		private readonly RepeatedField<FileDescriptorProto> file_;

		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorSet> Parser
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
		public FileDescriptorSet()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorSet(FileDescriptorSet other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorSet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorSet other)
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
		public void MergeFrom(FileDescriptorSet other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
