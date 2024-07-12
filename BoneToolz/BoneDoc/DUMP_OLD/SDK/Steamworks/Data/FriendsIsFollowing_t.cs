using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	internal struct FriendsIsFollowing_t : ICallbackData
	{
		internal Result Result;

		internal ulong SteamID;

		internal bool IsFollowing;

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
