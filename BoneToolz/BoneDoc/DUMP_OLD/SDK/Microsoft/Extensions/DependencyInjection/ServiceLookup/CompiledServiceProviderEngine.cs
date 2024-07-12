using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class CompiledServiceProviderEngine : ServiceProviderEngine
	{
		public ILEmitResolverBuilder ResolverBuilder { get; }

		public CompiledServiceProviderEngine(ServiceProvider provider)
			: base()
		{
		}

		public override Func<ServiceProviderEngineScope, object> RealizeService(ServiceCallSite callSite)
		{
			return null;
		}
	}
}
