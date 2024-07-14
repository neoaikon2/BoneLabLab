using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct AccessTokenObject
	{
		[JsonProperty("code")]
		public readonly long Code;

		[JsonProperty("access_token")]
		public readonly string AccessToken;

		[JsonProperty("date_expires")]
		public readonly long DateExpires;

		[JsonConstructor]
		public AccessTokenObject([JsonProperty("code")] long code, [JsonProperty("access_token")] string accessToken, [JsonProperty("date_expires")] long dateExpires)
		{
			Code = 0L;
			AccessToken = null;
			DateExpires = 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
