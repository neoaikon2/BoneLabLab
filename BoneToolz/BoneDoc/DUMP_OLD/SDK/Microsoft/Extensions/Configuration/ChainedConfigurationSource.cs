using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Configuration
{
	public class ChainedConfigurationSource : IConfigurationSource
	{
		public IConfiguration Configuration { get; set; }

		public bool ShouldDisposeConfiguration { get; set; }

		public IConfigurationProvider Build(IConfigurationBuilder builder)
		{
			return null;
		}

		public ChainedConfigurationSource()
			: base()
		{
		}
	}
}
