using System;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[Flags]
	internal enum RuntimeResolverLock
	{
		Scope = 1,
		Root = 2
	}
}
