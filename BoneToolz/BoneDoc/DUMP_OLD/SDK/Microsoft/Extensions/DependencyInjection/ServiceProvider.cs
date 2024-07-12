using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

namespace Microsoft.Extensions.DependencyInjection
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	public sealed class ServiceProvider : IServiceProvider, IDisposable, IAsyncDisposable
	{
		private readonly CallSiteValidator _callSiteValidator;

		private readonly Func<Type, Func<ServiceProviderEngineScope, object>> _createServiceAccessor;

		internal ServiceProviderEngine _engine;

		private bool _disposed;

		private ConcurrentDictionary<Type, Func<ServiceProviderEngineScope, object>> _realizedServices;

		internal CallSiteFactory CallSiteFactory { get; }

		internal ServiceProviderEngineScope Root { get; }

		internal static bool VerifyOpenGenericServiceTrimmability { get; }

		internal ServiceProvider(ICollection<ServiceDescriptor> serviceDescriptors, ServiceProviderOptions options)
			: base()
		{
		}

		public object GetService(Type serviceType)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public ValueTask DisposeAsync()
		{
			return default(ValueTask);
		}

		private void DisposeCore()
		{
		}

		private void OnCreate(ServiceCallSite callSite)
		{
		}

		private void OnResolve(Type serviceType, IServiceScope scope)
		{
		}

		internal object GetService(Type serviceType, ServiceProviderEngineScope serviceProviderEngineScope)
		{
			return null;
		}

		private void ValidateService(ServiceDescriptor descriptor)
		{
		}

		private Func<ServiceProviderEngineScope, object> CreateServiceAccessor(Type serviceType)
		{
			return null;
		}

		internal void ReplaceServiceAccessor(ServiceCallSite callSite, Func<ServiceProviderEngineScope, object> accessor)
		{
		}

		private ServiceProviderEngine GetEngine()
		{
			return null;
		}
	}
}
