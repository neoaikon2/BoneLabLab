using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	public interface ILoggerProvider : IDisposable
	{
		[NullableContext(1)]
		ILogger CreateLogger(string categoryName);
	}
}
