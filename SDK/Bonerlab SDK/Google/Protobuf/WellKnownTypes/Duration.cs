using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, ICustomDiagnosticMessage
	{
		private static readonly MessageParser<Duration> _parser;

		private UnknownFieldSet _unknownFields;

		private long seconds_;

		private int nanos_;

		[DebuggerNonUserCode]
		public static MessageParser<Duration> Parser
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
		public Duration()
			: base()
		{
		}

		[DebuggerNonUserCode]
		public Duration(Duration other)
			: this()
		{
		}

		[DebuggerNonUserCode]
		public Duration Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[DebuggerNonUserCode]
		public bool Equals(Duration other)
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
		public void MergeFrom(Duration other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		internal static bool IsNormalized(long seconds, int nanoseconds)
		{
			return default(bool);
		}

		internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly)
		{
			return null;
		}

		public string ToDiagnosticString()
		{
			return null;
		}

		internal static void AppendNanoseconds(StringBuilder builder, int nanos)
		{
		}
	}
}
