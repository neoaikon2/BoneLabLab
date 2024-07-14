using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModTagObject
	{
		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonConstructor]
		public ModTagObject([JsonProperty("name")] string name, [JsonProperty("date_added")] long dateAdded)
		{
			Name = null;
			DateAdded = 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
