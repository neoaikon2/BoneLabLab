using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Extensions.Internal
{
	internal static class TypeNameHelper
	{
		private struct DisplayNameOptions
		{
			public bool FullName { get; }

			public bool IncludeGenericParameters { get; }

			public bool IncludeGenericParameterNames { get; }

			public char NestedTypeDelimiter { get; }

			public DisplayNameOptions(bool fullName, bool includeGenericParameterNames, bool includeGenericParameters, char nestedTypeDelimiter)
			{
				this.NestedTypeDelimiter = default(char);
				this.IncludeGenericParameterNames = default(bool);
				this.IncludeGenericParameters = default(bool);
				this.FullName = default(bool);
			}
		}

		private static readonly Dictionary<Type, string> _builtInTypeNames;

		[NullableContext(1)]
		public static string GetTypeDisplayName(Type type, bool fullName = true, bool includeGenericParameterNames = false, bool includeGenericParameters = true, char nestedTypeDelimiter = '+')
		{
			return null;
		}

		private static void ProcessType(StringBuilder builder, Type type, [In] DisplayNameOptions options)
		{
		}

		private static void ProcessArrayType(StringBuilder builder, Type type, [In] DisplayNameOptions options)
		{
		}

		private static void ProcessGenericType(StringBuilder builder, Type type, Type[] genericArguments, int length, [In] DisplayNameOptions options)
		{
		}
	}
}
