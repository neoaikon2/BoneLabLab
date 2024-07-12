using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct KeyValuePairObject
	{
		[JsonProperty("key")]
		public string Key { get; }

		[JsonProperty("value")]
		public string Value { get; }

		[JsonConstructor]
		public KeyValuePairObject([JsonProperty("key")] string key, [JsonProperty("value")] string value)
		{
			this.Value = default(string);
			this.Key = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
