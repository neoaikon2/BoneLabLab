using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct KeyValuePairObject
	{
		[JsonProperty("key")]
		public string Key { get; }

		[JsonProperty("value")]
		public string Value { get; }

		[JsonConstructor]
		public KeyValuePairObject([JsonProperty("key")] string key, [JsonProperty("value")] string value)
		{
			Key = null;
			Value = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
