using System;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public readonly struct Message
	{
		[JsonProperty("operation")]
		public readonly string Operation;

		[JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
		public readonly object Context;

		[JsonConstructor]
		public Message(string operation, object context)
		{
			Operation = null;
			Context = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
