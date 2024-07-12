using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	internal sealed class CallSiteFactory : IServiceProviderIsService
	{
		private struct ServiceDescriptorCacheItem
		{
			private ServiceDescriptor _item;

			private List<ServiceDescriptor> _items;

			public ServiceDescriptor Last
			{
				get
				{
					return null;
				}
			}

			public int Count
			{
				get
				{
					return default(int);
				}
			}

			public ServiceDescriptor this[int index]
			{
				get
				{
					return null;
				}
			}

			public int GetSlot(ServiceDescriptor descriptor)
			{
				return default(int);
			}

			public ServiceDescriptorCacheItem Add(ServiceDescriptor descriptor)
			{
				return default(ServiceDescriptorCacheItem);
			}
		}

		private readonly ServiceDescriptor[] _descriptors;

		private readonly ConcurrentDictionary<ServiceCacheKey, ServiceCallSite> _callSiteCache;

		private readonly Dictionary<Type, ServiceDescriptorCacheItem> _descriptorLookup;

		private readonly ConcurrentDictionary<Type, object> _callSiteLocks;

		private readonly StackGuard _stackGuard;

		internal ServiceDescriptor[] Descriptors
		{
			get
			{
				return null;
			}
		}

		public CallSiteFactory(ICollection<ServiceDescriptor> descriptors)
			: base()
		{
		}

		private void Populate()
		{
		}

		private static void ValidateTrimmingAnnotations(Type serviceType, Type[] serviceTypeGenericArguments, Type implementationType, Type[] implementationTypeGenericArguments)
		{
		}

		private static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes GetDynamicallyAccessedMemberTypes(Type serviceGenericType)
		{
			return default(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes);
		}

		private static bool AreCompatible(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes serviceDynamicallyAccessedMembers, System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes implementationDynamicallyAccessedMembers)
		{
			return default(bool);
		}

		internal ServiceCallSite GetCallSite(Type serviceType, CallSiteChain callSiteChain)
		{
			return null;
		}

		internal ServiceCallSite GetCallSite(ServiceDescriptor serviceDescriptor, CallSiteChain callSiteChain)
		{
			return null;
		}

		private ServiceCallSite CreateCallSite(Type serviceType, CallSiteChain callSiteChain)
		{
			return null;
		}

		private ServiceCallSite TryCreateExact(Type serviceType, CallSiteChain callSiteChain)
		{
			return null;
		}

		private ServiceCallSite TryCreateOpenGeneric(Type serviceType, CallSiteChain callSiteChain)
		{
			return null;
		}

		private ServiceCallSite TryCreateEnumerable(Type serviceType, CallSiteChain callSiteChain)
		{
			return null;
		}

		private CallSiteResultCacheLocation GetCommonCacheLocation(CallSiteResultCacheLocation locationA, CallSiteResultCacheLocation locationB)
		{
			return default(CallSiteResultCacheLocation);
		}

		private ServiceCallSite TryCreateExact(ServiceDescriptor descriptor, Type serviceType, CallSiteChain callSiteChain, int slot)
		{
			return null;
		}

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2055:MakeGenericType", Justification = "MakeGenericType here is used to create a closed generic implementation type given the closed service type. Trimming annotations on the generic types are verified when 'Microsoft.Extensions.DependencyInjection.VerifyOpenGenericServiceTrimmability' is set, which is set by default when PublishTrimmed=true. That check informs developers when these generic types don't have compatible trimming annotations.")]
		private ServiceCallSite TryCreateOpenGeneric(ServiceDescriptor descriptor, Type serviceType, CallSiteChain callSiteChain, int slot, bool throwOnConstraintViolation)
		{
			return null;
		}

		private ServiceCallSite CreateConstructorCallSite(ResultCache lifetime, Type serviceType, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType, CallSiteChain callSiteChain)
		{
			return null;
		}

		private ServiceCallSite[] CreateArgumentCallSites(Type implementationType, CallSiteChain callSiteChain, ParameterInfo[] parameters, bool throwIfCallSiteNotFound)
		{
			return null;
		}

		public void Add(Type type, ServiceCallSite serviceCallSite)
		{
		}
	}
}
