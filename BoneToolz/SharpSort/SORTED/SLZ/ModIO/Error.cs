using System;
using Newtonsoft.Json;
using SLZ.ModIO.ApiModels;

namespace SLZ.ModIO
{
	[Serializable]
	public readonly struct Error
	{
		[JsonProperty("api_error")]
		public readonly ErrorObject? ApiError;

		[JsonProperty("exception")]
		public readonly Exception? Exception;

		[JsonProperty("message")]
		public readonly string? Message;

		private Error(ErrorObject apiError)
		{
			ApiError = null;
			Exception = null;
			Message = null;
		}

		private Error(Exception exception, string message)
		{
			ApiError = null;
			Exception = null;
			Message = null;
		}

		private Error(string message)
		{
			ApiError = null;
			Exception = null;
			Message = null;
		}

		public static Result WithApiError(ErrorObject errorObject)
		{
			return default(Result);
		}

		public static Result<T?> WithApiError<T>(ErrorObject errorObject)
		{
			return default(Result<T>);
		}

		public static Result WithException(Exception exception, string message)
		{
			return default(Result);
		}

		public static Result<T> WithException<T>(Exception exception, string message) where T : notnull
		{
			return default(Result<T>);
		}

		public static Result WithMessage(string message)
		{
			return default(Result);
		}

		public static Result<T> WithMessage<T>(string message) where T : notnull
		{
			return default(Result<T>);
		}
	}
}
