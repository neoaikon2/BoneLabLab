using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;

namespace WebSocketSharp.Net.WebSockets
{
	public class HttpListenerWebSocketContext : WebSocketContext
	{
		private HttpListenerContext _context;

		private WebSocket _websocket;

		internal Logger Log
		{
			get
			{
				return null;
			}
		}

		internal Stream Stream
		{
			get
			{
				return null;
			}
		}

		public override CookieCollection CookieCollection
		{
			get
			{
				return null;
			}
		}

		public override NameValueCollection Headers
		{
			get
			{
				return null;
			}
		}

		public override bool IsSecureConnection
		{
			get
			{
				return default(bool);
			}
		}

		public override bool IsWebSocketRequest
		{
			get
			{
				return default(bool);
			}
		}

		public override string Origin
		{
			get
			{
				return null;
			}
		}

		public override Uri RequestUri
		{
			get
			{
				return null;
			}
		}

		public override IEnumerable<string> SecWebSocketProtocols
		{
			//[IteratorStateMachine(typeof(_003Cget_SecWebSocketProtocols_003Ed__30))]
			get
			{
				return null;
			}
		}

		public override IPEndPoint UserEndPoint
		{
			get
			{
				return null;
			}
		}

		public override WebSocket WebSocket
		{
			get
			{
				return null;
			}
		}

		internal HttpListenerWebSocketContext(HttpListenerContext context, string protocol)
			: base()
		{
		}

		internal void Close()
		{
		}

		internal void Close(HttpStatusCode code)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
