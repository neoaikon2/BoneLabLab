namespace Microsoft.Extensions.Options
{
	public interface IPostConfigureOptions<in TOptions> where TOptions : class
	{
		void PostConfigure(string name, TOptions options);
	}
}
