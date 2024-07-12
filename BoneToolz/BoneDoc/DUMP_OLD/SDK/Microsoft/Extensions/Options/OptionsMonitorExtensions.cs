using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Options
{
	public static class OptionsMonitorExtensions
	{
		public static IDisposable OnChange<TOptions>(this IOptionsMonitor<TOptions> monitor, Action<TOptions> listener)
		{
			return null;
		}
	}
}
