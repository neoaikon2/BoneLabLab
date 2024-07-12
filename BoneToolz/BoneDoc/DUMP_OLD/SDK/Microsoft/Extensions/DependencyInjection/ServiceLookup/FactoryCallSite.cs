using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class FactoryCallSite : ServiceCallSite
	{
		public Func<IServiceProvider, object> Factory { get; }

		public override Type ServiceType { get; }

		public override Type ImplementationType
		{
			get
			{
				return null;
			}
		}

		public override CallSiteKind Kind { get; }

		public FactoryCallSite(ResultCache cache, Type serviceType, Func<IServiceProvider, object> factory)
			: base(cache)
		{
		}
	}
}
