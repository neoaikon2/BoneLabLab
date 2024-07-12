using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.Logging.Configuration
{
	internal sealed class LoggingConfiguration
	{
		public IConfiguration Configuration { get; }

		public LoggingConfiguration()
			: base()
		{
		}
	}
}
