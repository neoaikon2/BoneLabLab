using System;
using System.Collections.Specialized;

namespace WebSocketSharp
{
	internal abstract class HttpBase
	{
		private NameValueCollection _headers;

		private Version _version;

		internal byte[] EntityBodyData;

		public string EntityBody
		{
			get
			{
				return null;
			}
		}

		public NameValueCollection Headers
		{
			get
			{
				return null;
			}
		}

		public Version ProtocolVersion
		{
			get
			{
				return null;
			}
		}

		protected HttpBase(Version version, NameValueCollection headers)
			: base()
		{
		}

		public byte[] ToByteArray()
		{
			return null;
		}
	}
}
