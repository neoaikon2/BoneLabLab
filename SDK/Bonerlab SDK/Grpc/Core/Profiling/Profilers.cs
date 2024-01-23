using System.Threading;

namespace Grpc.Core.Profiling
{
	internal static class Profilers
	{
		private static readonly NopProfiler DefaultProfiler;

		private static readonly ThreadLocal<IProfiler> profilers;

		public static IProfiler ForCurrentThread()
		{
			return null;
		}

		public static void SetForCurrentThread(IProfiler profiler)
		{
		}

		public static ProfilerScope NewScope(this IProfiler profiler, string tag)
		{
			return default(ProfilerScope);
		}
	}
}
