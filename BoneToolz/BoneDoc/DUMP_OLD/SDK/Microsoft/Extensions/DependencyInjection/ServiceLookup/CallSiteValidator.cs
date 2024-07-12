using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1 })]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class CallSiteValidator : CallSiteVisitor<CallSiteValidator.CallSiteValidatorState, Type>
	{
		[System.Runtime.CompilerServices.Nullable(0)]
		internal struct CallSiteValidatorState
		{
			public ServiceCallSite Singleton
			{
				[IsReadOnly]
				get;
				set; }
		}

		private readonly ConcurrentDictionary<Type, Type> _scopedServices;

		public void ValidateCallSite(ServiceCallSite callSite)
		{
		}

		public void ValidateResolution(Type serviceType, IServiceScope scope, IServiceScope rootScope)
		{
		}

		protected override Type VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitRootCache(ServiceCallSite singletonCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitScopeCache(ServiceCallSite scopedCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitConstant(ConstantCallSite constantCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		protected override Type VisitFactory(FactoryCallSite factoryCallSite, CallSiteValidatorState state)
		{
			return null;
		}

		public CallSiteValidator()
			: base()
		{
		}
	}
}
