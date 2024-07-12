using System;
using System.Runtime.CompilerServices;

namespace SLZ.ModIO
{
	[Serializable]
	public struct Result
	{
		public readonly Error? Error;

		public readonly bool isError;

		private Result(Error error)
		{
			this.isError = default(bool);
			this.Error = default(Error?);
		}

		public static implicit operator Result(Error error)
		{
			return default(Result);
		}
	}
	[Serializable]	
	public struct Result<T>
	{		
		public readonly T Value;

		public readonly Error? Error;

		public readonly bool isError;

		private Result(T value)
		{
			this.isError = default(bool);
			this.Error = default(Error?);
			this.Value = default(T);
		}

		private Result(Error error)
		{
			this.isError = default(bool);
			this.Error = default(Error?);
			this.Value = default(T);
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
