using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class CallSiteChain
	{
		private struct ChainItemInfo
		{
			public int Order { get; }

			public Type ImplementationType { get; }

			public ChainItemInfo(int order, Type implementationType)
			{
				this.ImplementationType = default(Type);
				this.Order = default(int);
			}
		}

		private readonly Dictionary<Type, ChainItemInfo> _callSiteChain;

		public void CheckCircularDependency(Type serviceType)
		{
		}

		public void Remove(Type serviceType)
		{
		}

		public void Add(Type serviceType, Type implementationType = default(Type))
		{
		}

		private string CreateCircularDependencyExceptionMessage(Type type)
		{
			return null;
		}

		private void AppendResolutionPath(StringBuilder builder, Type currentlyResolving)
		{
		}

		public CallSiteChain()
			: base()
		{
		}
	}
}
