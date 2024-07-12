using System;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.Logging
{
	internal static class LoggerRuleSelector
	{
		public static void Select(LoggerFilterOptions options, Type providerType, string category, [Out] LogLevel? minLevel, [Out] Func<string, string, LogLevel, bool> filter)
		{
		}

		private static bool IsBetter(LoggerFilterRule rule, LoggerFilterRule current, string logger, string category)
		{
			return default(bool);
		}
	}
}
