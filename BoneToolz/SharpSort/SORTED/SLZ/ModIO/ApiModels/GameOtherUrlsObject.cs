using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct GameOtherUrlsObject
	{
		[JsonProperty("url")]
		public string Url { get; }

		[JsonProperty("label")]
		public string Label { get; }

		[JsonConstructor]
		public GameOtherUrlsObject([JsonProperty("url")] string url, [JsonProperty("label")] string label)
		{
			Url = null;
			Label = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
