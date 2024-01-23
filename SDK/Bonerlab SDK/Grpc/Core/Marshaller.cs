using System;

namespace Grpc.Core
{
	public class Marshaller<T>
	{
		private readonly Func<T, byte[]> serializer;

		private readonly Func<byte[], T> deserializer;

		public Func<T, byte[]> Serializer
		{
			get
			{
				return null;
			}
		}

		public Func<byte[], T> Deserializer
		{
			get
			{
				return null;
			}
		}

		public Marshaller(Func<T, byte[]> serializer, Func<byte[], T> deserializer)
			: base()
		{
		}
	}
}
