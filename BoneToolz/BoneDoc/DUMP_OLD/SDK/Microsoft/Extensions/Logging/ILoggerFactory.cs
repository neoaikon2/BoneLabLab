using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	[NullableContext(1)]
	public interface ILoggerFactory : IDisposable
	{
		ILogger CreateLogger(string categoryName);
	}
}
