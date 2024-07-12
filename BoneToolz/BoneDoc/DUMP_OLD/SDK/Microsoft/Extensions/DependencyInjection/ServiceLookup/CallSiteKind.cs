namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	internal enum CallSiteKind
	{
		Factory = 0,
		Constructor = 1,
		Constant = 2,
		IEnumerable = 3,
		ServiceProvider = 4,
		Scope = 5,
		Transient = 6,
		Singleton = 7
	}
}
