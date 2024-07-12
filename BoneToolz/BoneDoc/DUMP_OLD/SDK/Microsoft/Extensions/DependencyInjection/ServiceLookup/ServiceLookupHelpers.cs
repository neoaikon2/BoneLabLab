using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal static class ServiceLookupHelpers
	{
		private static readonly MethodInfo ArrayEmptyMethodInfo;

		internal static readonly MethodInfo InvokeFactoryMethodInfo;

		internal static readonly MethodInfo CaptureDisposableMethodInfo;

		internal static readonly MethodInfo TryGetValueMethodInfo;

		internal static readonly MethodInfo ResolveCallSiteAndScopeMethodInfo;

		internal static readonly MethodInfo AddMethodInfo;

		internal static readonly MethodInfo MonitorEnterMethodInfo;

		internal static readonly MethodInfo MonitorExitMethodInfo;

		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2060:MakeGenericMethod", Justification = "Calling Array.Empty<T>() is safe since the T doesn't have trimming annotations.")]
		internal static MethodInfo GetArrayEmptyMethodInfo(Type itemType)
		{
			return null;
		}
	}
}
