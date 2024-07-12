using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct MetadataKVPObject
	{
		[JsonProperty("metakey")]
		public string Metakey { get; }

		[JsonProperty("metavalue")]
		public string Metavalue { get; }

		[JsonConstructor]
		public MetadataKVPObject([JsonProperty("metakey")] string metakey, [JsonProperty("metavalue")] string metavalue)
		{
			this.Metavalue = default(string);
			this.Metakey = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
