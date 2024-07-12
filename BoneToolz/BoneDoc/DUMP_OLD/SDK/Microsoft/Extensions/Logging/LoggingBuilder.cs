using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Logging
{
	internal sealed class LoggingBuilder : ILoggingBuilder
	{
		public IServiceCollection Services { get; }

		public LoggingBuilder(IServiceCollection services)
			: base()
		{
		}
	}
}
