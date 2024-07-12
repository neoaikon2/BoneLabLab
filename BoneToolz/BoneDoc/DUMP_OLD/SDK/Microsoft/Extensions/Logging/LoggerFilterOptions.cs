using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	public class LoggerFilterOptions
	{
		public bool CaptureScopes { get; }

		public LogLevel MinLevel { get; set; }

		internal List<LoggerFilterRule> RulesInternal { get; }

		public LoggerFilterOptions()
			: base()
		{
		}
	}
}
