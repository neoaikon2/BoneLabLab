using System.Runtime.CompilerServices;

namespace Steamworks.Data
{
	public struct RemotePlaySession
	{
		public uint Id
		{
			//[IsReadOnly]
			get;
			set; }

		public override string ToString()
		{
			return null;
		}

		public static implicit operator RemotePlaySession(uint value)
		{
			return default(RemotePlaySession);
		}
	}
}
