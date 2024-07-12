namespace Microsoft.Extensions.Options
{
	public interface IValidateOptions<TOptions> where TOptions : class
	{
		ValidateOptionsResult Validate(string name, TOptions options);
	}
}
