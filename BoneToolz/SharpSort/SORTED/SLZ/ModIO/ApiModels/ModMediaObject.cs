using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModMediaObject
	{
		[JsonProperty("youtube")]
		public IReadOnlyList<string> Youtube { get; }

		[JsonProperty("sketchfab")]
		public IReadOnlyList<string> Sketchfab { get; }

		[JsonProperty("images")]
		public IReadOnlyList<ImageObject> Images { get; }

		[JsonConstructor]
		public ModMediaObject([JsonProperty("youtube")] List<string> youtube, [JsonProperty("sketchfab")] List<string> sketchfab, [JsonProperty("images")] List<ImageObject> images)
		{
			Youtube = null;
			Sketchfab = null;
			Images = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
