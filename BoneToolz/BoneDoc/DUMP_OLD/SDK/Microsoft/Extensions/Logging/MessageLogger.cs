using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	internal struct MessageLogger
	{
		public ILogger Logger { get; }

		public string Category { get; }

		private string ProviderTypeFullName { get; }

		public LogLevel? MinLevel { get; }

		public Func<string, string, LogLevel, bool> Filter { get; }

		public MessageLogger(ILogger logger, string category, string providerTypeFullName, LogLevel? minLevel, Func<string, string, LogLevel, bool> filter)
		{
			this.Filter = default(Func<string, string, LogLevel, bool>);
			this.MinLevel = default(LogLevel?);
			this.ProviderTypeFullName = default(string);
			this.Category = default(string);
			this.Logger = default(ILogger);
		}

		public bool IsEnabled(LogLevel level)
		{
			return default(bool);
		}
	}
}
