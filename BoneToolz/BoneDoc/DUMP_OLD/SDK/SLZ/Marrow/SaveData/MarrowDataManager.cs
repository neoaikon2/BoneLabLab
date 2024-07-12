using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.SaveData
{
	public abstract class MarrowDataManager<TDataManager, TSave, TProgression, TUnlocks, TSettings> where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new()where TProgression : class, IProgression, new()where TUnlocks : class, IUnlocks, new()where TSettings : class, ISettings, new()
	{
		protected internal static TDataManager _instance;

		protected readonly int SettingsVersion;

		protected TSettings _settings;

		protected readonly int SaveVersion;

		protected internal TSave _activeSave;

		[PublicAPI]
		public static string SettingsPath
		{
			get
			{
				return null;
			}
		}

		[PublicAPI]
		public static string SettingsBackupPath
		{
			get
			{
				return null;
			}
		}

		[PublicAPI]
		public static string SettingsTempPath
		{
			get
			{
				return null;
			}
		}

		[PublicAPI]
		public static string SavePath
		{
			get
			{
				return null;
			}
		}

		protected internal DateTime LastWriteTime { get; private set; }

		private bool _tryReadAndParseSettings([Out] TSettings settings)
		{
			return default(bool);
		}

		protected static bool TryWriteSettings(TSettings settings)
		{
			return default(bool);
		}

		protected internal bool TryAutosaveAndSetActive(TSave save, SaveFlags flags, [Out] string saveFilename)
		{
			return default(bool);
		}

		protected bool TryWriteSave(TSave save, string saveFilename, SaveFlags flags)
		{
			return default(bool);
		}

		protected bool DoesSaveFileExist(string filename)
		{
			return default(bool);
		}

		protected bool TryReadSave(TSave save, string filename, SaveFlags flags = SaveFlags.Progression)
		{
			return default(bool);
		}

		private void _cleanupOldestSaves()
		{
		}

		protected MarrowDataManager(int settingsVersion, int saveVersion)
			: base()
		{
		}

		private static string _generateSaveFilename()
		{
			return null;
		}

		[PublicAPI]
		public static bool TryParseDate(string dateString, [Out] DateTime date)
		{
			return default(bool);
		}
	}
}
