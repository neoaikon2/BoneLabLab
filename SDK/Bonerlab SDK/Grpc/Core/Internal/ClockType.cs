namespace Grpc.Core.Internal
{
	internal enum ClockType
	{
		Monotonic = 0,
		Realtime = 1,
		Precise = 2,
		Timespan = 3
	}
}
