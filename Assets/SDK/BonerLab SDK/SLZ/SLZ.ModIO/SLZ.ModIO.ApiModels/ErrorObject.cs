using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ErrorObject
	{
		[Serializable]
		public readonly struct ErrorInfo
		{
			[JsonProperty("code")]
			public readonly long Code;

			[JsonProperty("error_ref")]
			public readonly long ErrorRef;

			[JsonProperty("message")]
			public readonly string Message;

			[JsonProperty("errors")]
			public readonly Dictionary<string, object> Errors;

			[JsonConstructor]
			public ErrorInfo([JsonProperty("code")] long code, [JsonProperty("error_ref")] long errorRef, [JsonProperty("message")] string message, Dictionary<string, object> errors)
			{
				Code = 0L;
				ErrorRef = 0L;
				Message = null;
				Errors = null;
			}

			public override string ToString()
			{
				return null;
			}
		}

		[JsonProperty("error")]
		public readonly ErrorInfo Error;

		[JsonConstructor]
		public ErrorObject([JsonProperty("error")] ErrorInfo error)
		{
			Error = default(ErrorInfo);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
