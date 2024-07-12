using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GameTagOptionObject
	{
		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("type")]
		public string Type { get; }

		[JsonProperty("tag_count_map")]
		public IReadOnlyDictionary<string, int> TagCountMap { get; }

		[JsonProperty("hidden")]
		public bool Hidden { get; }

		[JsonProperty("locked")]
		public bool Locked { get; }

		[JsonProperty("tags")]
		public IReadOnlyList<string> Tags { get; }

		[JsonConstructor]
		public GameTagOptionObject([JsonProperty("name")] string name, [JsonProperty("type")] string type, [JsonProperty("tag_count_map")] IReadOnlyDictionary<string, int> tagCountMap, [JsonProperty("hidden")] bool hidden, [JsonProperty("locked")] bool locked, [JsonProperty("tags")] List<string> tags)
		{
			this.Tags = default(IReadOnlyList<string>);
			this.Locked = default(bool);
			this.Hidden = default(bool);
			this.TagCountMap = default(IReadOnlyDictionary<string, int>);
			this.Type = default(string);
			this.Name = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
