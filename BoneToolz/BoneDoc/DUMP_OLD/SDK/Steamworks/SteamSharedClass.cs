namespace Steamworks
{
	public class SteamSharedClass<T> : SteamClass
	{
		internal static SteamInterface InterfaceClient;

		internal static SteamInterface InterfaceServer;

		internal static SteamInterface Interface
		{
			get
			{
				return null;
			}
		}

		internal override void InitializeInterface(bool server)
		{
		}

		internal virtual void SetInterface(bool server, SteamInterface iface)
		{
		}

		internal override void DestroyInterface(bool server)
		{
		}

		public SteamSharedClass()
			: base()
		{
		}
	}
}
