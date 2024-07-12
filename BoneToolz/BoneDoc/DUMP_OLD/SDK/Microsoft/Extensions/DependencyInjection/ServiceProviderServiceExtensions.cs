using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	[NullableContext(1)]
	[Nullable(0)]
	public static class ServiceProviderServiceExtensions
	{
		[NullableContext(2)]
		public static T GetService<T>([Nullable(1)] this IServiceProvider provider)
		{
			return (T)default(T);
		}
	}
}
