using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>
	{
		private static readonly MessageParser<Any> _parser;

		private UnknownFieldSet _unknownFields;

		private string typeUrl_;

		private ByteString value_;

		[DebuggerNonUserCode]
		public static MessageParser<Any> Parser
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
		public string TypeUrl
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
		public ByteString Value
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
		public Any()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Any(Any other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Any Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Any other)
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
		public void MergeFrom(Any other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		public static string GetTypeName(string typeUrl)
		{
			return null;
		}

		public bool Is(MessageDescriptor descriptor)
		{
			return default(bool);
		}

		public T Unpack<T>() where T : IMessage, new()
		{
			return (T)default(T);
		}
	}
}
