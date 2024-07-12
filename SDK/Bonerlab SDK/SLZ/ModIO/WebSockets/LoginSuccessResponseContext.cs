using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct LoginSuccessResponseContext
	{
		[JsonProperty("code")]
		public readonly long Code;

		[JsonProperty("access_token")]
		public readonly string AccessToken;

		[JsonProperty("date_expires")]
		public readonly long DateExpires;

		[JsonConstructor]
		public LoginSuccessResponseContext([JsonProperty("code")] long code, [JsonProperty("access_token")] string accessToken, [JsonProperty("date_expires")] long dateExpires)
		{
			this.DateExpires = default(long);
			this.AccessToken = default(string);
			this.Code = default(long);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
