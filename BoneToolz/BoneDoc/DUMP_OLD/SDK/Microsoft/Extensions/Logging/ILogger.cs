using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	[NullableContext(1)]
	public interface ILogger
	{
		[NullableContext(2)]
		void Log<TState>(LogLevel logLevel, EventId eventId, [Nullable(1)] TState state, Exception exception, [Nullable(new byte[] { 1, 1, 2, 1 })] Func<TState, Exception, string> formatter);
	}
	public interface ILogger<out TCategoryName> : ILogger
	{
	}
}
