using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this()
		{
		}

		public HttpListenerException()
			: base()
		{
		}

		public HttpListenerException(int errorCode, string message)
			: this()
		{
		}
	}
}
