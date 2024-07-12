using System;
using System.Collections.Specialized;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		private HttpResponse(string code, string reason, Version version, NameValueCollection headers)
			: this(code)
		{
		}

		internal HttpResponse(HttpStatusCode code)
			: this(code, default(System.String))
		{
		}

		internal HttpResponse(HttpStatusCode code, string reason)
			: this(code)
		{
		}

		internal static HttpResponse CreateCloseResponse(HttpStatusCode code)
		{
			return null;
		}

		internal static HttpResponse CreateWebSocketResponse()
		{
			return null;
		}

		public void SetCookies(CookieCollection cookies)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
