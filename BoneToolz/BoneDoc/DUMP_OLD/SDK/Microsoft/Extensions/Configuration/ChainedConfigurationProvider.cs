using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public class ChainedConfigurationProvider : IConfigurationProvider, IDisposable
	{
		private readonly IConfiguration _config;

		private readonly bool _shouldDisposeConfig;

		public ChainedConfigurationProvider(ChainedConfigurationSource source)
			: base()
		{
		}

		public bool TryGet(string key, [Out] string value)
		{
			return default(bool);
		}

		public IChangeToken GetReloadToken()
		{
			return null;
		}

		public void Load()
		{
		}

		public IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string parentPath)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
