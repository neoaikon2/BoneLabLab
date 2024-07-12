using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	internal struct GameConnectedChatLeave_t : ICallbackData
	{
		internal ulong SteamIDClanChat;

		internal ulong SteamIDUser;

		internal bool Kicked;

		internal bool Dropped;

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
