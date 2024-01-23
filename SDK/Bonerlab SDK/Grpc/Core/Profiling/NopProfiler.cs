namespace Grpc.Core.Profiling
{
	internal class NopProfiler : IProfiler
	{
		public void Begin(string tag)
		{
		}

		public void End(string tag)
		{
		}

		public NopProfiler()
			: base()
		{
		}
	}
}
