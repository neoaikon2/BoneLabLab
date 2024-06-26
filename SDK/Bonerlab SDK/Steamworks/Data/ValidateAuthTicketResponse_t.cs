using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	internal struct ValidateAuthTicketResponse_t : ICallbackData
	{
		internal ulong SteamID;

		internal AuthResponse AuthSessionResponse;

		internal ulong OwnerSteamID;

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
