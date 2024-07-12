using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GamePlatformsObject
	{
		[JsonProperty("platform")]
		public string Platform { get; }

		[JsonProperty("label")]
		public string Label { get; }

		[JsonProperty("moderated")]
		public bool Moderated { get; }

		[JsonConstructor]
		public GamePlatformsObject([JsonProperty("platform")] string platform, [JsonProperty("label")] string label, [JsonProperty("moderated")] bool moderated)
		{
			this.Moderated = default(bool);
			this.Label = default(string);
			this.Platform = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
