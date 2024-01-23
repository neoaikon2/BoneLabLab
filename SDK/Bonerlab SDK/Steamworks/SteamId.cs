namespace Steamworks
{
	public struct SteamId
	{
		public ulong Value;

		public static implicit operator SteamId(ulong value)
		{
			return default(SteamId);
		}

		public static implicit operator ulong(SteamId value)
		{
			return default(ulong);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
