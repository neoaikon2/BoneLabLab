using System;

namespace Grpc.Core
{
	[Flags]
	public enum WriteFlags
	{
		BufferHint = 1,
		NoCompress = 2
	}
}
