using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 144)]
	internal struct GSClientAchievementStatus_t : ICallbackData
	{
		internal ulong SteamID;

		internal byte[] PchAchievement;

		internal bool Unlocked;

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
	}
}
