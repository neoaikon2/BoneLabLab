using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 712)]
	internal struct SteamNetConnectionStatusChangedCallback_t : ICallbackData
	{
		internal Connection Conn;

		internal ConnectionInfo Nfo;

		internal ConnectionState OldState;

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
