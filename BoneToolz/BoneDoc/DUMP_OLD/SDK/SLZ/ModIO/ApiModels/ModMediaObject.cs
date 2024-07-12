using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModMediaObject
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
			this.Images = default(IReadOnlyList<ImageObject>);
			this.Sketchfab = default(IReadOnlyList<string>);
			this.Youtube = default(IReadOnlyList<string>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
