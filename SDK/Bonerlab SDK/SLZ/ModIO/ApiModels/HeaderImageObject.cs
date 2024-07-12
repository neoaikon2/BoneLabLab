using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct HeaderImageObject
	{
		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("original")]
		public string Original { get; }

		[JsonConstructor]
		public HeaderImageObject([JsonProperty("filename")] string filename, [JsonProperty("original")] string original)
		{
			this.Original = default(string);
			this.Filename = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
