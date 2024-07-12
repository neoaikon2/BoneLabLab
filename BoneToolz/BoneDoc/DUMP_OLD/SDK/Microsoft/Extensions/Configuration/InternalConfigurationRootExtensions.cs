using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Configuration
{
	internal static class InternalConfigurationRootExtensions
	{
		internal static IEnumerable<IConfigurationSection> GetChildrenImplementation(this IConfigurationRoot root, string path)
		{
			return null;
		}
	}
}
