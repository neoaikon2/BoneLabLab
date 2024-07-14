using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace SLZ.ModIO.API.Utils
{
	public sealed class APIThrottler
	{
		public sealed class ThrottleSentinel : IDisposable
		{
			private readonly APIThrottler _throttler;

			private readonly CancellationToken _cancellationToken;

			private int _isDisposing;

			private ThrottleSentinel(APIThrottler throttler, CancellationToken cancellationToken = default(CancellationToken))
			{
			}
			public static Task<IDisposable> WaitAsync(APIThrottler throttler, CancellationToken cancellationToken)
			{
				return null;
			}

			~ThrottleSentinel()
			{
			}

			public void Dispose()
			{
			}
		}
		private readonly SemaphoreSlim _semaphore;

		[PublicAPI]
		public int MaxCount { get; set; }

		public APIThrottler(int maxCount)
		{
		}
		[PublicAPI]
		public void SetMaxCount(int value, TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		[PublicAPI]
		public int Release()
		{
			return 0;
		}

		[PublicAPI]
		public Task WaitAsync()
		{
			return null;
		}

		[PublicAPI]
		public Task WaitAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[PublicAPI]
		public Task<bool> WaitAsync(int millisecondsTimeout)
		{
			return null;
		}

		[PublicAPI]
		public Task<bool> WaitAsync(TimeSpan timeout)
		{
			return null;
		}

		[PublicAPI]
		public Task<bool> WaitAsync(TimeSpan timeout, CancellationToken cancellationToken)
		{
			return null;
		}

		[PublicAPI]
		public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return null;
		}

		[PublicAPI]
		public void Wait()
		{
		}

		[PublicAPI]
		public void Wait(CancellationToken cancellationToken)
		{
		}

		[PublicAPI]
		public void Wait(TimeSpan timeout)
		{
		}

		[PublicAPI]
		public void Wait(TimeSpan timeout, CancellationToken cancellationToken)
		{
		}

		[PublicAPI]
		public void Wait(int millisecondsTimeout)
		{
		}

		[PublicAPI]
		public void Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
		}

		[NotNull]
		public Task<IDisposable> Throttle(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
