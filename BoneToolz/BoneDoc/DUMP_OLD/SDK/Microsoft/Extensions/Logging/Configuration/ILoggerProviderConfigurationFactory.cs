using System;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Logging.Configuration
{
	public interface ILoggerProviderConfigurationFactory
	{
		IConfiguration GetConfiguration(Type providerType);
	}
}
