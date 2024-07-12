using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Logging.Configuration
{
	public static class LoggerProviderOptions
	{
		[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("TOptions's dependent types may have their members trimmed. Ensure all required members are preserved.")]
		public static void RegisterProviderOptions<TOptions, TProvider>(IServiceCollection services) where TOptions : class
		{
		}
	}
}
