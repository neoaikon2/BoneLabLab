using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public readonly struct InvalidOperationResponseContext
	{
		[JsonProperty("code")]
		public readonly int Code;

		[JsonProperty("error_ref")]
		public readonly int ErrorRef;

		[JsonProperty("message")]
		public readonly string Message;

		[JsonConstructor]
		public InvalidOperationResponseContext([JsonProperty("code")] int code, [JsonProperty("error_ref")] int errorRef, [JsonProperty("message")] string message)
		{
			Code = 0;
			ErrorRef = 0;
			Message = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
