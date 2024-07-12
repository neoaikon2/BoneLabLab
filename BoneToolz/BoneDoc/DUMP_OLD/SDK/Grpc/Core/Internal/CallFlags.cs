using System;

namespace Grpc.Core.Internal
{
	[Flags]
	internal enum CallFlags
	{
		IdempotentRequest = 0x10,
		WaitForReady = 0x20,
		CacheableRequest = 0x40
	}
}
