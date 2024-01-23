using System;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp.Server
{
	public abstract class WebSocketBehavior : IWebSocketSession
	{
		private WebSocketContext _context;

		private Func<CookieCollection, CookieCollection, bool> _cookiesValidator;

		private bool _emitOnPing;

		private string _id;

		private bool _ignoreExtensions;

		private Func<string, bool> _originValidator;

		private string _protocol;

		private WebSocketSessionManager _sessions;

		private DateTime _startTime;

		private WebSocket _websocket;

		protected WebSocketSessionManager Sessions
		{
			get
			{
				return null;
			}
		}

		public WebSocketState ConnectionState
		{
			get
			{
				return default(WebSocketState);
			}
		}

		public WebSocketContext Context
		{
			get
			{
				return null;
			}
		}

		public string ID
		{
			get
			{
				return null;
			}
		}

		private string checkHandshakeRequest(WebSocketContext context)
		{
			return null;
		}

		private void onClose(object sender, CloseEventArgs e)
		{
		}

		private void onError(object sender, ErrorEventArgs e)
		{
		}

		private void onMessage(object sender, MessageEventArgs e)
		{
		}

		private void onOpen(object sender, EventArgs e)
		{
		}

		internal void Start(WebSocketContext context, WebSocketSessionManager sessions)
		{
		}

		protected virtual void OnClose(CloseEventArgs e)
		{
		}

		protected virtual void OnError(ErrorEventArgs e)
		{
		}

		protected virtual void OnMessage(MessageEventArgs e)
		{
		}

		protected virtual void OnOpen()
		{
		}

		public WebSocketBehavior()
			: base()
		{
		}
	}
}
