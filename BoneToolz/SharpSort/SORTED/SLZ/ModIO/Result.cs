using System;
using System.Runtime.CompilerServices;

namespace SLZ.ModIO
{
	[Serializable]
	public readonly struct Result
	{
		public readonly Error? Error;

		public readonly bool isError;

		private Result(Error error)
		{
			Error = null;
			isError = false;
		}

		public static implicit operator Result(Error error)
		{
			return default(Result);
		}
	}
	[Serializable]
	public readonly struct Result<T> where T : notnull
	{
		public readonly T? Value;

		public readonly Error? Error;

		public readonly bool isError;

		private Result(T value)
		{
			Value = default(T);
			Error = null;
			isError = false;
		}

		private Result(Error error)
		{
			Value = default(T);
			Error = null;
			isError = false;
		}

		public static implicit operator Result<T>(T value)
		{
			return default(Result<T>);
		}

		public static implicit operator Result<T>(Error error)
		{
			return default(Result<T>);
		}
	}
}
