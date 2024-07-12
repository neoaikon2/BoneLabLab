using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Configuration
{
	public class ConfigurationSection : IConfigurationSection, IConfiguration
	{
		private readonly IConfigurationRoot _root;

		private readonly string _path;

		private string _key;

		public string Path
		{
			get
			{
				return null;
			}
		}

		public string Key
		{
			get
			{
				return null;
			}
		}

		public string Value
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

		public ConfigurationSection(IConfigurationRoot root, string path)
			: base()
		{
		}

		public IConfigurationSection GetSection(string key)
		{
			return null;
		}

		public IEnumerable<IConfigurationSection> GetChildren()
		{
			return null;
		}

		public IChangeToken GetReloadToken()
		{
			return null;
		}
	}
}
