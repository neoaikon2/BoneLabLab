using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	public class LoggerFactoryOptions
	{
		public ActivityTrackingOptions ActivityTrackingOptions { get; }

		public LoggerFactoryOptions()
			: base()
		{
		}
	}
}
