using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ThemeObject
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
			this.Danger = default(string);
			this.Warning = default(string);
			this.Success = default(string);
			this.Light = default(string);
			this.Dark = default(string);
			this.Primary = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
