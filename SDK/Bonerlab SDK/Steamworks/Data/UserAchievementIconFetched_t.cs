using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 144)]
	internal struct UserAchievementIconFetched_t : ICallbackData
	{
		internal GameId GameID;

		internal byte[] AchievementName;

		internal bool Achieved;

		internal int IconHandle;

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
