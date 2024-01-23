using System.Security.Principal;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerContext
	{
		private HttpConnection _connection;

		private string _errorMessage;

		private int _errorStatusCode;

		private HttpListener _listener;

		private HttpListenerRequest _request;

		private HttpListenerResponse _response;

		private IPrincipal _user;

		private HttpListenerWebSocketContext _websocketContext;

		internal HttpConnection Connection
		{
			get
			{
				return null;
			}
		}

		internal string ErrorMessage
		{
			set
			{
			}
		}

		internal int ErrorStatusCode
		{
			set
			{
			}
		}

		internal bool HasErrorMessage
		{
			get
			{
				return default(bool);
			}
		}

		internal HttpListener Listener
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HttpListenerRequest Request
		{
			get
			{
				return null;
			}
		}

		public HttpListenerResponse Response
		{
			get
			{
				return null;
			}
		}

		internal IPrincipal User
		{
			set
			{
			}
		}

		internal HttpListenerContext(HttpConnection connection)
			: base()
		{
		}

		private static string createErrorContent(int statusCode, string statusDescription, string message)
		{
			return null;
		}

		internal HttpListenerWebSocketContext GetWebSocketContext(string protocol)
		{
			return null;
		}

		internal void SendAuthenticationChallenge(AuthenticationSchemes scheme, string realm)
		{
		}

		internal void SendError()
		{
		}

		internal void Unregister()
		{
		}
	}
}
