using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct MessageContainer
	{
		[JsonProperty("messages")]
		public readonly IReadOnlyList<Message> Messages;

		[JsonConstructor]
		public MessageContainer(IReadOnlyList<Message> messages)
		{
			this.Messages = default(IReadOnlyList<Message>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
