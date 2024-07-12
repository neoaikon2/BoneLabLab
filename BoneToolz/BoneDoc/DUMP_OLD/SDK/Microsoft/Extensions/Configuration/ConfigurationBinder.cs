using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.Configuration
{
	public static class ConfigurationBinder
	{
		[RequiresUnreferencedCode("Cannot statically analyze the type of instance so its members may be trimmed")]
		public static void Bind(this IConfiguration configuration, object instance)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze the type of instance so its members may be trimmed")]
		public static void Bind(this IConfiguration configuration, object instance, Action<BinderOptions> configureOptions)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze property.PropertyType so its members may be trimmed.")]
		private static void BindNonScalar(this IConfiguration configuration, object instance, BinderOptions options)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze property.PropertyType so its members may be trimmed.")]
		private static void BindProperty(PropertyInfo property, object instance, IConfiguration config, BinderOptions options)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze what the element type is of the object collection in type so its members may be trimmed.")]
		private static object BindToCollection(Type type, IConfiguration config, BinderOptions options)
		{
			return null;
		}

		[RequiresUnreferencedCode("In case type is a Dictionary, cannot statically analyze what the element type is of the value objects in the dictionary so its members may be trimmed.")]
		private static object AttemptBindToCollectionInterfaces([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type, IConfiguration config, BinderOptions options)
		{
			return null;
		}

		[RequiresUnreferencedCode("In case the type is non-primitive, the trimmer cannot statically analyze the object's type so its members may be trimmed.")]
		private static object BindInstance([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type, object instance, IConfiguration config, BinderOptions options)
		{
			return null;
		}

		private static object CreateInstance([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] Type type)
		{
			return null;
		}

		[RequiresUnreferencedCode("Cannot statically analyze what the element type is of the value objects in the dictionary so its members may be trimmed.")]
		private static void BindDictionary(object dictionary, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] Type dictionaryType, IConfiguration config, BinderOptions options)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze what the element type is of the object collection so its members may be trimmed.")]
		private static void BindCollection(object collection, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods | DynamicallyAccessedMemberTypes.NonPublicMethods)] Type collectionType, IConfiguration config, BinderOptions options)
		{
		}

		[RequiresUnreferencedCode("Cannot statically analyze what the element type is of the Array so its members may be trimmed.")]
		private static Array BindArray(Array source, IConfiguration config, BinderOptions options)
		{
			return null;
		}

		[RequiresUnreferencedCode("In case the type is non-primitive, the trimmer cannot statically analyze the object's type so its members may be trimmed.")]
		private static bool TryConvertValue([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type, string value, string path, [Out] object result, [Out] Exception error)
		{
			return default(bool);
		}

		private static Type FindOpenGenericInterface(Type expected, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type actual)
		{
			return null;
		}

		private static List<PropertyInfo> GetAllProperties([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type type)
		{
			return null;
		}

		[RequiresUnreferencedCode("Cannot statically analyze property.PropertyType so its members may be trimmed.")]
		private static object GetPropertyValue(PropertyInfo property, object instance, IConfiguration config, BinderOptions options)
		{
			return null;
		}

		private static string GetPropertyName(MemberInfo property)
		{
			return null;
		}
	}
}
