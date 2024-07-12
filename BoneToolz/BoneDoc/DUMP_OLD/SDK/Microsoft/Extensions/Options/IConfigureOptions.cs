namespace Microsoft.Extensions.Options
{
	public interface IConfigureOptions<in TOptions> where TOptions : class
	{
		void Configure(TOptions options);
	}
}
