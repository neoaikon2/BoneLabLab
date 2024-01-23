namespace Grpc.Core.Profiling
{
	internal interface IProfiler
	{
		void Begin(string tag);

		void End(string tag);
	}
}
