using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace WebSocketSharp.Net
{
	public sealed class HttpListenerResponse : IDisposable
	{
		private bool _closeConnection;

		private Encoding _contentEncoding;

		private long _contentLength;

		private string _contentType;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private bool _disposed;

		private WebHeaderCollection _headers;

		private bool _headersSent;

		private bool _keepAlive;

		private ResponseStream _outputStream;

		private Uri _redirectLocation;

		private bool _sendChunked;

		private int _statusCode;

		private string _statusDescription;

		private Version _version;

		internal bool CloseConnection
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal WebHeaderCollection FullHeaders
		{
			get
			{
				return null;
			}
		}

		internal bool HeadersSent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal string StatusLine
		{
			get
			{
				return null;
			}
		}

		public Encoding ContentEncoding
		{
			set
			{
			}
		}

		public long ContentLength64
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public string ContentType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WebHeaderCollection Headers
		{
			get
			{
				return null;
			}
		}

		public Stream OutputStream
		{
			get
			{
				return null;
			}
		}

		public bool SendChunked
		{
			get
			{
				return default(bool);
			}
		}

		public int StatusCode
		{
			set
			{
			}
		}

		public string StatusDescription
		{
			get
			{
				return null;
			}
		}

		internal HttpListenerResponse(HttpListenerContext context)
			: base()
		{
		}

		private void close(bool force)
		{
		}

		private void close(byte[] responseEntity, int bufferLength, bool willBlock)
		{
		}

		private static string createContentTypeHeaderText(string value, Encoding encoding)
		{
			return null;
		}

		private static bool isValidForContentType(string value)
		{
			return default(bool);
		}

		public void Abort()
		{
		}

		public void Close()
		{
		}

		public void Close(byte[] responseEntity, bool willBlock)
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
