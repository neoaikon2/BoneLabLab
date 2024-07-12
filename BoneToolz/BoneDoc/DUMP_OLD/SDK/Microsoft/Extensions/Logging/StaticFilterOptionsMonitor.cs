using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Logging
{
	internal sealed class StaticFilterOptionsMonitor : IOptionsMonitor<LoggerFilterOptions>
	{
		public LoggerFilterOptions CurrentValue { get; }

		public StaticFilterOptionsMonitor(LoggerFilterOptions currentValue)
			: base()
		{
		}

		public IDisposable OnChange(Action<LoggerFilterOptions, string> listener)
		{
			return null;
		}
	}
}
