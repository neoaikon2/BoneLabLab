using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.SaveData
{
	public abstract class MarrowDataManager<DataManager, Save, Settings, PlayerProgression, PlayerUnlocks>
	{
		protected internal static DataManager _instance;

		protected readonly int SettingsVersion;

		protected Settings _settings;

		protected readonly int SaveVersion;

		protected internal Save _activeSave;

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

		private bool _tryReadAndParseSettings([Out] Settings settings)
		{
			return default(bool);
		}

		protected static bool TryWriteSettings(Settings settings)
		{
			return default(bool);
		}

		protected internal bool TryAutosaveAndSetActive(Save save, SaveFlags flags, [Out] string saveFilename)
		{
			return default(bool);
		}

		protected bool TryWriteSave(Save save, string saveFilename, SaveFlags flags)
		{
			return default(bool);
		}

		protected bool DoesSaveFileExist(string filename)
		{
			return default(bool);
		}

		protected bool TryReadSave(Save save, string filename, SaveFlags flags = SaveFlags.Progression)
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
