using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 12)]
	internal struct PSNGameBootInviteResult_t : ICallbackData
	{
		internal bool GameBootInviteExists;

		internal ulong SteamIDLobby;

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
