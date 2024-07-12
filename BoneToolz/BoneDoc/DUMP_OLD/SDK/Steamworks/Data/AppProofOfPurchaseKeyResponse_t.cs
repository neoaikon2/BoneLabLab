using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 252)]
	internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData
	{
		internal Result Result;

		internal uint AppID;

		internal uint CchKeyLength;

		internal byte[] Key;

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
