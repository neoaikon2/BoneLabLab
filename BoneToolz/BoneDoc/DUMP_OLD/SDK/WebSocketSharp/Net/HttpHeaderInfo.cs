namespace WebSocketSharp.Net
{
	internal class HttpHeaderInfo
	{
		private string _headerName;

		private HttpHeaderType _headerType;

		internal bool IsMultiValueInRequest
		{
			get
			{
				return default(bool);
			}
		}

		internal bool IsMultiValueInResponse
		{
			get
			{
				return default(bool);
			}
		}

		public string HeaderName
		{
			get
			{
				return null;
			}
		}

		public bool IsRequest
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsResponse
		{
			get
			{
				return default(bool);
			}
		}

		internal HttpHeaderInfo(string headerName, HttpHeaderType headerType)
			: base()
		{
		}

		public bool IsMultiValue(bool response)
		{
			return default(bool);
		}

		public bool IsRestricted(bool response)
		{
			return default(bool);
		}
	}
}
