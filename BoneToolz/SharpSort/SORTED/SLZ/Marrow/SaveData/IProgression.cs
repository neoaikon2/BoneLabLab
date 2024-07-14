using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	public interface IProgression
	{
		[JsonProperty("level_state")]
		Dictionary<string, Dictionary<string, object>> LevelState { get; set; }
	}
}
