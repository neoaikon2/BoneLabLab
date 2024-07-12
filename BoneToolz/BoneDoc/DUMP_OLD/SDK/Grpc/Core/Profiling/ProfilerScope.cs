using System;

namespace Grpc.Core.Profiling
{
	internal struct ProfilerScope : IDisposable
	{
		private readonly IProfiler profiler;

		private readonly string tag;

		public ProfilerScope(IProfiler profiler, string tag)
		{
			this.tag = default(string);
			this.profiler = default(IProfiler);
		}

		public void Dispose()
		{
		}
	}
}
