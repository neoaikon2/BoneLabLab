using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Configuration
{
	public class ConfigurationBuilder : IConfigurationBuilder
	{
		public IList<IConfigurationSource> Sources { get; }

		public IConfigurationBuilder Add(IConfigurationSource source)
		{
			return null;
		}

		public IConfigurationRoot Build()
		{
			return null;
		}

		public ConfigurationBuilder()
			: base()
		{
		}
	}
}
