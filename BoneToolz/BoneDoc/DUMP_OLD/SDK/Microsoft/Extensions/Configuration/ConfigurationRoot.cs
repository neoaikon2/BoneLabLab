using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public class ConfigurationRoot : IConfigurationRoot, IConfiguration, IDisposable
	{
		private readonly IList<IConfigurationProvider> _providers;

		private readonly IList<IDisposable> _changeTokenRegistrations;

		private ConfigurationReloadToken _changeToken;

		public IEnumerable<IConfigurationProvider> Providers
		{
			get
			{
				return null;
			}
		}

		public string this[string key]
		{
			get
			{
				return null;
			}
		}

		public ConfigurationRoot(IList<IConfigurationProvider> providers)
			: base()
		{
		}

		public IEnumerable<IConfigurationSection> GetChildren()
		{
			return null;
		}

		public IChangeToken GetReloadToken()
		{
			return null;
		}

		public IConfigurationSection GetSection(string key)
		{
			return null;
		}

		private void RaiseChanged()
		{
		}

		public void Dispose()
		{
		}

		internal static string GetConfiguration(IList<IConfigurationProvider> providers, string key)
		{
			return null;
		}
	}
}
