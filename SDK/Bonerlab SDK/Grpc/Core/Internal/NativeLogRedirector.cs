using System;

namespace Grpc.Core.Internal
{
	internal static class NativeLogRedirector
	{
		private static object staticLock;

		private static GprLogDelegate writeCallback;

		public static void Redirect(NativeMethods native)
		{
		}

		private static void HandleWrite(IntPtr fileStringPtr, int line, ulong threadId, IntPtr severityStringPtr, IntPtr msgPtr)
		{
		}
	}
}
