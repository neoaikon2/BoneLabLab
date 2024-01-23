namespace Steamworks
{
	public struct AppId
	{
		public uint Value;

		public override string ToString()
		{
			return null;
		}

		public static implicit operator AppId(uint value)
		{
			return default(AppId);
		}
	}
}
