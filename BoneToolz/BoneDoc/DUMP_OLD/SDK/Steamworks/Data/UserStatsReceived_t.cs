using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	internal struct UserStatsReceived_t : ICallbackData
	{
		internal ulong GameID;

		internal Result Result;

		internal ulong SteamIDUser;

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
