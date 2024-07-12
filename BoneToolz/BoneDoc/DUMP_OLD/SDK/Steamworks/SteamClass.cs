namespace Steamworks
{
	public abstract class SteamClass
	{
		internal abstract void InitializeInterface(bool server);

		internal abstract void DestroyInterface(bool server);

		public SteamClass()
			: base()
		{
		}
	}
}
