using System;

namespace SLZ.Marrow.Forklift
{
	public readonly struct FetchError
	{
		public Exception Exception { get; }

		public int ErrorCode { get; }

		public string ErrorDescription { get; }

		public int Index { get; }

		public FetchError(Exception exception, int index = -1)
		{
			Exception = null;
			ErrorCode = 0;
			ErrorDescription = null;
			Index = 0;
		}

		public FetchError(int errorCode, string errorDescription, int index = -1)
		{
			Exception = null;
			ErrorCode = 0;
			ErrorDescription = null;
			Index = 0;
		}
	}
}
