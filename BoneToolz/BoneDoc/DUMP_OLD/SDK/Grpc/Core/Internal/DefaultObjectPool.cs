using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Grpc.Core.Internal
{
	internal class DefaultObjectPool<T> : IObjectPool<T>, IDisposable where T : class, IPooledObject<T>
	{
		private class ThreadLocalData
		{
			public Queue<T> Queue { get; }

			public int CreateBudget { get; set; }

			public int DisposeBudget { get; set; }

			public ThreadLocalData(int capacity)
				: base()
			{
			}
		}

		private readonly object myLock;

		private readonly Action<T> returnAction;

		private readonly Func<T> itemFactory;

		private readonly Queue<T> sharedQueue;

		private readonly int sharedCapacity;

		private readonly ThreadLocal<ThreadLocalData> threadLocalData;

		private readonly int threadLocalCapacity;

		private readonly int rentLimit;

		private bool disposed;

		public DefaultObjectPool(Func<T> itemFactory, int sharedCapacity, int threadLocalCapacity)
			: base()
		{
		}

		public T Lease()
		{
			return null;
		}

		private T LeaseInternal()
		{
			return null;
		}

		public void Return(T item)
		{
		}

		public void Dispose()
		{
		}
	}
}
