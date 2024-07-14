using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct MetadataKVPObject
	{
		[JsonProperty("metakey")]
		public string Metakey { get; }

		[JsonProperty("metavalue")]
		public string Metavalue { get; }

		[JsonConstructor]
		public MetadataKVPObject([JsonProperty("metakey")] string metakey, [JsonProperty("metavalue")] string metavalue)
		{
			Metakey = null;
			Metavalue = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
