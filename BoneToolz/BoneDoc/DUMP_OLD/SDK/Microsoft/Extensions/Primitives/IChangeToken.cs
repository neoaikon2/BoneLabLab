using System;

namespace Microsoft.Extensions.Primitives
{
	public interface IChangeToken
	{
		IDisposable RegisterChangeCallback(Action<object> callback, object state);
	}
}
