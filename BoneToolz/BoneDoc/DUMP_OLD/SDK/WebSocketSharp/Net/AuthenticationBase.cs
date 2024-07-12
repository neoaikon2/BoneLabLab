using System.Collections.Specialized;

namespace WebSocketSharp.Net
{
	internal abstract class AuthenticationBase
	{
		private AuthenticationSchemes _scheme;

		internal NameValueCollection Parameters;

		public AuthenticationSchemes Scheme
		{
			get
			{
				return default(AuthenticationSchemes);
			}
		}

		protected AuthenticationBase(AuthenticationSchemes scheme, NameValueCollection parameters)
			: base()
		{
		}

		internal static string CreateNonceValue()
		{
			return null;
		}

		internal static NameValueCollection ParseParameters(string value)
		{
			return null;
		}

		internal abstract string ToBasicString();

		internal abstract string ToDigestString();

		public override string ToString()
		{
			return null;
		}
	}
}
