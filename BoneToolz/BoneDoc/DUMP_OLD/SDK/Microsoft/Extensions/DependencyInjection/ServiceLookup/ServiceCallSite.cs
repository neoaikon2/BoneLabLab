using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal abstract class ServiceCallSite
	{
		public abstract Type ServiceType { get; }

		public abstract Type ImplementationType { get; }

		public abstract CallSiteKind Kind { get; }

		public ResultCache Cache { get; }

		public object Value { get; set; }

		public bool CaptureDisposable
		{
			get
			{
				return default(bool);
			}
		}

		protected ServiceCallSite(ResultCache cache)
			: base()
		{
		}
	}
}
