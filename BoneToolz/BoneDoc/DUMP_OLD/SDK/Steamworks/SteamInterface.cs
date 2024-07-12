using System;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	internal abstract class SteamInterface
	{
		public IntPtr Self;

		public IntPtr SelfGlobal;

		public IntPtr SelfServer;

		public IntPtr SelfClient;

		public bool IsServer { get; private set; }

		public virtual IntPtr GetUserInterfacePointer()
		{
			return default(IntPtr);
		}

		public virtual IntPtr GetServerInterfacePointer()
		{
			return default(IntPtr);
		}

		public virtual IntPtr GetGlobalInterfacePointer()
		{
			return default(IntPtr);
		}

		internal void SetupInterface(bool gameServer)
		{
		}

		public SteamInterface()
			: base()
		{
		}
	}
}
