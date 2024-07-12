using System;
using System.Threading;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public class ConfigurationReloadToken : IChangeToken
	{
		private CancellationTokenSource _cts;

		public IDisposable RegisterChangeCallback(Action<object> callback, object state)
		{
			return null;
		}

		public void OnReload()
		{
		}

		public ConfigurationReloadToken()
			: base()
		{
		}
	}
}
