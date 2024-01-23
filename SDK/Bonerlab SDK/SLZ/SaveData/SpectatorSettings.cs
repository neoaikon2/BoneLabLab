using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace SLZ.SaveData
{
	public sealed class SpectatorSettings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private EyeTarget _eyeOutput;

		private SpectatorCameraMode _spectatorCameraMode;

		private int _resolutionX;

		private int _resolutionY;

		[JsonProperty("eye_output")]
		public EyeTarget EyeOutput
		{
			get
			{
				return default(EyeTarget);
			}
			set
			{
			}
		}

		[JsonProperty("spectator_camera_mode")]
		public SpectatorCameraMode SpectatorCameraMode
		{
			get
			{
				return default(SpectatorCameraMode);
			}
			set
			{
			}
		}

		[JsonProperty("resolution_x")]
		public int ResolutionX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonProperty("resolution_y")]
		public int ResolutionY
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
