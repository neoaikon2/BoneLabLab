using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ModTagObject
	{
		[JsonProperty("name")]
		public string Name { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonConstructor]
		public ModTagObject([JsonProperty("name")] string name, [JsonProperty("date_added")] long dateAdded)
		{
			this.DateAdded = default(long);
			this.Name = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
