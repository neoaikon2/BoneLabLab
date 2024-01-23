using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 40)]
	internal struct GSReputation_t : ICallbackData
	{
		internal Result Result;

		internal uint ReputationScore;

		internal bool Banned;

		internal uint BannedIP;

		internal ushort BannedPort;

		internal ulong BannedGameID;

		internal uint BanExpires;

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
