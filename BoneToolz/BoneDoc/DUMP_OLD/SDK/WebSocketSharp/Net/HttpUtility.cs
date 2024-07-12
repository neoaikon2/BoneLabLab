using System;
using System.IO;
using System.Security.Principal;
using System.Text;

namespace WebSocketSharp.Net
{
	internal static class HttpUtility
	{
		private static char[] _hexChars;

		private static object _sync;

		static HttpUtility()
		{
		}

		private static int getNumber(char c)
		{
			return default(int);
		}

		private static int getNumber(byte[] bytes, int offset, int count)
		{
			return default(int);
		}

		private static bool isAlphabet(char c)
		{
			return default(bool);
		}

		private static bool isNumeric(char c)
		{
			return default(bool);
		}

		private static bool isUnreserved(char c)
		{
			return default(bool);
		}

		private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		private static void urlEncode(byte b, Stream output)
		{
		}

		private static byte[] urlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			return null;
		}

		internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure)
		{
			return null;
		}

		internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			return null;
		}

		internal static Encoding GetEncoding(string contentType)
		{
			return null;
		}

		public static string UrlDecode(string s)
		{
			return null;
		}

		public static string UrlDecode(string s, Encoding encoding)
		{
			return null;
		}

		public static string UrlEncode(string s)
		{
			return null;
		}

		public static string UrlEncode(string s, Encoding encoding)
		{
			return null;
		}
	}
}
