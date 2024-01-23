using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<FieldMask> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly FieldCodec<string> _repeated_paths_codec;

		private readonly RepeatedField<string> paths_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldMask> Parser
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
		public RepeatedField<string> Paths
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FieldMask()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public FieldMask(FieldMask other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public FieldMask Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldMask other)
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
		public void MergeFrom(FieldMask other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		internal static string ToJson(IList<string> paths, bool diagnosticOnly)
		{
			return null;
		}

		public string ToDiagnosticString()
		{
			return null;
		}

		private static bool IsPathValid(string input)
		{
			return default(bool);
		}
	}
}
