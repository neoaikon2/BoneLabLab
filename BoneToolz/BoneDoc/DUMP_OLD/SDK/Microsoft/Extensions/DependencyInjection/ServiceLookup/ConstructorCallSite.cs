using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class ConstructorCallSite : ServiceCallSite
	{
		internal ConstructorInfo ConstructorInfo { get; }

		internal ServiceCallSite[] ParameterCallSites { get; }

		public override Type ServiceType { get; }

		public override Type ImplementationType
		{
			get
			{
				return null;
			}
		}

		public override CallSiteKind Kind { get; }

		public ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo)
			: base(cache)
		{
		}

		public ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo, ServiceCallSite[] parameterCallSites)
			: base(cache)
		{
		}
	}
}
