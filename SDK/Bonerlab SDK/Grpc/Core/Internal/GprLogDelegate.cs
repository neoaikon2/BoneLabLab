using System;

namespace Grpc.Core.Internal
{
	internal delegate void GprLogDelegate(IntPtr fileStringPtr, int line, ulong threadId, IntPtr severityStringPtr, IntPtr msgPtr);
}
