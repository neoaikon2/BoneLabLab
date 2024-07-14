using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct IconObject
	{
		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("original")]
		public string Original { get; }

		[JsonProperty("thumb_64x64")]
		public string Thumb64x64 { get; }

		[JsonProperty("thumb_128x128")]
		public string Thumb128x128 { get; }

		[JsonProperty("thumb_256x256")]
		public string Thumb256x256 { get; }

		[JsonConstructor]
		public IconObject([JsonProperty("filename")] string filename, [JsonProperty("original")] string original, [JsonProperty("thumb_64x64")] string thumb64x64, [JsonProperty("thumb_128x128")] string thumb128x128, [JsonProperty("thumb_256x256")] string thumb256x256)
		{
			Filename = null;
			Original = null;
			Thumb64x64 = null;
			Thumb128x128 = null;
			Thumb256x256 = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
