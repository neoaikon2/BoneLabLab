using System;

namespace Grpc.Core.Internal
{
	internal struct CompletionQueueEvent
	{
		internal enum CompletionType
		{
			Shutdown = 0,
			Timeout = 1,
			OpComplete = 2
		}

		private static readonly NativeMethods Native;

		public CompletionType type;

		public int success;

		public IntPtr tag;
	}
}
