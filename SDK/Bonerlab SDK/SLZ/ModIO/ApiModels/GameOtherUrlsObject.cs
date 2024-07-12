using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GameOtherUrlsObject
	{
		[JsonProperty("url")]
		public string Url { get; }

		[JsonProperty("label")]
		public string Label { get; }

		[JsonConstructor]
		public GameOtherUrlsObject([JsonProperty("url")] string url, [JsonProperty("label")] string label)
		{
			this.Label = default(string);
			this.Url = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
