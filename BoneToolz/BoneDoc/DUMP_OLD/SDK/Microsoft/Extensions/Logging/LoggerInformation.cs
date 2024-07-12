using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	internal struct LoggerInformation
	{
		public ILogger Logger { get; }

		public string Category { get; }

		public Type ProviderType { get; }

		public bool ExternalScope { get; }

		public LoggerInformation(ILoggerProvider provider, string category)
		{
			this.ExternalScope = default(bool);
			this.ProviderType = default(Type);
			this.Category = default(string);
			this.Logger = default(ILogger);
		}
	}
}
