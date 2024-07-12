using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	public class LoggerFilterRule
	{
		public string ProviderName { get; }

		public string CategoryName { get; }

		public LogLevel? LogLevel { get; }

		public Func<string, string, LogLevel, bool> Filter { get; }

		public LoggerFilterRule()
			: base()
		{
		}
	}
}
