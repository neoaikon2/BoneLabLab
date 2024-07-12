using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.ModIO.ApiModels;

namespace SLZ.ModIO
{
	[Serializable]
	[System.Runtime.CompilerServices.Nullable(0)]
	[System.Runtime.CompilerServices.NullableContext(1)]
	public struct Error
	{
		[JsonProperty("api_error")]
		public readonly ErrorObject? ApiError;

		[JsonProperty("exception")]
		[System.Runtime.CompilerServices.Nullable(2)]
		public readonly Exception Exception;

		[JsonProperty("message")]
		[System.Runtime.CompilerServices.Nullable(2)]
		public readonly string Message;

		private Error(ErrorObject apiError)
		{
			this.Message = default(string);
			this.Exception = default(Exception);
			this.ApiError = default(ErrorObject?);
		}

		private Error(Exception exception, string message)
		{
			this.Message = default(string);
			this.Exception = default(Exception);
			this.ApiError = default(ErrorObject?);
		}

		private Error(string message)
		{
			this.Message = default(string);
			this.Exception = default(Exception);
			this.ApiError = default(ErrorObject?);
		}

		public static Result WithApiError(ErrorObject errorObject)
		{
			return default(Result);
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		public static Result<T> WithApiError<T>(ErrorObject errorObject)
		{
			return default(Result<T>);
		}

		public static Result WithException(Exception exception, string message)
		{
			return default(Result);
		}

		public static Result<T> WithException<T>(Exception exception, string message)
		{
			return default(Result<T>);
		}

		public static Result WithMessage(string message)
		{
			return default(Result);
		}

		public static Result<T> WithMessage<T>(string message)
		{
			return default(Result<T>);
		}
	}
}
