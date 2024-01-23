using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SLZ.SaveData
{
	public sealed class DataManager
	{
		private static DataManager _instance;

		private Settings _settings;

		private Save _activeSave;

		public static DataManager Instance => null;

		internal static string SettingsPath => null;

		internal static string SavePath => null;

		public static Settings Settings => null;

		public static Save ActiveSave => null;

		public event OnSavingEventHandler GameSaving
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

		public event OnSavedEventHandler GameSaved
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

		public event OnLoadingEventHandler GameLoading
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

		public event OnLoadedEventHandler GameLoaded
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

		public event OnDataManagerEventHandler DataManagerEventPublished
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

		public static void MSAFAIGE()
		{
		}

		public static void KillAndReplaceActiveSave()
		{
		}

		public static bool TrySaveSettings()
		{
			return false;
		}

		public static void PublishEvent<T>(string eventName, object sender, T obj)
		{
		}

		public static bool TryLoadActiveSave(SaveFlags flags)
		{
			return false;
		}

		public static bool TrySaveActiveSave(SaveFlags flags)
		{
			return false;
		}

		private void _MSAFAIGE()
		{
		}

		private void _killAndReplaceActiveSave()
		{
		}

		private void OnGameSaving(SaveFlags flags)
		{
		}

		private void OnGameSaved(SaveFlags flags, bool cancelledOrFailed, Save save)
		{
		}

		private void OnGameLoading(SaveFlags flags)
		{
		}

		private void OnGameLoaded(SaveFlags flags, bool cancelledOrFailed, Save save)
		{
		}

		private void _publishEvent<T>(string eventName, object sender, T obj)
		{
		}

		private DataManager()
		{
		}

		private static bool _loadOrCreateSettings(ref Settings settings)
		{
			return false;
		}

		private static bool _tryLoadAndParseSettings(ref Settings settings)
		{
			return false;
		}

		private static bool _trySaveSettings(ref Settings settings)
		{
			return false;
		}

		private bool _tryLoadActiveSave(SaveFlags flags)
		{
			return false;
		}

		public bool _trySaveActiveSave(SaveFlags flags)
		{
			return false;
		}

		private bool _tryLoadSave(ref Save save, string filename, SaveFlags flags = SaveFlags.Progression)
		{
			return false;
		}

		private bool _trySaveSaveAs(Save save, string saveFilename, SaveFlags flags)
		{
			return false;
		}

		private void OnSettingsPropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void OnSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		private void OnSavePropertyChanging(object sender, PropertyChangingEventArgs e)
		{
		}

		private void OnSavePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}
	}
}
