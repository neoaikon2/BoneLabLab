using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GetModsObject : IPaginationObject<ModObject>
	{
		[JsonProperty("data")]
		public readonly IReadOnlyList<ModObject> Data;

		[JsonProperty("result_count")]
		public readonly long ResultCount;

		[JsonProperty("result_offset")]
		public readonly long ResultOffset;

		[JsonProperty("result_limit")]
		public readonly long ResultLimit;

		[JsonProperty("result_total")]
		public readonly long ResultTotal;

		IReadOnlyList<ModObject> IPaginationObject<ModObject>.Data
		{
			get
			{
				return null;
			}
		}

		long IPaginationObject<ModObject>.ResultCount
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModObject>.ResultOffset
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModObject>.ResultLimit
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModObject>.ResultTotal
		{
			get
			{
				return default(long);
			}
		}

		[JsonConstructor]
		public GetModsObject([JsonProperty("data")] List<ModObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
		{
			this.ResultTotal = default(long);
			this.ResultLimit = default(long);
			this.ResultOffset = default(long);
			this.ResultCount = default(long);
			this.Data = default(IReadOnlyList<ModObject>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
