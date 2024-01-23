using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerRequest
	{
		private static readonly byte[] _100continue;

		private bool _chunked;

		private HttpConnection _connection;

		private long _contentLength;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private WebHeaderCollection _headers;

		private string _httpMethod;

		private Stream _inputStream;

		private Version _protocolVersion;

		private string _rawUrl;

		private Guid _requestTraceIdentifier;

		private Uri _url;

		private bool _urlSet;

		private string _userHostName;

		public CookieCollection Cookies
		{
			get
			{
				return null;
			}
		}

		public NameValueCollection Headers
		{
			get
			{
				return null;
			}
		}

		public string HttpMethod
		{
			get
			{
				return null;
			}
		}

		public Stream InputStream
		{
			get
			{
				return null;
			}
		}

		public bool IsSecureConnection
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsWebSocketRequest
		{
			get
			{
				return default(bool);
			}
		}

		public bool KeepAlive
		{
			get
			{
				return default(bool);
			}
		}

		public Version ProtocolVersion
		{
			get
			{
				return null;
			}
		}

		public string RawUrl
		{
			get
			{
				return null;
			}
		}

		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return null;
			}
		}

		public Uri Url
		{
			get
			{
				return null;
			}
		}

		public string UserHostAddress
		{
			get
			{
				return null;
			}
		}

		static HttpListenerRequest()
		{
		}

		internal HttpListenerRequest(HttpListenerContext context)
			: base()
		{
		}

		internal void AddHeader(string headerField)
		{
		}

		internal void FinishInitialization()
		{
		}

		internal bool FlushInput()
		{
			return default(bool);
		}

		internal bool IsUpgradeRequest(string protocol)
		{
			return default(bool);
		}

		internal void SetRequestLine(string requestLine)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
