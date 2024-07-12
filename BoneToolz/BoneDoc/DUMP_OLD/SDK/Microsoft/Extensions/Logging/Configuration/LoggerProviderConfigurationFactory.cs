using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Logging.Configuration
{
	internal sealed class LoggerProviderConfigurationFactory : ILoggerProviderConfigurationFactory
	{
		private readonly IEnumerable<LoggingConfiguration> _configurations;

		public LoggerProviderConfigurationFactory(IEnumerable<LoggingConfiguration> configurations)
			: base()
		{
		}

		public IConfiguration GetConfiguration(Type providerType)
		{
			return null;
		}
	}
}
