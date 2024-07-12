using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	internal abstract class ServiceProviderEngine
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public abstract Func<ServiceProviderEngineScope, object> RealizeService(ServiceCallSite callSite);

		public ServiceProviderEngine()
			: base()
		{
		}
	}
}
