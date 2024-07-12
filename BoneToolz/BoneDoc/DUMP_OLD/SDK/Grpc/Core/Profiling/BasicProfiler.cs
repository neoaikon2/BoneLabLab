using System.IO;

namespace Grpc.Core.Profiling
{
	internal class BasicProfiler : IProfiler
	{
		private ProfilerEntry[] entries;

		private int count;

		public void Begin(string tag)
		{
		}

		public void End(string tag)
		{
		}

		public void Dump(string filepath)
		{
		}

		public void Dump(TextWriter stream)
		{
		}

		private void AddEntry(ProfilerEntry entry)
		{
		}

		public BasicProfiler()
			: base()
		{
		}
	}
}
