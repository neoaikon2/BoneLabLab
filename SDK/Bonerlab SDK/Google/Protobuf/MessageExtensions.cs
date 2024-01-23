using System.IO;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace Google.Protobuf
{
	public static class MessageExtensions
	{
		public static void MergeFrom(this IMessage message, ByteString data)
		{
		}

		public static byte[] ToByteArray(this IMessage message)
		{
			return null;
		}

		public static void WriteDelimitedTo(this IMessage message, Stream output)
		{
		}

		public static bool IsInitialized(this IMessage message)
		{
			return default(bool);
		}

		internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}

		internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry)
		{
		}
	}
}
