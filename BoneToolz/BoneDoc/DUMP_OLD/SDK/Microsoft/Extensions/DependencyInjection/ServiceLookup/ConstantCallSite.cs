using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class ConstantCallSite : ServiceCallSite
	{
		private readonly Type _serviceType;

		internal object DefaultValue
		{
			get
			{
				return null;
			}
		}

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

		public ConstantCallSite(Type serviceType, object defaultValue)
			: base(default(Microsoft.Extensions.DependencyInjection.ServiceLookup.ResultCache))
		{
		}
	}
}
