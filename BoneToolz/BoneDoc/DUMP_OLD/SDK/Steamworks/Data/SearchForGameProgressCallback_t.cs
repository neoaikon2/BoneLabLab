using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 36)]
	internal struct SearchForGameProgressCallback_t : ICallbackData
	{
		internal ulong LSearchID;

		internal Result Result;

		internal ulong LobbyID;

		internal ulong SteamIDEndedSearch;

		internal int SecondsRemainingEstimate;

		internal int CPlayersSearching;

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
