using System.Collections.Specialized;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	internal class AuthenticationResponse : AuthenticationBase
	{
		private AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters)
			: base(scheme, parameters)
		{
		}

		private static string createA1(string username, string password, string realm)
		{
			return null;
		}

		private static string createA1(string username, string password, string realm, string nonce, string cnonce)
		{
			return null;
		}

		private static string createA2(string method, string uri)
		{
			return null;
		}

		private static string createA2(string method, string uri, string entity)
		{
			return null;
		}

		private static string hash(string value)
		{
			return null;
		}

		internal static string CreateRequestDigest(NameValueCollection parameters)
		{
			return null;
		}

		internal static AuthenticationResponse Parse(string value)
		{
			return null;
		}

		internal static NameValueCollection ParseBasicCredentials(string value)
		{
			return null;
		}

		internal override string ToBasicString()
		{
			return null;
		}

		internal override string ToDigestString()
		{
			return null;
		}

		public IIdentity ToIdentity()
		{
			return null;
		}
	}
}
