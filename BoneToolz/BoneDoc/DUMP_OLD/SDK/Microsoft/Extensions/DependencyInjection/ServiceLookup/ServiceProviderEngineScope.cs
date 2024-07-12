using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class ServiceProviderEngineScope : IServiceScope, IDisposable, IServiceProvider, IAsyncDisposable, IServiceScopeFactory
	{
		private bool _disposed;

		private List<object> _disposables;

		internal Dictionary<ServiceCacheKey, object> ResolvedServices { get; }

		internal object Sync
		{
			get
			{
				return null;
			}
		}

		public bool IsRootScope { get; }

		internal ServiceProvider RootProvider { get; }

		public ServiceProviderEngineScope(ServiceProvider provider, bool isRootScope)
			: base()
		{
		}

		public object GetService(Type serviceType)
		{
			return null;
		}

		internal object CaptureDisposable(object service)
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

		private List<object> BeginDispose()
		{
			return null;
		}
	}
}
