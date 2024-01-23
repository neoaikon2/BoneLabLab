using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public class PlayerUnlocks : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private Dictionary<string, int> _unlocks;

		[JsonProperty("unlocks")]
		private Dictionary<string, int> Unlocks
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

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

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = null)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
		}
	}
}
