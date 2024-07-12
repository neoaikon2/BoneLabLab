using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct AvatarObject
	{
		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("original")]
		public string Original { get; }

		[JsonProperty("thumb_50x50")]
		public string Thumb50x50 { get; }

		[JsonProperty("thumb_100x100")]
		public string Thumb100x100 { get; }

		[JsonConstructor]
		public AvatarObject([JsonProperty("filename")] string filename, [JsonProperty("original")] string original, [JsonProperty("thumb_50x50")] string thumb50x50, [JsonProperty("thumb_100x100")] string thumb100x100)
		{
			this.Thumb100x100 = default(string);
			this.Thumb50x50 = default(string);
			this.Original = default(string);
			this.Filename = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
