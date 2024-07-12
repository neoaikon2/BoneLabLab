using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Configuration
{
	public class BinderOptions
	{
		public bool BindNonPublicProperties { get; }

		public bool ErrorOnUnknownConfiguration { get; }

		public BinderOptions()
			: base()
		{
		}
	}
}
