using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1, 1 })]
	internal sealed class ILEmitResolverBuilder : CallSiteVisitor<ILEmitResolverBuilderContext, object>
	{
		private sealed class ILEmitResolverBuilderRuntimeContext
		{
			public object[] Constants;

			public Func<IServiceProvider, object>[] Factories;

			public ILEmitResolverBuilderRuntimeContext()
				: base()
			{
			}
		}

		private struct GeneratedMethod
		{
			public Func<ServiceProviderEngineScope, object> Lambda;

			public ILEmitResolverBuilderRuntimeContext Context;

			public DynamicMethod DynamicMethod;
		}

		private static readonly MethodInfo ResolvedServicesGetter;

		private static readonly MethodInfo ScopeLockGetter;

		private static readonly MethodInfo ScopeIsRootScope;

		private static readonly MethodInfo CallSiteRuntimeResolverResolveMethod;

		private static readonly MethodInfo CallSiteRuntimeResolverInstanceField;

		private static readonly FieldInfo FactoriesField;

		private static readonly FieldInfo ConstantsField;

		private static readonly MethodInfo GetTypeFromHandleMethod;

		private static readonly ConstructorInfo CacheKeyCtor;

		private readonly ServiceProviderEngineScope _rootScope;

		private readonly ConcurrentDictionary<ServiceCacheKey, GeneratedMethod> _scopeResolverCache;

		private readonly Func<ServiceCacheKey, ServiceCallSite, GeneratedMethod> _buildTypeDelegate;

		public ILEmitResolverBuilder(ServiceProvider serviceProvider)
			: base()
		{
		}

		public Func<ServiceProviderEngineScope, object> Build(ServiceCallSite callSite)
		{
			return null;
		}

		private GeneratedMethod BuildType(ServiceCallSite callSite)
		{
			return default(GeneratedMethod);
		}

		private GeneratedMethod BuildTypeNoCache(ServiceCallSite callSite)
		{
			return default(GeneratedMethod);
		}

		protected override object VisitDisposeCache(ServiceCallSite transientCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitConstructor(ConstructorCallSite constructorCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitRootCache(ServiceCallSite callSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitScopeCache(ServiceCallSite scopedCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitConstant(ConstantCallSite constantCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		protected override object VisitFactory(FactoryCallSite factoryCallSite, ILEmitResolverBuilderContext argument)
		{
			return null;
		}

		private void AddConstant(ILEmitResolverBuilderContext argument, object value)
		{
		}

		private void AddCacheKey(ILEmitResolverBuilderContext argument, ServiceCacheKey key)
		{
		}

		private ILEmitResolverBuilderRuntimeContext GenerateMethodBody(ServiceCallSite callSite, ILGenerator generator)
		{
			return null;
		}

		private static void BeginCaptureDisposable(ILEmitResolverBuilderContext argument)
		{
		}

		private static void EndCaptureDisposable(ILEmitResolverBuilderContext argument)
		{
		}

		private void Ldloc(ILGenerator generator, int index)
		{
		}

		private void Stloc(ILGenerator generator, int index)
		{
		}
	}
}
