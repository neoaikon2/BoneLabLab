using System.IO;

namespace Google.Protobuf
{
	public sealed class InvalidProtocolBufferException : IOException
	{
		internal InvalidProtocolBufferException(string message)
			: base()
		{
		}

		internal static InvalidProtocolBufferException MoreDataAvailable()
		{
			return null;
		}

		internal static InvalidProtocolBufferException TruncatedMessage()
		{
			return null;
		}

		internal static InvalidProtocolBufferException NegativeSize()
		{
			return null;
		}

		internal static InvalidProtocolBufferException MalformedVarint()
		{
			return null;
		}

		internal static InvalidProtocolBufferException InvalidTag()
		{
			return null;
		}

		internal static InvalidProtocolBufferException InvalidWireType()
		{
			return null;
		}

		internal static InvalidProtocolBufferException RecursionLimitExceeded()
		{
			return null;
		}

		internal static InvalidProtocolBufferException SizeLimitExceeded()
		{
			return null;
		}
	}
}
