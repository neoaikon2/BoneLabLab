using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public sealed class Save : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _version;

		private string _modified;

		private string _name;

		private PlayerSettings _playerSettings;

		private PlayerUnlocks _unlocks;

		private PlayerProgression _progression;

		[JsonProperty("version")]
		public int Version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("modified")]
		public string Modified
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("name")]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("player_settings")]
		public PlayerSettings PlayerSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public PlayerUnlocks Unlocks
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("unlocks")]
		public string SerializedUnlocks { get; set; }

		[JsonIgnore]
		public PlayerProgression Progression
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("progression")]
		public string SerializedProgression { get; set; }

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

		public void FixFieldsIfNeeded()
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanging([CallerMemberName] string propertyName = null)
		{
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
		}

		private void PlayerSettingsOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void PlayerSettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void UnlocksOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void UnlocksOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void ProgressionOnPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void ProgressionOnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}
	}
}
