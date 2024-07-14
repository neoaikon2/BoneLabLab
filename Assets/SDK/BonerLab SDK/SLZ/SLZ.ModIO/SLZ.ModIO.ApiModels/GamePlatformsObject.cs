using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct GamePlatformsObject
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
			Platform = null;
			Label = null;
			Moderated = false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
