namespace Grpc.Core
{
	public class WriteOptions
	{
		public static readonly WriteOptions Default;

		private readonly WriteFlags flags;

		public WriteFlags Flags
		{
			get
			{
				return default(WriteFlags);
			}
		}

		public WriteOptions(WriteFlags flags = (WriteFlags)0)
			: base()
		{
		}
	}
}
