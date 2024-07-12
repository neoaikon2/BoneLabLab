using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Lifetime = {Lifetime}, ServiceType = {ServiceType}, ImplementationType = {ImplementationType}")]
	public class ServiceDescriptor
	{
		public ServiceLifetime Lifetime { get; }

		public Type ServiceType { get; }

		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		[Nullable(2)]
		public Type ImplementationType
		{
			[NullableContext(2)]
			get;
		}

		[Nullable(2)]
		public object ImplementationInstance
		{
			[NullableContext(2)]
			get;
		}

		[Nullable(new byte[] { 2, 1, 1 })]
		public Func<IServiceProvider, object> ImplementationFactory { get; }

		public ServiceDescriptor(Type serviceType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType, ServiceLifetime lifetime)
			: base()
		{
		}

		public ServiceDescriptor(Type serviceType, object instance)
			: base()
		{
		}

		public ServiceDescriptor(Type serviceType, Func<IServiceProvider, object> factory, ServiceLifetime lifetime)
			: base()
		{
		}

		private ServiceDescriptor(Type serviceType, ServiceLifetime lifetime)
			: base()
		{
		}

		public override string ToString()
		{
			return null;
		}

		internal Type GetImplementationType()
		{
			return null;
		}

		public static ServiceDescriptor Transient(Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
		{
			return null;
		}

		public static ServiceDescriptor Scoped(Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
		{
			return null;
		}

		public static ServiceDescriptor Singleton<TService, TImplementation, TService>() where TService : class where TImplementation : class, TService where TService : class
		{
			return null;
		}

		public static ServiceDescriptor Singleton(Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
		{
			return null;
		}

		public static ServiceDescriptor Singleton<TImplementation, TService>(Func<IServiceProvider, TImplementation> implementationFactory) where TImplementation : class, TService where TService : class
		{
			return null;
		}

		public static ServiceDescriptor Singleton<TService>(TService implementationInstance) where TService : class
		{
			return null;
		}

		public static ServiceDescriptor Singleton(Type serviceType, object implementationInstance)
		{
			return null;
		}

		private static ServiceDescriptor Describe<TService, TImplementation, TService>(ServiceLifetime lifetime) where TService : class where TImplementation : class, TService where TService : class
		{
			return null;
		}

		public static ServiceDescriptor Describe(Type serviceType, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType, ServiceLifetime lifetime)
		{
			return null;
		}

		public static ServiceDescriptor Describe(Type serviceType, Func<IServiceProvider, object> implementationFactory, ServiceLifetime lifetime)
		{
			return null;
		}
	}
}
