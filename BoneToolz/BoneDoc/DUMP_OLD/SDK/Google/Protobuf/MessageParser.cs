using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf
{
	public class MessageParser
	{
		private Func<IMessage> factory;

		internal bool DiscardUnknownFields { get; }

		internal ExtensionRegistry Extensions { get; }

		internal MessageParser(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions)
			: base()
		{
		}

		public IMessage ParseFrom(ByteString data)
		{
			return null;
		}

		internal static void CheckMergedRequiredFields(IMessage message)
		{
		}
	}
	public sealed class MessageParser<T> : MessageParser where T : IMessage<T>
	{
		private readonly Func<T> factory;

		public MessageParser(Func<T> factory)
			: this(factory, default(System.Boolean), default(Google.Protobuf.ExtensionRegistry))
		{
		}

		internal MessageParser(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions)
			: this(factory)
		{
		}

		internal T CreateTemplate()
		{
			return (T)default(T);
		}

		public T ParseFrom(byte[] data)
		{
			return (T)default(T);
		}

		public MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry)
		{
			return null;
		}
	}
}
