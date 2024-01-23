using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>
	{
		private static readonly MessageParser<Struct> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly MapField<string, Value>.Codec _map_fields_codec;

		private readonly MapField<string, Value> fields_;

		[DebuggerNonUserCode]
		public static MessageParser<Struct> Parser
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
		public MapField<string, Value> Fields
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Struct()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Struct(Struct other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Struct Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Struct other)
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
		public void MergeFrom(Struct other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
