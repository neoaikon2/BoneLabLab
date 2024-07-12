using System;

namespace Microsoft.Extensions.Options
{
	public interface IOptionsMonitor<out TOptions>
	{
		TOptions CurrentValue { get; }

		IDisposable OnChange(Action<TOptions, string> listener);
	}
}
