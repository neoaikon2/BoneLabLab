using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Logging
{
	public interface ILoggingBuilder
	{
		IServiceCollection Services { get; }
	}
}
