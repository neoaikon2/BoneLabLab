using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModfilePlatformObject
	{
		[JsonProperty("platform")]
		public string Platform { get; }

		[JsonProperty("status")]
		public int Status { get; }

		[JsonConstructor]
		public ModfilePlatformObject([JsonProperty("platform")] string platform, [JsonProperty("status")] int status)
		{
			Platform = null;
			Status = 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
