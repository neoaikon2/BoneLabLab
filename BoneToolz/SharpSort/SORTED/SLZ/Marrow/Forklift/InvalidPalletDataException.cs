using System;

namespace SLZ.Marrow.Forklift
{
	public class InvalidPalletDataException : Exception
	{
		public InvalidPalletDataException()
		{
		}

		public InvalidPalletDataException(string message)
		{
		}

		public InvalidPalletDataException(string message, Exception inner)
		{
		}
	}
}
