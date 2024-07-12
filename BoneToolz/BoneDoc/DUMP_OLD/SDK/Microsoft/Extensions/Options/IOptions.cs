namespace Microsoft.Extensions.Options
{
	public interface IOptions<out TOptions> where TOptions : class
	{
		TOptions Value { get; }
	}
}
