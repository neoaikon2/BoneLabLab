using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 32)]
	internal struct LobbyChatUpdate_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDUserChanged;

		internal ulong SteamIDMakingChange;

		internal uint GfChatMemberStateChange;

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
