using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace WebSocketSharp.Net
{
	public sealed class HttpListener : IDisposable
	{
		private AuthenticationSchemes _authSchemes;

		private Func<HttpListenerRequest, AuthenticationSchemes> _authSchemeSelector;

		private string _certFolderPath;

		private Queue<HttpListenerContext> _contextQueue;

		private LinkedList<HttpListenerContext> _contextRegistry;

		private object _contextRegistrySync;

		private static readonly string _defaultRealm;

		private bool _disposed;

		private bool _ignoreWriteExceptions;

		private bool _listening;

		private Logger _log;

		private string _objectName;

		private HttpListenerPrefixCollection _prefixes;

		private string _realm;

		private bool _reuseAddress;

		private ServerSslConfiguration _sslConfig;

		private Func<IIdentity, NetworkCredential> _userCredFinder;

		private Queue<HttpListenerAsyncResult> _waitQueue;

		internal bool ReuseAddress
		{
			get
			{
				return default(bool);
			}
		}

		public string CertificateFolderPath
		{
			get
			{
				return null;
			}
		}

		public bool IgnoreWriteExceptions
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsListening
		{
			get
			{
				return default(bool);
			}
		}

		public Logger Log
		{
			get
			{
				return null;
			}
		}

		public HttpListenerPrefixCollection Prefixes
		{
			get
			{
				return null;
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			get
			{
				return null;
			}
		}

		static HttpListener()
		{
		}

		private HttpListenerAsyncResult beginGetContext(AsyncCallback callback, object state)
		{
			return null;
		}

		private void cleanupContextQueue(bool force)
		{
		}

		private void cleanupContextRegistry()
		{
		}

		private void cleanupWaitQueue(string message)
		{
		}

		private void close(bool force)
		{
		}

		private string getRealm()
		{
			return null;
		}

		private AuthenticationSchemes selectAuthenticationScheme(HttpListenerRequest request)
		{
			return default(AuthenticationSchemes);
		}

		internal bool AuthenticateContext(HttpListenerContext context)
		{
			return default(bool);
		}

		internal void CheckDisposed()
		{
		}

		internal bool RegisterContext(HttpListenerContext context)
		{
			return default(bool);
		}

		internal void UnregisterContext(HttpListenerContext context)
		{
		}

		public void Abort()
		{
		}

		public HttpListenerContext GetContext()
		{
			return null;
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		void IDisposable.Dispose()
		{
		}

		public HttpListener()
			: base()
		{
		}
	}
}
