using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Options
{
	public class OptionsMonitor<TOptions> : IOptionsMonitor<TOptions>, IDisposable where TOptions : class
	{
		internal sealed class ChangeTrackerDisposable : IDisposable
		{
			private readonly Action<TOptions, string> _listener;

			private readonly OptionsMonitor<TOptions> _monitor;

			public ChangeTrackerDisposable(OptionsMonitor<TOptions> monitor, Action<TOptions, string> listener)
				: base()
			{
			}

			public void OnChange(TOptions options, string name)
			{
			}

			public void Dispose()
			{
			}
		}

		private readonly IOptionsMonitorCache<TOptions> _cache;

		private readonly IOptionsFactory<TOptions> _factory;

		private readonly List<IDisposable> _registrations;

		public TOptions CurrentValue
		{
			get
			{
				return null;
			}
		}

		public OptionsMonitor(IOptionsFactory<TOptions> factory, IEnumerable<IOptionsChangeTokenSource<TOptions>> sources, IOptionsMonitorCache<TOptions> cache)
			: base()
		{
		}

		private void InvokeChanged(string name)
		{
		}

		public virtual TOptions Get(string name)
		{
			return null;
		}

		public IDisposable OnChange(Action<TOptions, string> listener)
		{
			return null;
		}

		public void Dispose()
		{
		}

		internal event Action<TOptions, string> _onChange;
	}
}
