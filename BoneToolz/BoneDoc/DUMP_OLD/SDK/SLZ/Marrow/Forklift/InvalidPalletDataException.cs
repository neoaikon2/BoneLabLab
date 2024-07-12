using System;

namespace SLZ.Marrow.Forklift
{
	public class InvalidPalletDataException : Exception
	{
		public InvalidPalletDataException()
			: base()
		{
		}

		public InvalidPalletDataException(string message)
			: this()
		{
		}

		public InvalidPalletDataException(string message, Exception inner)
			: this()
		{
		}
	}
}
