using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public class PlayerProgression : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private bool _beatGame;

		private bool _hasBodyLog;

		private bool _bodyLogEnabled;

		private string _currentCampaignLevel;

		private string _currentLevel;

		private int _menuResume;

		private Dictionary<string, Dictionary<string, object>> _levelState;

		[JsonProperty("beat_game")]
		public bool BeatGame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonProperty("has_body_log")]
		public bool HasBodyLog
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonProperty("body_log_enabled")]
		public bool BodyLogEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonProperty("current_campaign_level")]
		public string CurrentCampaignLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("current_level")]
		public string CurrentLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonProperty("menu_resume")]
		public int MenuResume
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("level_state")]
		public Dictionary<string, Dictionary<string, object>> LevelState
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
