using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct GetGamesObject : IPaginationObject<GameObject>
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

		private IReadOnlyList<GameObject> SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EGameObject_003E_002EData => null;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EGameObject_003E_002EResultCount => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EGameObject_003E_002EResultOffset => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EGameObject_003E_002EResultLimit => 0L;

		private long SLZ_002EModIO_002EApiModels_002EIPaginationObject_003CSLZ_002EModIO_002EApiModels_002EGameObject_003E_002EResultTotal => 0L;

		IReadOnlyList<GameObject> IPaginationObject<GameObject>.Data => throw new NotImplementedException();

		long IPaginationObject<GameObject>.ResultCount => throw new NotImplementedException();

		long IPaginationObject<GameObject>.ResultOffset => throw new NotImplementedException();

		long IPaginationObject<GameObject>.ResultLimit => throw new NotImplementedException();

		long IPaginationObject<GameObject>.ResultTotal => throw new NotImplementedException();

		[JsonConstructor]
		public GetGamesObject([JsonProperty("data")] List<GameObject> data, [JsonProperty("result_count")] long resultCount, [JsonProperty("result_offset")] long resultOffset, [JsonProperty("result_limit")] long resultLimit, [JsonProperty("result_total")] long resultTotal)
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
