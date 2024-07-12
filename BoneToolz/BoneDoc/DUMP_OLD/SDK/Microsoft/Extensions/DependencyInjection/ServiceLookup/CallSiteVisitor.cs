using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class CallSiteVisitor<TArgument, TResult>
	{
		private readonly StackGuard _stackGuard;

		protected virtual TResult VisitCallSite(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected virtual TResult VisitCallSiteMain(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected virtual TResult VisitNoCache(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected virtual TResult VisitDisposeCache(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected virtual TResult VisitRootCache(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected virtual TResult VisitScopeCache(ServiceCallSite callSite, TArgument argument)
		{
			return (TResult)default(TResult);
		}

		protected abstract TResult VisitConstructor(ConstructorCallSite constructorCallSite, TArgument argument);

		protected abstract TResult VisitConstant(ConstantCallSite constantCallSite, TArgument argument);

		protected abstract TResult VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, TArgument argument);

		protected abstract TResult VisitIEnumerable(IEnumerableCallSite enumerableCallSite, TArgument argument);

		protected abstract TResult VisitFactory(FactoryCallSite factoryCallSite, TArgument argument);

		public CallSiteVisitor()
			: base()
		{
		}
	}
}
