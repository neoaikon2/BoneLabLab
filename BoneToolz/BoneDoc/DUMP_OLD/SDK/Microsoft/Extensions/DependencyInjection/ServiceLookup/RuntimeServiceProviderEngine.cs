using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class RuntimeServiceProviderEngine : ServiceProviderEngine
	{
		public static RuntimeServiceProviderEngine Instance { get; }

		private RuntimeServiceProviderEngine()
			: base()
		{
		}

		public override Func<ServiceProviderEngineScope, object> RealizeService(ServiceCallSite callSite)
		{
			return null;
		}
	}
}
