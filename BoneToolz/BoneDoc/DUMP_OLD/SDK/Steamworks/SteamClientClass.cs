namespace Steamworks
{
	public class SteamClientClass<T> : SteamClass
	{
		internal static SteamInterface Interface;

		internal override void InitializeInterface(bool server)
		{
		}

		internal virtual void SetInterface(bool server, SteamInterface iface)
		{
		}

		internal override void DestroyInterface(bool server)
		{
		}

		public SteamClientClass()
			: base()
		{
		}
	}
}
