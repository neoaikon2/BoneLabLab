using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DataManager : MarrowDataManager<DataManager>
	{
		public static DataManager Instance
		{
			get
			{
				return null;
			}
		}

		public static Settings Settings
		{
			get
			{
				return null;
			}
		}

		public static Save ActiveSave
		{
			get
			{
				return null;
			}
		}

		private DataManager()
			: base(default(System.Int32), default(System.Int32))
		{
		}

		public static bool TrySaveSettings()
		{
			return default(bool);
		}

		public static bool TryLoadActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		public static bool TrySaveActiveSave(SaveFlags flags)
		{
			return default(bool);
		}

		public static bool TryAutosaveAndSetActive(Save save, SaveFlags flags)
		{
			return default(bool);
		}

		public static void MSAFAIGE()
		{
		}

		private void _MSAFAIGE()
		{
		}
	}
}
