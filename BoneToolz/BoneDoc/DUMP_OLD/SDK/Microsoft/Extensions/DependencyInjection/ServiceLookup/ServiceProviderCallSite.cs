using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class ServiceProviderCallSite : ServiceCallSite
	{
		public override Type ServiceType { get; }

		public override Type ImplementationType { get; }

		public override CallSiteKind Kind { get; }

		public ServiceProviderCallSite()
			: base(default(Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache))
		{
		}
	}
}
