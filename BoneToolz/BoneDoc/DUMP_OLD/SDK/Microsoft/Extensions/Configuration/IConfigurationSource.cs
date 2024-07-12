namespace Microsoft.Extensions.Configuration
{
	public interface IConfigurationSource
	{
		IConfigurationProvider Build(IConfigurationBuilder builder);
	}
}
