using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct DownloadObject
	{
		[JsonProperty("binary_url")]
		public string BinaryUrl { get; }

		[JsonProperty("date_expires")]
		public long DateExpires { get; }

		[JsonConstructor]
		public DownloadObject([JsonProperty("binary_url")] string binaryUrl, [JsonProperty("date_expires")] long dateExpires)
		{
			BinaryUrl = null;
			DateExpires = 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
