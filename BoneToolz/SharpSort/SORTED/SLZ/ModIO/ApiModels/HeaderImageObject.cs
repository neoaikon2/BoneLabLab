using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct HeaderImageObject
	{
		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("original")]
		public string Original { get; }

		[JsonConstructor]
		public HeaderImageObject([JsonProperty("filename")] string filename, [JsonProperty("original")] string original)
		{
			Filename = null;
			Original = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
