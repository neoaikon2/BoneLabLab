using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DebugSettings
	{
		[JsonExtensionData]
		public IDictionary<string, JToken> AdditionalData { get; set; }

		[JsonProperty("developer_mode")]
		public bool DeveloperMode { get; set; }

		public void FixFieldsIfNeeded()
		{
		}

		public DebugSettings()
			: base()
		{
		}
	}
}
