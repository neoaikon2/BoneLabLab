using System;

namespace Microsoft.Extensions.Logging
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public class ProviderAliasAttribute : Attribute
	{
		public ProviderAliasAttribute(string alias)
			: base()
		{
		}
	}
}
