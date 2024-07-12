using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModfilePlatformObject
	{
		[JsonProperty("platform")]
		public string Platform { get; }

		[JsonProperty("status")]
		public int Status { get; }

		[JsonConstructor]
		public ModfilePlatformObject([JsonProperty("platform")] string platform, [JsonProperty("status")] int status)
		{
			this.Status = default(int);
			this.Platform = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
