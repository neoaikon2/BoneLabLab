using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class Channel
	{
		private static readonly ILogger Logger;

		private readonly object myLock;

		private readonly AtomicCounter activeCallCounter;

		private readonly CancellationTokenSource shutdownTokenSource;

		private readonly string target;

		private readonly GrpcEnvironment environment;

		private readonly CompletionQueueSafeHandle completionQueue;

		private readonly ChannelSafeHandle handle;

		private readonly Dictionary<string, ChannelOption> options;

		private readonly Task connectivityWatcherTask;

		private bool shutdownRequested;

		private static readonly BatchCompletionDelegate WatchConnectivityStateHandler;

		public ChannelState State
		{
			get
			{
				return default(ChannelState);
			}
		}

		internal ChannelSafeHandle Handle
		{
			get
			{
				return null;
			}
		}

		internal GrpcEnvironment Environment
		{
			get
			{
				return null;
			}
		}

		public Channel(string target, ChannelCredentials credentials)
			: base()
		{
		}

		public Channel(string target, ChannelCredentials credentials, IEnumerable<ChannelOption> options)
			: base()
		{
		}

		internal Task<bool> WaitForStateChangedInternalAsync(ChannelState lastObservedState, DateTime? deadline = default(DateTime?))
		{
			return null;
		}

		public Task ShutdownAsync()
		{
			return null;
		}

		internal void AddCallReference(object call)
		{
		}

		internal void RemoveCallReference(object call)
		{
		}

		private ChannelState GetConnectivityState(bool tryToConnect)
		{
			return default(ChannelState);
		}

		private Task RunConnectivityWatcherAsync()
		{
			return null;
		}

		private static void EnsureUserAgentChannelOption(Dictionary<string, ChannelOption> options)
		{
		}

		private static Dictionary<string, ChannelOption> CreateOptionsDictionary(IEnumerable<ChannelOption> options)
		{
			return null;
		}
	}
}
