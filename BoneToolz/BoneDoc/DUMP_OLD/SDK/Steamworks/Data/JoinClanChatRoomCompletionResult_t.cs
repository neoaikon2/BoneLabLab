using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct JoinClanChatRoomCompletionResult_t : ICallbackData
	{
		internal ulong SteamIDClanChat;

		internal RoomEnter ChatRoomEnterResponse;

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
