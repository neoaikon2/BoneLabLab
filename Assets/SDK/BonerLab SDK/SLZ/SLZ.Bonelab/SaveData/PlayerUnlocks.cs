using System.Collections.Generic;
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
			return 0;
		}

		public int IncrementUnlockForBarcode(string barcode)
		{
			return 0;
		}

		public bool ClearUnlockForBarcode(string barcode)
		{
			return false;
		}
	}
}
