using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct LogoObject
	{
		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("original")]
		public string Original { get; }

		[JsonProperty("thumb_320x180")]
		public string Thumb320x180 { get; }

		[JsonProperty("thumb_640x360")]
		public string Thumb640x360 { get; }

		[JsonProperty("thumb_1280x720")]
		public string Thumb1280x720 { get; }

		[JsonConstructor]
		public LogoObject([JsonProperty("filename")] string filename, [JsonProperty("original")] string original, [JsonProperty("thumb_320x180")] string thumb320x180, [JsonProperty("thumb_640x360")] string thumb640x360, [JsonProperty("thumb_1280x720")] string thumb1280x720)
		{
			Filename = null;
			Original = null;
			Thumb320x180 = null;
			Thumb640x360 = null;
			Thumb1280x720 = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
