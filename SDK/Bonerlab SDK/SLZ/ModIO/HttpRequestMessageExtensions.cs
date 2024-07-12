using System.Net.Http;
using System.Runtime.CompilerServices;

namespace SLZ.ModIO
{	
	public static class HttpRequestMessageExtensions
	{
		public static HttpRequestMessage DecorateIfAuthorized(this HttpRequestMessage request, RequestContext context)
		{
			return null;
		}

		public static HttpRequestMessage DecorateAccept(this HttpRequestMessage request, string mediaType = "application/json")
		{
			return null;
		}

		public static HttpRequestMessage DecorateWithPlatformAndPortal(this HttpRequestMessage request, RequestContext context)
		{
			return null;
		}
	}
}
