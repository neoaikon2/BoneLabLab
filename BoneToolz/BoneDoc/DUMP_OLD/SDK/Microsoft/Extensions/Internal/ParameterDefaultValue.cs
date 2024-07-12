using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.Internal
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal static class ParameterDefaultValue
	{
		public static bool CheckHasDefaultValue(ParameterInfo parameter, [Out] bool tryToGetDefaultValue)
		{
			return default(bool);
		}

		public static bool TryGetDefaultValue(ParameterInfo parameter, [Out][System.Runtime.CompilerServices.Nullable(2)] object defaultValue)
		{
			return default(bool);
		}
	}
}
