namespace Microsoft.Extensions.Configuration
{
	public static class ChainedBuilderExtensions
	{
		public static IConfigurationBuilder AddConfiguration(this IConfigurationBuilder configurationBuilder, IConfiguration config)
		{
			return null;
		}

		public static IConfigurationBuilder AddConfiguration(this IConfigurationBuilder configurationBuilder, IConfiguration config, bool shouldDisposeConfiguration)
		{
			return null;
		}
	}
}
