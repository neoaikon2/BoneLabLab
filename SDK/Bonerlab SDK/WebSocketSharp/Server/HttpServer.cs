using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;
using HttpListener = WebSocketSharp.Net.HttpListener;
using HttpListenerContext = WebSocketSharp.Net.HttpListenerContext;

namespace WebSocketSharp.Server
{
	public class HttpServer
	{
		private IPAddress _address;

		private string _docRootPath;

		private string _hostname;

		private HttpListener _listener;

		private Logger _log;

		private int _port;

		private Thread _receiveThread;

		private bool _secure;

		private WebSocketServiceManager _services;

		private ServerState _state;

		private object _sync;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler<HttpRequestEventArgs> OnConnect;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler<HttpRequestEventArgs> OnDelete;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler<HttpRequestEventArgs> OnHead;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler<HttpRequestEventArgs> OnOptions;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private EventHandler<HttpRequestEventArgs> OnPut;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private EventHandler<HttpRequestEventArgs> OnTrace;

		public IPAddress Address
		{
			get
			{
				return null;
			}
		}

		public string DocumentRootPath
		{
			set
			{
			}
		}

		public int Port
		{
			get
			{
				return default(int);
			}
		}

		public HttpServer(IPAddress address, int port)
			: base()
		{
		}

		public HttpServer(IPAddress address, int port, bool secure)
			: base()
		{
		}

		private void abort()
		{
		}

		private bool canSet()
		{
			return default(bool);
		}

		private bool checkCertificate([Out] string message)
		{
			return default(bool);
		}

		private static HttpListener createListener(string hostname, int port, bool secure)
		{
			return null;
		}

		private void init(string hostname, IPAddress address, int port, bool secure)
		{
		}

		private void processRequest(HttpListenerContext context)
		{
		}

		private void processRequest(HttpListenerWebSocketContext context)
		{
		}

		private void receiveRequest()
		{
		}

		private void start()
		{
		}

		private void startReceiving()
		{
		}

		private void stop(ushort code, string reason)
		{
		}

		private void stopReceiving(int millisecondsTimeout)
		{
		}

		public void AddWebSocketService<TBehavior>(string path) where TBehavior : WebSocketBehavior, new()
		{
		}

		public bool RemoveWebSocketService(string path)
		{
			return default(bool);
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public event EventHandler<HttpRequestEventArgs> OnGet;

		public event EventHandler<HttpRequestEventArgs> OnPost;
	}
}
