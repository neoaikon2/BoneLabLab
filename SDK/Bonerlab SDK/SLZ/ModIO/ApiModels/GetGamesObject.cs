using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GetGamesObject : IPaginationObject<GameObject>
	{
		[JsonProperty("data")]
		public readonly IReadOnlyList<GameObject> Data;

		[JsonProperty("result_count")]
		public readonly long ResultCount;

		[JsonProperty("result_offset")]
		public readonly long ResultOffset;

		[JsonProperty("result_limit")]
		public readonly long ResultLimit;

		[JsonProperty("result_total")]
		public readonly long ResultTotal;

		IReadOnlyList<GameObject> IPaginationObject<GameObject>.Data
		{
			get
			{
				return null;
			}
		}

		long IPaginationObject<GameObject>.ResultCount
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<GameObject>.ResultOffset
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<GameObject>.ResultLimit
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<GameObject>.ResultTotal
		{
			get
			{
				return default(long);
			}
		}

		[JsonConstructor]
		public GetGamesObject([JsonProperty("data")] List<GameObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
		{
			this.ResultTotal = default(long);
			this.ResultLimit = default(long);
			this.ResultOffset = default(long);
			this.ResultCount = default(long);
			this.Data = default(IReadOnlyList<GameObject>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
