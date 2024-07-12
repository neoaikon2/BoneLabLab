using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core.Logging;
using Grpc.Core.Profiling;

namespace Grpc.Core.Internal
{
	internal class GrpcThreadPool
	{
		private static readonly ILogger Logger;

		private readonly GrpcEnvironment environment;

		private readonly object myLock;

		private readonly List<Thread> threads;

		private readonly int poolSize;

		private readonly int completionQueueCount;

		private readonly bool inlineHandlers;

		private readonly WaitCallback runCompletionQueueEventCallbackSuccess;

		private readonly WaitCallback runCompletionQueueEventCallbackFailure;

		private readonly AtomicCounter queuedContinuationCounter;

		private readonly List<BasicProfiler> threadProfilers;

		private bool stopRequested;

		private IReadOnlyCollection<CompletionQueueSafeHandle> completionQueues;

		internal bool IsAlive
		{
			get
			{
				return default(bool);
			}
		}

		internal IReadOnlyCollection<CompletionQueueSafeHandle> CompletionQueues
		{
			get
			{
				return null;
			}
		}

		public GrpcThreadPool(GrpcEnvironment environment, int poolSize, int completionQueueCount, bool inlineHandlers)
			: base()
		{
		}

		public void Start()
		{
		}

		public Task StopAsync()
		{
			return null;
		}

		private Thread CreateAndStartThread(int threadIndex, IProfiler optionalProfiler)
		{
			return null;
		}

		private void RunHandlerLoop(CompletionQueueSafeHandle cq, IProfiler optionalProfiler)
		{
		}

		private static IReadOnlyCollection<CompletionQueueSafeHandle> CreateCompletionQueueList(GrpcEnvironment environment, int completionQueueCount)
		{
			return null;
		}

		private void RunCompletionQueueEventCallback(IOpCompletionCallback callback, bool success)
		{
		}
	}
}
