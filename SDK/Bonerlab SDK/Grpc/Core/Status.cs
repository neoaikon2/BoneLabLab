namespace Grpc.Core
{
	public struct Status
	{
		public static readonly Status DefaultSuccess;

		public static readonly Status DefaultCancelled;

		private readonly StatusCode statusCode;

		private readonly string detail;

		public StatusCode StatusCode
		{
			get
			{
				return default(StatusCode);
			}
		}

		public string Detail
		{
			get
			{
				return null;
			}
		}

		public Status(StatusCode statusCode, string detail)
		{
			this.detail = default(string);
			this.statusCode = default(StatusCode);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
