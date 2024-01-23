using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public sealed class ModSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private int _maxConnections;

		private int _maxPerHost;

		private int _timeout;

		[JsonProperty("max_connections")]
		public int MaxConnections
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("max_per_host")]
		public int MaxPerHost
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("timeout")]
		public int Timeout
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
	}
}
