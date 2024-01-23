using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public class HttpBasicIdentity : GenericIdentity
	{
		private string _password;

		public virtual string Password
		{
			get
			{
				return null;
			}
		}

		internal HttpBasicIdentity(string username, string password)
			: base(default(System.Security.Principal.GenericIdentity))
		{
		}
	}
}
