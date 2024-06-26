using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct LobbyEnter_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal uint GfChatPermissions;

		internal bool Locked;

		internal uint EChatRoomEnterResponse;

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
