using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct GetModsObject : IPaginationObject<ModObject>
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

		private IReadOnlyList<ModObject> SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EModObject_003E_002EData => null;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EModObject_003E_002EResultCount => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EModObject_003E_002EResultOffset => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EModObject_003E_002EResultLimit => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EModObject_003E_002EResultTotal => 0L;

		IReadOnlyList<ModObject> IPaginationObject<ModObject>.Data => throw new NotImplementedException();

		long IPaginationObject<ModObject>.ResultCount => throw new NotImplementedException();

		long IPaginationObject<ModObject>.ResultOffset => throw new NotImplementedException();

		long IPaginationObject<ModObject>.ResultLimit => throw new NotImplementedException();

		long IPaginationObject<ModObject>.ResultTotal => throw new NotImplementedException();

		[JsonConstructor]
		public GetModsObject([JsonProperty("data")] List<ModObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
		{
			Data = null;
			ResultCount = 0L;
			ResultOffset = 0L;
			ResultLimit = 0L;
			ResultTotal = 0L;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
