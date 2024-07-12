using System;

namespace SLZ.Marrow.Forklift
{
	public class PalletCollisionException : Exception
	{
		public string palletBarcode;

		public string installedModName;

		public long installedModID;

		public string downloadedModName;

		public long downloadedModID;

		public PalletCollisionException()
			: base()
		{
		}

		public PalletCollisionException(string message)
			: this()
		{
		}

		public PalletCollisionException(string message, Exception inner)
			: this()
		{
		}

		public PalletCollisionException(string message, string palletBarcode, string installedModName, long installedModID, string downloadedModName, long downloadedModID)
			: this()
		{
		}
	}
}
