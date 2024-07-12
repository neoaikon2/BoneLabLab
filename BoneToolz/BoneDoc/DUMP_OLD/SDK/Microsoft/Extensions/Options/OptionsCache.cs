using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.Options
{
	public class OptionsCache<TOptions> : IOptionsMonitorCache<TOptions> where TOptions : class
	{
		private readonly ConcurrentDictionary<string, Lazy<TOptions>> _cache;

		public virtual TOptions GetOrAdd(string name, Func<TOptions> createOptions)
		{
			return null;
		}

		internal bool TryGetValue(string name, [Out] TOptions options)
		{
			return default(bool);
		}

		public virtual bool TryRemove(string name)
		{
			return default(bool);
		}

		public OptionsCache()
			: base()
		{
		}
	}
}
