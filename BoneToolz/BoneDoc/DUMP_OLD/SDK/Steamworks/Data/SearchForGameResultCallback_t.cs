using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 32)]
	internal struct SearchForGameResultCallback_t : ICallbackData
	{
		internal ulong LSearchID;

		internal Result Result;

		internal int CountPlayersInGame;

		internal int CountAcceptedGame;

		internal ulong SteamIDHost;

		internal bool FinalCallback;

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
