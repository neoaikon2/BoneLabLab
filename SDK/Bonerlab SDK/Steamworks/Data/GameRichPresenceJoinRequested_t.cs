using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 264)]
	internal struct GameRichPresenceJoinRequested_t : ICallbackData
	{
		internal ulong SteamIDFriend;

		internal byte[] Connect;

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

		internal string ConnectUTF8()
		{
			return null;
		}
	}
}
