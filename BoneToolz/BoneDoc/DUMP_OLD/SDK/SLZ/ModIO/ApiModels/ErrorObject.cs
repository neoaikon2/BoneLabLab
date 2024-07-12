using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct ErrorObject
	{
		[Serializable]
		public struct ErrorInfo
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
				this.Errors = default(Dictionary<string, object>);
				this.Message = default(string);
				this.ErrorRef = default(long);
				this.Code = default(long);
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
			this.Error = default(ErrorInfo);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
