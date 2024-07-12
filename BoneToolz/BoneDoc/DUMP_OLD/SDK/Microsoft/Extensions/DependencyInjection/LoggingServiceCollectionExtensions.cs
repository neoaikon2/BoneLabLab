using System;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class LoggingServiceCollectionExtensions
	{
		public static IServiceCollection AddLogging(this IServiceCollection services, Action<ILoggingBuilder> configure)
		{
			return null;
		}
	}
}
