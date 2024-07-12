using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Options
{
	public class ConfigureFromConfigurationOptions<TOptions> : ConfigureOptions<TOptions> where TOptions : class
	{
		[RequiresUnreferencedCode("TOptions's dependent types may have their members trimmed. Ensure all required members are preserved.")]
		public ConfigureFromConfigurationOptions(IConfiguration config)
			: base(default(System.Action<TOptions>))
		{
		}

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The only call to this method is the constructor which is already annotated as RequiresUnreferencedCode.")]
		private static void BindFromOptions(TOptions options, IConfiguration config)
		{
		}
	}
}
