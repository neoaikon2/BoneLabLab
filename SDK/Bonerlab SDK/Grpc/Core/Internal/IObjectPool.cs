using System;

namespace Grpc.Core.Internal
{
	internal interface IObjectPool<T> : IDisposable where T : class
	{
		T Lease();
	}
}
