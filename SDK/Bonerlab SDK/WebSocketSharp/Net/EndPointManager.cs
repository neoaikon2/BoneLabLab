using System.Collections.Generic;
using System.Net;

namespace WebSocketSharp.Net
{
	internal sealed class EndPointManager
	{
		private static readonly Dictionary<IPEndPoint, EndPointListener> _endpoints;

		static EndPointManager()
		{
		}

		private static void addPrefix(string uriPrefix, HttpListener listener)
		{
		}

		private static IPAddress convertToIPAddress(string hostname)
		{
			return null;
		}

		private static void removePrefix(string uriPrefix, HttpListener listener)
		{
		}

		internal static bool RemoveEndPoint(IPEndPoint endpoint)
		{
			return default(bool);
		}

		public static void AddListener(HttpListener listener)
		{
		}

		public static void AddPrefix(string uriPrefix, HttpListener listener)
		{
		}

		public static void RemoveListener(HttpListener listener)
		{
		}

		public static void RemovePrefix(string uriPrefix, HttpListener listener)
		{
		}

		public EndPointManager()
			: base()
		{
		}
	}
}
