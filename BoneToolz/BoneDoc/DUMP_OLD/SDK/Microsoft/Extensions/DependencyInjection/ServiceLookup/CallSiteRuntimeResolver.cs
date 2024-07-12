using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1 })]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class CallSiteRuntimeResolver : CallSiteVisitor<RuntimeResolverContext, object>
	{
		public static CallSiteRuntimeResolver Instance { get; }

		private CallSiteRuntimeResolver()
			: base()
		{
		}

		public object Resolve(ServiceCallSite callSite, ServiceProviderEngineScope scope)
		{
			return null;
		}

		protected override object VisitDisposeCache(ServiceCallSite transientCallSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitConstructor(ConstructorCallSite constructorCallSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitRootCache(ServiceCallSite callSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitScopeCache(ServiceCallSite callSite, RuntimeResolverContext context)
		{
			return null;
		}

		private object VisitCache(ServiceCallSite callSite, RuntimeResolverContext context, ServiceProviderEngineScope serviceProviderEngine, RuntimeResolverLock lockType)
		{
			return null;
		}

		protected override object VisitConstant(ConstantCallSite constantCallSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, RuntimeResolverContext context)
		{
			return null;
		}

		protected override object VisitFactory(FactoryCallSite factoryCallSite, RuntimeResolverContext context)
		{
			return null;
		}
	}
}
