using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct Message
	{
		[JsonProperty("operation")]
		public readonly string Operation;

		[JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
		public readonly object Context;

		[JsonConstructor]
		public Message(string operation, object context)
		{
			this.Context = default(object);
			this.Operation = default(string);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
