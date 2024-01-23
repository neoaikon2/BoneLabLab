using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct ClientGameServerDeny_t : ICallbackData
	{
		internal uint AppID;

		internal uint GameServerIP;

		internal ushort GameServerPort;

		internal ushort Secure;

		internal uint Reason;

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
