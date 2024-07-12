using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 20)]
	internal struct MarketEligibilityResponse_t : ICallbackData
	{
		internal bool Allowed;

		internal MarketNotAllowedReasonFlags NotAllowedReason;

		internal uint TAllowedAtTime;

		internal int CdaySteamGuardRequiredDays;

		internal int CdayNewDeviceCooldown;

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
