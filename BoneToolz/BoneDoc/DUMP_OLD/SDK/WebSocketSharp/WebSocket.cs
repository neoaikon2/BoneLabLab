using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;

namespace WebSocketSharp
{
	public class WebSocket : IDisposable
	{
		private string _base64Key;

		private bool _client;

		private Action _closeContext;

		private CompressionMethod _compression;

		private WebSocketContext _context;

		private CookieCollection _cookies;

		private bool _emitOnPing;

		private string _extensions;

		private object _forMessageEventQueue;

		private object _forPing;

		private object _forSend;

		private object _forState;

		private MemoryStream _fragmentsBuffer;

		private bool _fragmentsCompressed;

		private Opcode _fragmentsOpcode;

		private Func<WebSocketContext, string> _handshakeRequestChecker;

		private bool _ignoreExtensions;

		private bool _inContinuation;

		private bool _inMessage;

		private Logger _logger;

		private static readonly int _maxRetryCountForConnect;

		private Action<MessageEventArgs> _message;

		private Queue<MessageEventArgs> _messageEventQueue;

		private ManualResetEvent _pongReceived;

		private string _protocol;

		private WebSocketState _readyState;

		private ManualResetEvent _receivingExited;

		private bool _secure;

		private Stream _stream;

		private TcpClient _tcpClient;

		private TimeSpan _waitTime;

		internal static readonly byte[] EmptyBytes;

		internal static readonly int FragmentLength;

		internal static readonly RandomNumberGenerator RandomNumber;

		internal CookieCollection CookieCollection
		{
			get
			{
				return null;
			}
		}

		internal Func<WebSocketContext, string> CustomHandshakeRequestChecker
		{
			set
			{
			}
		}

		internal bool HasMessage
		{
			get
			{
				return default(bool);
			}
		}

		internal bool IgnoreExtensions
		{
			set
			{
			}
		}

		public bool EmitOnPing
		{
			set
			{
			}
		}

		internal string Protocol
		{
			set
			{
			}
		}

		public WebSocketState ReadyState
		{
			get
			{
				return default(WebSocketState);
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return default(TimeSpan);
			}
			set
			{
			}
		}

		static WebSocket()
		{
		}

		internal WebSocket(HttpListenerWebSocketContext context, string protocol)
			: base()
		{
		}

		private bool acceptHandshake()
		{
			return default(bool);
		}

		private bool canSet([Out] string message)
		{
			return default(bool);
		}

		private bool checkHandshakeRequest(WebSocketContext context, [Out] string message)
		{
			return default(bool);
		}

		private bool checkReceivedFrame(WebSocketFrame frame, [Out] string message)
		{
			return default(bool);
		}

		private void close(ushort code, string reason)
		{
		}

		private void close(PayloadData payloadData, bool send, bool receive, bool received)
		{
		}

		private bool closeHandshake(PayloadData payloadData, bool send, bool receive, bool received)
		{
			return default(bool);
		}

		private HttpResponse createHandshakeFailureResponse(HttpStatusCode code)
		{
			return null;
		}

		private HttpResponse createHandshakeResponse()
		{
			return null;
		}

		private bool customCheckHandshakeRequest(WebSocketContext context, [Out] string message)
		{
			return default(bool);
		}

		private void enqueueToMessageEventQueue(MessageEventArgs e)
		{
		}

		private void error(string message, Exception exception)
		{
		}

		private void fatal(string message, Exception exception)
		{
		}

		private void fatal(string message, ushort code)
		{
		}

		private void fatal(string message, CloseStatusCode code)
		{
		}

		private void init()
		{
		}

		private void message()
		{
		}

		private void messages(MessageEventArgs e)
		{
		}

		private void open()
		{
		}

		private bool processCloseFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private bool processDataFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private bool processFragmentFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private bool processPingFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private bool processPongFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private bool processReceivedFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private void processSecWebSocketExtensionsClientHeader(string value)
		{
		}

		private void processSecWebSocketProtocolClientHeader(IEnumerable<string> values)
		{
		}

		private bool processUnsupportedFrame(WebSocketFrame frame)
		{
			return default(bool);
		}

		private void refuseHandshake(CloseStatusCode code, string reason)
		{
		}

		private void releaseClientResources()
		{
		}

		private void releaseCommonResources()
		{
		}

		private void releaseResources()
		{
		}

		private void releaseServerResources()
		{
		}

		private bool send(Opcode opcode, Stream stream, bool compressed)
		{
			return default(bool);
		}

		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed)
		{
			return default(bool);
		}

		private bool sendBytes(byte[] bytes)
		{
			return default(bool);
		}

		private bool sendHttpResponse(HttpResponse response)
		{
			return default(bool);
		}

		private void startReceiving()
		{
		}

		internal void Close(PayloadData payloadData, byte[] frameAsBytes)
		{
		}

		internal static string CreateResponseKey(string base64Key)
		{
			return null;
		}

		internal void InternalAccept()
		{
		}

		internal bool Ping(byte[] frameAsBytes, TimeSpan timeout)
		{
			return default(bool);
		}

		internal void Send(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
		}

		internal void Send(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
		}

		public void Close(CloseStatusCode code)
		{
		}

		void IDisposable.Dispose()
		{
		}

		public event EventHandler<CloseEventArgs> OnClose;

		public event EventHandler<ErrorEventArgs> OnError;

		public event EventHandler<MessageEventArgs> OnMessage;

		public event EventHandler OnOpen;
	}
}
