using System.Collections.Specialized;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public class HttpDigestIdentity : GenericIdentity
	{
		private NameValueCollection _parameters;

		internal HttpDigestIdentity(NameValueCollection parameters)
			: base(default(System.Security.Principal.GenericIdentity))
		{
		}

		internal bool IsValid(string password, string realm, string method, string entity)
		{
			return default(bool);
		}
	}
}
