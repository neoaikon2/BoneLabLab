using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.Extensions
{
	[NullableContext(1)]
	[Nullable(0)]
	public static class ServiceCollectionDescriptorExtensions
	{
		public static void TryAdd(this IServiceCollection collection, ServiceDescriptor descriptor)
		{
		}

		public static void TryAddSingleton(this IServiceCollection collection, Type service, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type implementationType)
		{
		}

		public static void TryAddSingleton<TService, TImplementation, TService>(this IServiceCollection collection) where TService : class where TImplementation : class, TService where TService : class
		{
		}

		public static void TryAddEnumerable(this IServiceCollection services, ServiceDescriptor descriptor)
		{
		}
	}
}
