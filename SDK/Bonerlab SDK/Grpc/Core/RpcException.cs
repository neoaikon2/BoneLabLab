using System;

namespace Grpc.Core
{
	public class RpcException : Exception
	{
		private readonly Status status;

		private readonly Metadata trailers;

		public Status Status
		{
			get
			{
				return default(Status);
			}
		}

		public RpcException(Status status, Metadata trailers)
			: base()
		{
		}
	}
}
