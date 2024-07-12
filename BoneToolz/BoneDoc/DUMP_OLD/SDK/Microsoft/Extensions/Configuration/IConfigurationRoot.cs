using System.Collections.Generic;

namespace Microsoft.Extensions.Configuration
{
	public interface IConfigurationRoot : IConfiguration
	{
		IEnumerable<IConfigurationProvider> Providers { get; }
	}
}
