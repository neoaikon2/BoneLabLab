using System;

namespace Grpc.Core.Internal
{
	internal interface IPooledObject<T> : IDisposable
	{
		void SetReturnToPoolAction(Action<T> returnAction);
	}
}
