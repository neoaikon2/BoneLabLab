namespace Grpc.Core.Internal
{
	internal class DebugStats
	{
		public readonly AtomicCounter PendingBatchCompletions;

		public void CheckOK()
		{
		}

		private void DebugWarning(string message)
		{
		}

		public DebugStats()
			: base()
		{
		}
	}
}
