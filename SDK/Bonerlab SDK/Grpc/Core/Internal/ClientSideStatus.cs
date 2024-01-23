namespace Grpc.Core.Internal
{
	internal struct ClientSideStatus
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

		public Metadata Trailers
		{
			get
			{
				return null;
			}
		}

		public ClientSideStatus(Status status, Metadata trailers)
		{
			this.trailers = default(Metadata);
			this.status = default(Status);
		}
	}
}
