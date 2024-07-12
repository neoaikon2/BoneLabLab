using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Options
{
	public class ConfigurationChangeTokenSource<TOptions> : IOptionsChangeTokenSource<TOptions>
	{
		private IConfiguration _config;

		public string Name { get; }

		public ConfigurationChangeTokenSource(IConfiguration config)
			: base()
		{
		}

		public ConfigurationChangeTokenSource(string name, IConfiguration config)
			: base()
		{
		}

		public IChangeToken GetChangeToken()
		{
			return null;
		}
	}
}
