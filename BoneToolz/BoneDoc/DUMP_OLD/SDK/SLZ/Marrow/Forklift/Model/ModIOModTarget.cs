using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public sealed class ModIOModTarget : ModTarget
	{
		public long GameId { get; set; }

		public long ModId { get; set; }

		public long ModfileId { get; set; }

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, string objectId)
		{
		}

		public ModIOModTarget()
			: base()
		{
		}
	}
}
