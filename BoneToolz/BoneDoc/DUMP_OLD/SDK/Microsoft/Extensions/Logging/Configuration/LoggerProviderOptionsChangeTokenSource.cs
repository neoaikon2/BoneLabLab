using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Logging.Configuration
{
	public class LoggerProviderOptionsChangeTokenSource<TOptions, TProvider> : ConfigurationChangeTokenSource<TOptions>
	{
		public LoggerProviderOptionsChangeTokenSource(ILoggerProviderConfiguration<TProvider> providerConfiguration)
			: base(default(Microsoft.Extensions.Configuration.IConfiguration))
		{
		}
	}
}
