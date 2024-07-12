using System;
using WebSocketSharp.Net;

namespace WebSocketSharp.Server
{
	public class HttpRequestEventArgs : EventArgs
	{
		private HttpListenerContext _context;

		private string _docRootPath;

		public HttpListenerRequest Request
		{
			get
			{
				return null;
			}
		}

		public HttpListenerResponse Response
		{
			get
			{
				return null;
			}
		}

		internal HttpRequestEventArgs(HttpListenerContext context, string documentRootPath)
			: base()
		{
		}
	}
}
