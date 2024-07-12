using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Logging.Configuration
{
	internal sealed class LoggerProviderConfigureOptions<TOptions, TProvider> : ConfigureFromConfigurationOptions<TOptions> where TOptions : class
	{
		[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("TOptions's dependent types may have their members trimmed. Ensure all required members are preserved.")]
		public LoggerProviderConfigureOptions(ILoggerProviderConfiguration<TProvider> providerConfiguration)
			: base(default(Microsoft.Extensions.Configuration.IConfiguration))
		{
		}
	}
}
