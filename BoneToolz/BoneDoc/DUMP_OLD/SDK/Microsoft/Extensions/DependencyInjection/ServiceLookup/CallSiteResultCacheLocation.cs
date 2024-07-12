namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	internal enum CallSiteResultCacheLocation
	{
		Root = 0,
		Scope = 1,
		Dispose = 2,
		None = 3
	}
}
