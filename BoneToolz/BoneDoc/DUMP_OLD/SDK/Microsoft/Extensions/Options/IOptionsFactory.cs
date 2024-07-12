namespace Microsoft.Extensions.Options
{
	public interface IOptionsFactory<TOptions> where TOptions : class
	{
		TOptions Create(string name);
	}
}
