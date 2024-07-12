using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.Extensions.Logging
{
	internal sealed class LoggerFactoryScopeProvider : IExternalScopeProvider
	{
		private sealed class Scope : IDisposable
		{
			private readonly LoggerFactoryScopeProvider _provider;

			private bool _isDisposed;

			public Scope Parent { get; }

			public void Dispose()
			{
			}

			public Scope()
				: base()
			{
			}
		}

		private readonly AsyncLocal<Scope> _currentScope;

		private readonly ActivityTrackingOptions _activityTrackingOption;

		public LoggerFactoryScopeProvider(ActivityTrackingOptions activityTrackingOption)
			: base()
		{
		}
	}
}
