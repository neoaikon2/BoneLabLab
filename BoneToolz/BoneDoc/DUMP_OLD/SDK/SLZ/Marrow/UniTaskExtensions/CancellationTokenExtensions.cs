using System;
using System.Runtime.CompilerServices;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.UniTaskExtensions
{
	[PublicAPI]
	public static class CancellationTokenExtensions
	{
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationToken token)
		{
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationTokenSource cts)
		{
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationToken token2)
		{
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationTokenSource cts2)
		{
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationToken[] tokens)
		{
			tokens = default(CancellationToken[]);
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationToken[] tokens)
		{
			tokens = default(CancellationToken[]);
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationTokenSource[] tokenSources)
		{
			tokenSources = default(CancellationTokenSource[]);
			return null;
		}

		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationTokenSource[] tokenSources)
		{
			tokenSources = default(CancellationTokenSource[]);
			return null;
		}

		public static CancellationTokenSource WithOnDestroy(this CancellationTokenSource cts, Component component)
		{
			return null;
		}

		public static CancellationTokenSource WithOnDestroy(this CancellationToken token, Component component)
		{
			return null;
		}

		public static CancellationToken WithOnDestroyToken(this CancellationToken token, Component component)
		{
			return default(CancellationToken);
		}

		public static CancellationToken WithOnDestroyToken(this CancellationTokenSource cts, Component component)
		{
			return default(CancellationToken);
		}

		public static void CancelAndReplace(CancellationTokenSource cts)
		{
		}
	}
}
