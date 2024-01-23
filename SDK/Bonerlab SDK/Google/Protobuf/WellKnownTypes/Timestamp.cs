using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, ICustomDiagnosticMessage, IComparable<Timestamp>
	{
		private static readonly MessageParser<Timestamp> _parser;

		private UnknownFieldSet _unknownFields;

		private long seconds_;

		private int nanos_;

		private static readonly DateTime UnixEpoch;

		[DebuggerNonUserCode]
		public static MessageParser<Timestamp> Parser
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
		public long Seconds
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int Nanos
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
		public Timestamp()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Timestamp(Timestamp other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Timestamp Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Timestamp other)
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
		public void MergeFrom(Timestamp other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		private static bool IsNormalized(long seconds, int nanoseconds)
		{
			return default(bool);
		}

		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			return null;
		}

		public int CompareTo(Timestamp other)
		{
			return default(int);
		}

		public static bool operator ==(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		public static bool operator !=(Timestamp a, Timestamp b)
		{
			return default(bool);
		}

		public string ToDiagnosticString()
		{
			return null;
		}
	}
}
