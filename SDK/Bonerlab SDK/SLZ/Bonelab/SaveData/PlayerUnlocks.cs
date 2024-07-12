using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public class PlayerUnlocks : IUnlocks
	{
		[JsonProperty("unlocks")]
		private Dictionary<string, int> Unlocks { get; set; }

		public int UnlockCountForBarcode(string barcode)
		{
			return default(int);
		}

		public int IncrementUnlockForBarcode(string barcode)
		{
			return default(int);
		}

		public bool ClearUnlockForBarcode(string barcode)
		{
			return default(bool);
		}

		public PlayerUnlocks()
			: base()
		{
		}
	}
}
