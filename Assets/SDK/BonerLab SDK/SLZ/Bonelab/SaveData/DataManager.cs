using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class DataManager : MarrowDataManager<DataManager, Save, Settings, PlayerProgression, PlayerUnlocks>
	{
		public static DataManager Instance => null;

		public static Settings Settings => null;

		public static Save ActiveSave => null;

		private DataManager()
			: base(0, 0)
		{
		}

		public static bool TrySaveSettings()
		{
			return false;
		}

		public static bool TryLoadActiveSave(SaveFlags flags)
		{
			return false;
		}

		public static bool TrySaveActiveSave(SaveFlags flags)
		{
			return false;
		}

		public static bool TryAutosaveAndSetActive(Save save, SaveFlags flags)
		{
			return false;
		}

		public static void MSAFAIGE()
		{
		}

		private void _MSAFAIGE()
		{
		}
	}
}
