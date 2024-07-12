using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Options
{
	public class ConfigureOptions<TOptions> : IConfigureOptions<TOptions> where TOptions : class
	{
		public Action<TOptions> Action { get; }

		public ConfigureOptions(Action<TOptions> action)
			: base()
		{
		}

		public virtual void Configure(TOptions options)
		{
		}
	}
}
