using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

namespace Microsoft.Extensions.DependencyInjection
{
	[EventSource(Name = "Microsoft-Extensions-DependencyInjection")]
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class DependencyInjectionEventSource : EventSource
	{
		[System.Runtime.CompilerServices.NullableContext(0)]
		public static class Keywords
		{
			public const EventKeywords ServiceProviderInitialized = (EventKeywords)1L;
		}

		public static readonly DependencyInjectionEventSource Log;

		private readonly List<WeakReference<ServiceProvider>> _providers;

		private DependencyInjectionEventSource()
			: base()
		{
		}

		[Event(1, Level = EventLevel.Verbose)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
		private void CallSiteBuilt(string serviceType, string callSite, int chunkIndex, int chunkCount, int serviceProviderHashCode)
		{
		}

		[Event(2, Level = EventLevel.Verbose)]
		public void ServiceResolved(string serviceType, int serviceProviderHashCode)
		{
		}

		[Event(4, Level = EventLevel.Verbose)]
		public void DynamicMethodBuilt(string serviceType, int methodSize, int serviceProviderHashCode)
		{
		}

		[Event(5, Level = EventLevel.Verbose)]
		public void ScopeDisposed(int serviceProviderHashCode, int scopedServicesResolved, int disposableServices)
		{
		}

		[Event(6, Level = EventLevel.Error)]
		[System.Runtime.CompilerServices.NullableContext(2)]
		public void ServiceRealizationFailed(string exceptionMessage, int serviceProviderHashCode)
		{
		}

		[Event(7, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
		private void ServiceProviderBuilt(int serviceProviderHashCode, int singletonServices, int scopedServices, int transientServices, int closedGenericsServices, int openGenericsServices)
		{
		}

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Parameters to this method are primitive and are trimmer safe.")]
		[Event(8, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void ServiceProviderDescriptors(int serviceProviderHashCode, string descriptors, int chunkIndex, int chunkCount)
		{
		}

		[NonEvent]
		public void ServiceResolved(ServiceProvider provider, Type serviceType)
		{
		}

		[NonEvent]
		public void CallSiteBuilt(ServiceProvider provider, Type serviceType, ServiceCallSite callSite)
		{
		}

		[NonEvent]
		public void DynamicMethodBuilt(ServiceProvider provider, Type serviceType, int methodSize)
		{
		}

		[NonEvent]
		public void ServiceRealizationFailed(Exception exception, int serviceProviderHashCode)
		{
		}

		[NonEvent]
		public void ServiceProviderBuilt(ServiceProvider provider)
		{
		}

		[NonEvent]
		public void ServiceProviderDisposed(ServiceProvider provider)
		{
		}

		[NonEvent]
		private void WriteServiceProviderBuilt(ServiceProvider provider)
		{
		}

		[NonEvent]
		private static void AppendServiceDescriptor(StringBuilder builder, ServiceDescriptor descriptor)
		{
		}
	}
}
