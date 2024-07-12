using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	internal sealed class StackGuard
	{
		private int _executionStackCount;

		public bool TryEnterOnCurrentStack()
		{
			return default(bool);
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public TR RunOnEmptyStack<TR, T1, T2>(Func<T1, T2, TR> action, T1 arg1, T2 arg2)
		{
			return (TR)default(TR);
		}

		private R RunOnEmptyStackCore<R>(Func<object, R> action, object state)
		{
			return (R)default(R);
		}

		public StackGuard()
			: base()
		{
		}
	}
}
