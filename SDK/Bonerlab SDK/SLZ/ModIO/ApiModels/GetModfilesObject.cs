using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GetModfilesObject : IPaginationObject<ModfileObject>
	{
		[JsonProperty("data")]
		public readonly IReadOnlyList<ModfileObject> Data;

		[JsonProperty("result_count")]
		public readonly long ResultCount;

		[JsonProperty("result_offset")]
		public readonly long ResultOffset;

		[JsonProperty("result_limit")]
		public readonly long ResultLimit;

		[JsonProperty("result_total")]
		public readonly long ResultTotal;

		IReadOnlyList<ModfileObject> IPaginationObject<ModfileObject>.Data
		{
			get
			{
				return null;
			}
		}

		long IPaginationObject<ModfileObject>.ResultCount
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModfileObject>.ResultOffset
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModfileObject>.ResultLimit
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<ModfileObject>.ResultTotal
		{
			get
			{
				return default(long);
			}
		}

		[JsonConstructor]
		public GetModfilesObject([JsonProperty("data")] List<ModfileObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
		{
			this.ResultTotal = default(long);
			this.ResultLimit = default(long);
			this.ResultOffset = default(long);
			this.ResultCount = default(long);
			this.Data = default(IReadOnlyList<ModfileObject>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
