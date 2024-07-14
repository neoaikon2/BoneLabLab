using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SLZ.MarrowEditor
{
	public class OrderedContractResolver : DefaultContractResolver
	{
		public static readonly JsonSerializerSettings Settings;

		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}
	}
}
