using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public readonly struct MessageContainer
	{
		[JsonProperty("messages")]
		public readonly IReadOnlyList<Message> Messages;

		[JsonConstructor]
		public MessageContainer(IReadOnlyList<Message> messages)
		{
			Messages = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
