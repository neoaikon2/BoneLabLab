using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Logging.Configuration
{
	public interface ILoggerProviderConfiguration<T>
	{
		IConfiguration Configuration { get; }
	}
}
