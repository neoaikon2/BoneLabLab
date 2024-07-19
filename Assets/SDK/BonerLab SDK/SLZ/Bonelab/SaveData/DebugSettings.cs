using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DebugSettings : IDebugSettings, IFixFieldsIfNeeded
	{
		[JsonExtensionData]
		public IDictionary<string, JToken> AdditionalData { get; set; }

		[JsonProperty("developer_mode")]
		public bool DeveloperMode { get; set; }

		public void FixFieldsIfNeeded()
		{
		}
	}
}
