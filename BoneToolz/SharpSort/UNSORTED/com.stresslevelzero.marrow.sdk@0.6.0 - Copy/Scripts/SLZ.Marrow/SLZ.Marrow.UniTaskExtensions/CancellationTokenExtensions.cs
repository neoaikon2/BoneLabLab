using System.Runtime.CompilerServices;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.UniTaskExtensions
{
	[PublicAPI]
	public static class CancellationTokenExtensions
	{
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationToken token)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationTokenSource cts)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationToken token2)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationTokenSource cts2)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationToken[] tokens)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationToken[] tokens)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationTokenSource[] tokenSources)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationTokenSource[] tokenSources)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithOnDestroy(this CancellationTokenSource cts, Component component)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationTokenSource WithOnDestroy(this CancellationToken token, Component component)
		{
			return null;
		}

		[MethodImpl(256)]
		public static CancellationToken WithOnDestroyToken(this CancellationToken token, Component component)
		{
			return default(CancellationToken);
		}

		[MethodImpl(256)]
		public static CancellationToken WithOnDestroyToken(this CancellationTokenSource cts, Component component)
		{
			return default(CancellationToken);
		}

		[MethodImpl(256)]
		public static void CancelAndReplace(ref CancellationTokenSource cts)
		{
		}
	}
}
