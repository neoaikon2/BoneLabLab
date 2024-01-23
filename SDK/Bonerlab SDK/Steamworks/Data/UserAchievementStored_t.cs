using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 152)]
	internal struct UserAchievementStored_t : ICallbackData
	{
		internal ulong GameID;

		internal bool GroupAchievement;

		internal byte[] AchievementName;

		internal uint CurProgress;

		internal uint MaxProgress;

		public static int _datasize;

		public int DataSize
		{
			get
			{
				return default(int);
			}
		}

		public CallbackType CallbackType
		{
			get
			{
				return default(CallbackType);
			}
		}

		internal string AchievementNameUTF8()
		{
			return null;
		}
	}
}
