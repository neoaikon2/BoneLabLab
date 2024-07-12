using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal struct RuntimeResolverContext
	{
		public ServiceProviderEngineScope Scope
		{
			[IsReadOnly]
			get;
			set; }

		public RuntimeResolverLock AcquiredLocks
		{
			[IsReadOnly]
			get;
			set; }
	}
}
