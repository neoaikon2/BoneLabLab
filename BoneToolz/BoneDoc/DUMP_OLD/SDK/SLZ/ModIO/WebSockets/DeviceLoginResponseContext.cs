using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct DeviceLoginResponseContext
	{
		[JsonProperty("code")]
		public readonly string Code;

		[JsonProperty("login_url")]
		public readonly string LoginUrl;

		[JsonProperty("date_expires")]
		public readonly long DateExpires;

		[JsonConstructor]
		public DeviceLoginResponseContext([JsonProperty("code")] string code, [JsonProperty("login_url")] string loginUrl, [JsonProperty("date_expires")] long dateExpires)
		{
			this.DateExpires = default(long);
			this.LoginUrl = default(string);
			this.Code = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
