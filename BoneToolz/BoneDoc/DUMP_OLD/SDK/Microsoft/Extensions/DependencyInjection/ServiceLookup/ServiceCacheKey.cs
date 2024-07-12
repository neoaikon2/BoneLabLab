using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal struct ServiceCacheKey : IEquatable<ServiceCacheKey>
	{
		public static ServiceCacheKey Empty { get; }

		public Type Type { get; }

		public int Slot { get; }

		public ServiceCacheKey(Type type, int slot)
		{
			this.Slot = default(int);
			this.Type = default(Type);
		}

		public bool Equals(ServiceCacheKey other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
