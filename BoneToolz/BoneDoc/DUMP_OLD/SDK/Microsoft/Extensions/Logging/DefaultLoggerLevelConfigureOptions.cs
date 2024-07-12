using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.Logging
{
	internal sealed class DefaultLoggerLevelConfigureOptions : ConfigureOptions<LoggerFilterOptions>
	{
		public DefaultLoggerLevelConfigureOptions(LogLevel level)
			: base(default(System.Action<Microsoft.Extensions.Logging.LoggerFilterOptions>))
		{
		}
	}
}
