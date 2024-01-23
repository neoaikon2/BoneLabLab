using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;

namespace WebSocketSharp.Net.WebSockets
{
	public abstract class WebSocketContext
	{
		public abstract CookieCollection CookieCollection { get; }

		public abstract NameValueCollection Headers { get; }

		public abstract bool IsSecureConnection { get; }

		public abstract bool IsWebSocketRequest { get; }

		public abstract string Origin { get; }

		public abstract Uri RequestUri { get; }

		public abstract IEnumerable<string> SecWebSocketProtocols { get; }

		public abstract IPEndPoint UserEndPoint { get; }

		public abstract WebSocket WebSocket { get; }

		public WebSocketContext()
			: base()
		{
		}
	}
}
