using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal sealed class HttpConnection
	{
		private int _attempts;

		private byte[] _buffer;

		private static readonly int _bufferLength;

		private HttpListenerContext _context;

		private StringBuilder _currentLine;

		private InputState _inputState;

		private RequestStream _inputStream;

		private LineState _lineState;

		private EndPointListener _listener;

		private EndPoint _localEndPoint;

		private static readonly int _maxInputLength;

		private ResponseStream _outputStream;

		private int _position;

		private EndPoint _remoteEndPoint;

		private MemoryStream _requestBuffer;

		private int _reuses;

		private bool _secure;

		private Socket _socket;

		private Stream _stream;

		private object _sync;

		private int _timeout;

		private Dictionary<int, bool> _timeoutCanceled;

		private Timer _timer;

		public bool IsSecure
		{
			get
			{
				return default(bool);
			}
		}

		public IPEndPoint LocalEndPoint
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

		public int Reuses
		{
			get
			{
				return default(int);
			}
		}

		public Stream Stream
		{
			get
			{
				return null;
			}
		}

		static HttpConnection()
		{
		}

		internal HttpConnection(Socket socket, EndPointListener listener)
			: base()
		{
		}

		private void close()
		{
		}

		private void closeSocket()
		{
		}

		private void disposeRequestBuffer()
		{
		}

		private void disposeStream()
		{
		}

		private void disposeTimer()
		{
		}

		private void init(int timeout)
		{
		}

		private static void onRead(IAsyncResult asyncResult)
		{
		}

		private static void onTimeout(object state)
		{
		}

		private bool processInput(byte[] data, int length)
		{
			return default(bool);
		}

		private string readLineFrom(byte[] buffer, int offset, int length, [Out] int nread)
		{
			return null;
		}

		internal void BeginReadRequest()
		{
		}

		internal void Close(bool force)
		{
		}

		public RequestStream GetRequestStream(long contentLength, bool chunked)
		{
			return null;
		}

		public ResponseStream GetResponseStream()
		{
			return null;
		}
	}
}
