using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.SaveData
{
	public abstract class MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new() where TSettings : class, ISettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		protected internal static TDataManager _instance;

		protected readonly int SettingsVersion;

		protected TSettings _settings;

		protected readonly int SaveVersion;

		protected internal TSave _activeSave;

		[PublicAPI]
		public static string SettingsPath => null;

		[PublicAPI]
		public static string SettingsBackupPath => null;

		[PublicAPI]
		public static string SettingsTempPath => null;

		[PublicAPI]
		public static string SavePath => null;

		protected internal DateTime LastWriteTime { get; private set; }

		private bool _tryReadAndParseSettings(out TSettings settings)
		{
			settings = null;
			return false;
		}

		protected static bool TryWriteSettings(ref TSettings settings)
		{
			return false;
		}

		protected internal bool TryAutosaveAndSetActive(TSave save, SaveFlags flags, out string saveFilename)
		{
			saveFilename = null;
			return false;
		}

		protected bool TryWriteSave(TSave save, string saveFilename, SaveFlags flags)
		{
			return false;
		}

		protected bool DoesSaveFileExist(string filename)
		{
			return false;
		}

		protected bool TryReadSave(ref TSave save, string filename, SaveFlags flags = SaveFlags.Progression)
		{
			return false;
		}

		private void _cleanupOldestSaves()
		{
		}

		protected MarrowDataManager(int settingsVersion, int saveVersion)
		{
		}

		private static string _generateSaveFilename()
		{
			return null;
		}

		[PublicAPI]
		public static bool TryParseDate(string dateString, out DateTime date)
		{
			date = default(DateTime);
			return false;
		}
	}
}
