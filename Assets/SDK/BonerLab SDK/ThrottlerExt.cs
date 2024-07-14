using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

public static class ThrottlerExt
{
	private class Throttler : IDisposable
	{
		private readonly SemaphoreSlim _throttler;

		public Throttler(SemaphoreSlim throttler)
		{
		}

		public void Dispose()
		{
		}
	}
	public static UniTask<IDisposable> Throttle(this SemaphoreSlim throttler)
	{
		return default(UniTask<IDisposable>);
	}
}
