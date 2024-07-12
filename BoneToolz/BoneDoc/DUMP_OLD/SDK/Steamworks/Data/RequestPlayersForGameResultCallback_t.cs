using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 56)]
	internal struct RequestPlayersForGameResultCallback_t : ICallbackData
	{
		internal enum PlayerAcceptState_t
		{
			Unknown = 0,
			PlayerAccepted = 1,
			PlayerDeclined = 2
		}

		internal Result Result;

		internal ulong LSearchID;

		internal ulong SteamIDPlayerFound;

		internal ulong SteamIDLobby;

		internal PlayerAcceptState_t PlayerAcceptState;

		internal int PlayerIndex;

		internal int TotalPlayersFound;

		internal int TotalPlayersAcceptedGame;

		internal int SuggestedTeamIndex;

		internal ulong LUniqueGameID;

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
