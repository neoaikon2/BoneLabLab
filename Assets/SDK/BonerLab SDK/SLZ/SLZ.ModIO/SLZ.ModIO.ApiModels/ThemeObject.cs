using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ThemeObject
	{
		[JsonProperty("primary")]
		public string Primary { get; }

		[JsonProperty("dark")]
		public string Dark { get; }

		[JsonProperty("light")]
		public string Light { get; }

		[JsonProperty("success")]
		public string Success { get; }

		[JsonProperty("warning")]
		public string Warning { get; }

		[JsonProperty("danger")]
		public string Danger { get; }

		[JsonConstructor]
		public ThemeObject([JsonProperty("primary")] string primary, [JsonProperty("dark")] string dark, [JsonProperty("light")] string light, [JsonProperty("success")] string success, [JsonProperty("warning")] string warning, [JsonProperty("danger")] string danger)
		{
			Primary = null;
			Dark = null;
			Light = null;
			Success = null;
			Warning = null;
			Danger = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
