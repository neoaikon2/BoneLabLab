namespace WebSocketSharp.Net
{
	internal sealed class HttpListenerPrefix
	{
		private string _host;

		private HttpListener _listener;

		private string _original;

		private string _path;

		private string _port;

		private string _prefix;

		private bool _secure;

		public string Host
		{
			get
			{
				return null;
			}
		}

		public bool IsSecure
		{
			get
			{
				return default(bool);
			}
		}

		public HttpListener Listener
		{
			get
			{
				return null;
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
		}

		public string Port
		{
			get
			{
				return null;
			}
		}

		internal HttpListenerPrefix(string uriPrefix, HttpListener listener)
			: base()
		{
		}

		private void parse(string uriPrefix)
		{
		}

		public static void CheckPrefix(string uriPrefix)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
