using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	[Nullable(0)]
	[NullableContext(1)]
	public static class LoggerFactoryExtensions
	{
		public static ILogger<T> CreateLogger<T>(this ILoggerFactory factory)
		{
			return null;
		}
	}
}
