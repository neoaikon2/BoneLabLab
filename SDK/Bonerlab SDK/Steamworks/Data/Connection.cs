using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Steamworks.Data
{
	public struct Connection
	{
		public uint Id
		{			
			get;
		}

		public override string ToString()
		{
			return null;
		}

		public Result Accept()
		{
			return default(Result);
		}

		public bool Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
		{
			return default(bool);
		}
	}
}
