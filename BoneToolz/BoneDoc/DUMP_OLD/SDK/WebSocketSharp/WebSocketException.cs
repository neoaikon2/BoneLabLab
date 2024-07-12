using System;

namespace WebSocketSharp
{
	public class WebSocketException : Exception
	{
		private CloseStatusCode _code;

		public CloseStatusCode Code
		{
			get
			{
				return default(CloseStatusCode);
			}
		}

		internal WebSocketException(string message)
			: base()
		{
		}

		internal WebSocketException(CloseStatusCode code)
			: base()
		{
		}

		internal WebSocketException(CloseStatusCode code, string message)
			: base()
		{
		}

		internal WebSocketException(CloseStatusCode code, string message, Exception innerException)
			: base()
		{
		}
	}
}
