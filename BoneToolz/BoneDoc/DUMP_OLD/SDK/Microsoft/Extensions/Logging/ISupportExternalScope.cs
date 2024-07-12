using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
	[NullableContext(1)]
	public interface ISupportExternalScope
	{
		void SetScopeProvider(IExternalScopeProvider scopeProvider);
	}
}
