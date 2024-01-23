using System;

namespace Grpc.Core
{
	[Flags]
	internal enum ContextPropagationFlags
	{
		Deadline = 1,
		CensusStatsContext = 2,
		CensusTracingContext = 4,
		Cancellation = 8
	}
}
