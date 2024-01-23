using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class Server
	{
		private static readonly ILogger Logger;

		private readonly AtomicCounter activeCallCounter;

		private readonly GrpcEnvironment environment;

		private readonly ServerSafeHandle handle;

		private readonly object myLock;

		private readonly TaskCompletionSource<object> shutdownTcs;

		private bool shutdownRequested;

		public Task KillAsync()
		{
			return null;
		}

		private Task ShutdownInternalAsync(bool kill)
		{
			return null;
		}

		private Task ShutdownCompleteOrEnvironmentDeadAsync()
		{
			return null;
		}

		private void DisposeHandle()
		{
		}

		private void HandleServerShutdown(bool success, BatchContextSafeHandle ctx, object state)
		{
		}

		public Server()
			: base()
		{
		}
	}
}
