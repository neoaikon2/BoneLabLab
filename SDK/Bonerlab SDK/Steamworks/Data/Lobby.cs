using System.Runtime.CompilerServices;

namespace Steamworks.Data
{
	public struct Lobby
	{
		internal SteamId Id { set; get; }

		public Lobby(SteamId id)
		{
			Id = id;
		}
	}
}
