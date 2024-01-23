using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout(2, Pack = 1, Size = 136)]
	public struct NetIdentity
	{
		internal enum IdentityType
		{
			Invalid = 0,
			IPAddress = 1,
			GenericString = 2,
			GenericBytes = 3,
			SteamID = 16
		}

		internal IdentityType type;

		internal int size;

		internal ulong steamid;

		internal NetAddress netaddress;

		public override string ToString()
		{
			return null;
		}
	}
}
