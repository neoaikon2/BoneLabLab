namespace WebSocketSharp.Net
{
	internal class AuthenticationChallenge : AuthenticationBase
	{
		internal AuthenticationChallenge(AuthenticationSchemes scheme, string realm)
			: base(scheme, default(System.Collections.Specialized.NameValueCollection))
		{
		}

		internal override string ToBasicString()
		{
			return null;
		}

		internal override string ToDigestString()
		{
			return null;
		}
	}
}
