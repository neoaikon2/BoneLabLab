namespace Microsoft.Extensions.Configuration
{
	public interface IConfigurationBuilder
	{
		IConfigurationBuilder Add(IConfigurationSource source);
	}
}
