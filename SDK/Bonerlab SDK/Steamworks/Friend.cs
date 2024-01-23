namespace Steamworks
{
	public struct Friend
	{
		public SteamId Id;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public Friend(SteamId steamid)
		{
			this.Id = default(SteamId);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
