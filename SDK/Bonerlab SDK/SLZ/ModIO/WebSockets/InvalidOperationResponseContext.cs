using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct InvalidOperationResponseContext
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
			this.Message = default(string);
			this.ErrorRef = default(int);
			this.Code = default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
