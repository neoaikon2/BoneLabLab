using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Logging
{
	public class LoggerFactory : ILoggerFactory, IDisposable
	{
		private struct ProviderRegistration
		{
			public ILoggerProvider Provider;

			public bool ShouldDispose;
		}

		private readonly Dictionary<string, Logger> _loggers;

		private readonly List<ProviderRegistration> _providerRegistrations;

		private readonly object _sync;

		private bool _disposed;

		private IDisposable _changeTokenRegistration;

		private LoggerFilterOptions _filterOptions;

		private LoggerFactoryScopeProvider _scopeProvider;

		private LoggerFactoryOptions _factoryOptions;

		public LoggerFactory()
			: base()
		{
		}

		public LoggerFactory(IEnumerable<ILoggerProvider> providers)
			: this()
		{
		}

		public LoggerFactory(IEnumerable<ILoggerProvider> providers, LoggerFilterOptions filterOptions)
			: this()
		{
		}

		public LoggerFactory(IEnumerable<ILoggerProvider> providers, IOptionsMonitor<LoggerFilterOptions> filterOption)
			: this()
		{
		}

		public LoggerFactory(IEnumerable<ILoggerProvider> providers, IOptionsMonitor<LoggerFilterOptions> filterOption, IOptions<LoggerFactoryOptions> options = default(IOptions<LoggerFactoryOptions>))
			: this()
		{
		}

		private void RefreshFilters(LoggerFilterOptions filterOptions)
		{
		}

		public ILogger CreateLogger(string categoryName)
		{
			return null;
		}

		private void AddProviderRegistration(ILoggerProvider provider, bool dispose)
		{
		}

		private LoggerInformation[] CreateLoggers(string categoryName)
		{
			return null;
		}

		private ValueTuple<MessageLogger[], ScopeLogger[]> ApplyFilters(LoggerInformation[] loggers)
		{
			return default(ValueTuple<MessageLogger[], ScopeLogger[]>);
		}

		protected virtual bool CheckDisposed()
		{
			return default(bool);
		}

		public void Dispose()
		{
		}
	}
}
