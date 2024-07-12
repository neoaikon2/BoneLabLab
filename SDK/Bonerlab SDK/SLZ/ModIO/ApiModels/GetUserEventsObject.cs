using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct GetUserEventsObject : IPaginationObject<UserEventObject>
	{
		[JsonProperty("data")]
		public readonly IReadOnlyList<UserEventObject> Data;

		[JsonProperty("result_count")]
		public readonly long ResultCount;

		[JsonProperty("result_offset")]
		public readonly long ResultOffset;

		[JsonProperty("result_limit")]
		public readonly long ResultLimit;

		[JsonProperty("result_total")]
		public readonly long ResultTotal;

		IReadOnlyList<UserEventObject> IPaginationObject<UserEventObject>.Data
		{
			get
			{
				return null;
			}
		}

		long IPaginationObject<UserEventObject>.ResultCount
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<UserEventObject>.ResultOffset
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<UserEventObject>.ResultLimit
		{
			get
			{
				return default(long);
			}
		}

		long IPaginationObject<UserEventObject>.ResultTotal
		{
			get
			{
				return default(long);
			}
		}

		[JsonConstructor]
		public GetUserEventsObject([JsonProperty("data")] List<UserEventObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
		{
			this.ResultTotal = default(long);
			this.ResultLimit = default(long);
			this.ResultOffset = default(long);
			this.ResultCount = default(long);
			this.Data = default(IReadOnlyList<UserEventObject>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
