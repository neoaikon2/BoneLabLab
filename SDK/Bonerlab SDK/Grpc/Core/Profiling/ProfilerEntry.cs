using Grpc.Core.Internal;

namespace Grpc.Core.Profiling
{
	internal struct ProfilerEntry
	{
		public enum Type
		{
			BEGIN = 0,
			END = 1,
			MARK = 2
		}

		public Timespec timespec;

		public Type type;

		public string tag;

		public ProfilerEntry(Timespec timespec, Type type, string tag)
		{
			this.tag = default(string);
			this.type = default(Type);
			this.timespec = default(Timespec);
		}

		public override string ToString()
		{
			return null;
		}

		internal static string GetTypeAbbreviation(Type type)
		{
			return null;
		}
	}
}
