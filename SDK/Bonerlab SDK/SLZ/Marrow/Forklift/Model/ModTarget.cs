using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;

namespace SLZ.Marrow.Forklift.Model
{
	[Serializable]
	public abstract class ModTarget : IPackable
	{
		public string ThumbnailOverride { get; set; }

		public virtual void Pack(ObjectStore store, JObject json)
		{
		}

		public virtual void Unpack(ObjectStore store, string objectId)
		{
		}

		public static ModTarget Create(Type type)
		{
			return null;
		}

		public ModTarget()
			: base()
		{
		}
	}
}
