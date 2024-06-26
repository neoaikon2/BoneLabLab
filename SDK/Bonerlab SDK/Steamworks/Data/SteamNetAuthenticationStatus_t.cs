using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 260)]
	internal struct SteamNetAuthenticationStatus_t : ICallbackData
	{
		internal SteamNetworkingAvailability Avail;

		internal byte[] DebugMsg;

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
