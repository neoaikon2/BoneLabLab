using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	internal struct GameConnectedChatJoin_t : ICallbackData
	{
		internal ulong SteamIDClanChat;

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
