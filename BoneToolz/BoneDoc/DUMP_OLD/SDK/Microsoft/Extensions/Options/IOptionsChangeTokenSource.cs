using Microsoft.Extensions.Primitives;

namespace Microsoft.Extensions.Options
{
	public interface IOptionsChangeTokenSource<out TOptions>
	{
		string Name { get; }

		IChangeToken GetChangeToken();
	}
}
