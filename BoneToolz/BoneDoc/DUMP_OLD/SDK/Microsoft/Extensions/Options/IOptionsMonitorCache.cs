using System;

namespace Microsoft.Extensions.Options
{
	public interface IOptionsMonitorCache<TOptions> where TOptions : class
	{
		TOptions GetOrAdd(string name, Func<TOptions> createOptions);

		bool TryRemove(string name);
	}
}
