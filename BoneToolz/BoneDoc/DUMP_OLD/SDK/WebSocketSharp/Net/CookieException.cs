using System;
using System.Runtime.Serialization;

namespace WebSocketSharp.Net
{
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		internal CookieException(string message, Exception innerException)
			: this()
		{
		}

		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this()
		{
		}

		public CookieException()
			: base()
		{
		}

		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
