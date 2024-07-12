using System;

namespace Grpc.Core
{
	public static class Marshallers
	{
		public static Marshaller<T> Create<T>(Func<T, byte[]> serializer, Func<byte[], T> deserializer)
		{
			return null;
		}
	}
}
