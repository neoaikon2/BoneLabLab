namespace Grpc.Core
{
	public enum ChannelState
	{
		Idle = 0,
		Connecting = 1,
		Ready = 2,
		TransientFailure = 3,
		Shutdown = 4
	}
}
