using System;
using Newtonsoft.Json.Linq;

namespace SLZ.ModIO.WebSockets
{
	[Serializable]
	public readonly struct UnknownResponseContext
	{
		public JToken Context { get; }

		public UnknownResponseContext(JToken context)
		{
			Context = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
