using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModPlatformsObject
	{
		[JsonProperty("platform")]
		public string Platform { get; }

		[JsonProperty("modfile_live")]
		public int ModfileLive { get; }

		[JsonConstructor]
		public ModPlatformsObject([JsonProperty("platform")] string platform, [JsonProperty("modfile_live")] int modfileLive)
		{
			this.ModfileLive = default(int);
			this.Platform = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
