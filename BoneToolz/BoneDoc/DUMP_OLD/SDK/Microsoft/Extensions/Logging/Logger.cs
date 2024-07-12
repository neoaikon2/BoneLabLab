using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	public class Logger<T> : ILogger<T>, ILogger
	{
		private readonly ILogger _logger;

		[NullableContext(1)]
		public Logger(ILoggerFactory factory)
			: base()
		{
		}

		void ILogger.Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
		{
		}
	}
}
