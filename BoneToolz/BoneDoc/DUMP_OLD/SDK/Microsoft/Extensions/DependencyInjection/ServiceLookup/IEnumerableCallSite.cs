using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class IEnumerableCallSite : ServiceCallSite
	{
		internal Type ItemType { get; }

		internal ServiceCallSite[] ServiceCallSites { get; }

		public override Type ServiceType
		{
			get
			{
				return null;
			}
		}

		public override Type ImplementationType
		{
			get
			{
				return null;
			}
		}

		public override CallSiteKind Kind { get; }

		public IEnumerableCallSite(ResultCache cache, Type itemType, ServiceCallSite[] serviceCallSites)
			: base(cache)
		{
		}
	}
}
