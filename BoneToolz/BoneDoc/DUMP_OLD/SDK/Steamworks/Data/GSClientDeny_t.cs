using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 144)]
	internal struct GSClientDeny_t : ICallbackData
	{
		internal ulong SteamID;

		internal DenyReason DenyReason;

		internal byte[] OptionalText;

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
