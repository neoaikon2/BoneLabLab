using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModPlatformsObject
	{
		[JsonProperty("platform")]
		public string Platform { get; }

		[JsonProperty("modfile_live")]
		public int ModfileLive { get; }

		[JsonConstructor]
		public ModPlatformsObject([JsonProperty("platform")] string platform, [JsonProperty("modfile_live")] int modfileLive)
		{
			Platform = null;
			ModfileLive = 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
