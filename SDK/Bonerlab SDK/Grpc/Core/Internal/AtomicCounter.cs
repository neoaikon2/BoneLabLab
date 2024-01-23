namespace Grpc.Core.Internal
{
	internal class AtomicCounter
	{
		private long counter;

		public long Count
		{
			get
			{
				return default(long);
			}
		}

		public AtomicCounter(long initialCount = 0L)
			: base()
		{
		}

		public long Increment()
		{
			return default(long);
		}

		public void IncrementIfNonzero(bool success)
		{
		}

		public long Decrement()
		{
			return default(long);
		}
	}
}
