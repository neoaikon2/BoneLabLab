using System;

namespace Microsoft.Extensions.Configuration
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class ConfigurationKeyNameAttribute : Attribute
	{
		public ConfigurationKeyNameAttribute()
			: base()
		{
		}
	}
}
