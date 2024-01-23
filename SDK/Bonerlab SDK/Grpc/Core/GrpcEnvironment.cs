using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class GrpcEnvironment
	{
		private static class ShutdownHooks
		{
			private static object staticLock;

			private static bool hooksRegistered;

			public static void Register()
			{
			}

			private static void HandleShutdown()
			{
			}
		}

		private static object staticLock;

		private static GrpcEnvironment instance;

		private static int refCount;

		private static int? customThreadPoolSize;

		private static int? customCompletionQueueCount;

		private static bool inlineHandlers;

		private static int batchContextPoolSharedCapacity;

		private static int batchContextPoolThreadLocalCapacity;

		private static int requestCallContextPoolSharedCapacity;

		private static int requestCallContextPoolThreadLocalCapacity;

		private static readonly HashSet<Channel> registeredChannels;

		private static readonly HashSet<Server> registeredServers;

		private static ILogger logger;

		private readonly IObjectPool<BatchContextSafeHandle> batchContextPool;

		private readonly IObjectPool<RequestCallContextSafeHandle> requestCallContextPool;

		private readonly GrpcThreadPool threadPool;

		private readonly DebugStats debugStats;

		private readonly AtomicCounter cqPickerCounter;

		private bool isShutdown;

		[CompilerGenerated]
		private static EventHandler ShuttingDown;

		public static ILogger Logger
		{
			get
			{
				return null;
			}
		}

		internal IReadOnlyCollection<CompletionQueueSafeHandle> CompletionQueues
		{
			get
			{
				return null;
			}
		}

		internal IObjectPool<BatchContextSafeHandle> BatchContextPool
		{
			get
			{
				return null;
			}
		}

		internal IObjectPool<RequestCallContextSafeHandle> RequestCallContextPool
		{
			get
			{
				return null;
			}
		}

		internal bool IsAlive
		{
			get
			{
				return default(bool);
			}
		}

		internal DebugStats DebugStats
		{
			get
			{
				return null;
			}
		}

		internal static GrpcEnvironment AddRef()
		{
			return null;
		}

		internal static Task ReleaseAsync()
		{
			return null;
		}

		internal static void RegisterChannel(Channel channel)
		{
		}

		internal static void UnregisterChannel(Channel channel)
		{
		}

		internal static void UnregisterServer(Server server)
		{
		}

		public static Task ShutdownChannelsAsync()
		{
			return null;
		}

		public static Task KillServersAsync()
		{
			return null;
		}

		private GrpcEnvironment()
			: base()
		{
		}

		internal CompletionQueueSafeHandle PickCompletionQueue()
		{
			return null;
		}

		internal static void GrpcNativeInit()
		{
		}

		internal static void GrpcNativeShutdown()
		{
		}

		private Task ShutdownAsync()
		{
			return null;
		}

		private int GetThreadPoolSizeOrDefault()
		{
			return default(int);
		}

		private int GetCompletionQueueCountOrDefault()
		{
			return default(int);
		}
	}
}
