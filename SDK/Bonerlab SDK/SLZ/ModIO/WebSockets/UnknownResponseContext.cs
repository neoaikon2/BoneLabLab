using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public struct UnknownResponseContext
	{
		public JToken Context { get; }

		public UnknownResponseContext(JToken context)
		{
			this.Context = default(JToken);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
