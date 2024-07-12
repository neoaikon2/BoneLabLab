using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class DynamicServiceProviderEngine : CompiledServiceProviderEngine
	{
		private readonly ServiceProvider _serviceProvider;

		public DynamicServiceProviderEngine(ServiceProvider serviceProvider)
			: base(default(Microsoft.Extensions.DependencyInjection.ServiceProvider))
		{
		}

		public override Func<ServiceProviderEngineScope, object> RealizeService(ServiceCallSite callSite)
		{
			return null;
		}
	}
}
