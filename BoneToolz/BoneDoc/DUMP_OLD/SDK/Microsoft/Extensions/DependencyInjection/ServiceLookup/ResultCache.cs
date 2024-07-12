using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	internal struct ResultCache
	{
		public static ResultCache None { get; }

		public CallSiteResultCacheLocation Location
		{
			[IsReadOnly]
			get;
			set; }

		public ServiceCacheKey Key
		{
			[IsReadOnly]
			get;
			set; }

		internal ResultCache(CallSiteResultCacheLocation lifetime, ServiceCacheKey cacheKey)
		{
			this.Key = default(ServiceCacheKey);
			this.Location = default(CallSiteResultCacheLocation);
		}

		[System.Runtime.CompilerServices.NullableContext(1)]
		public ResultCache(ServiceLifetime lifetime, Type type, int slot)
		{
			this.Key = default(ServiceCacheKey);
			this.Location = default(CallSiteResultCacheLocation);
		}
	}
}
