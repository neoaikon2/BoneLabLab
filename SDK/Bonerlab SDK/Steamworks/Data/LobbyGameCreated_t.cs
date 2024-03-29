using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	internal struct LobbyGameCreated_t : ICallbackData
	{
		internal ulong SteamIDLobby;

		internal ulong SteamIDGameServer;

		internal uint IP;

		internal ushort Port;

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
