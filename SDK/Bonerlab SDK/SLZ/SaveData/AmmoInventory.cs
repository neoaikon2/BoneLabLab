using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public class AmmoInventory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _ammoGlobalLight;

		private int _ammoGlobalMedium;

		private int _ammoGlobalHeavy;

		[JsonProperty("ammo_global_light")]
		public int AmmoGlobalLight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("ammo_global_medium")]
		public int AmmoGlobalMedium
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("ammo_global_heavy")]
		public int AmmoGlobalHeavy
		{
			get
			{
				return 0;
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
