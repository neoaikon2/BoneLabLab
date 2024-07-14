using System;

namespace Oculus.Platform
{
	public sealed class Packet : IDisposable
	{
		private readonly ulong size;

		private readonly IntPtr packetHandle;

		public ulong SenderID => 0uL;

		public ulong Size => 0uL;

		public Packet(IntPtr packetHandle)
		{
		}

		public ulong ReadBytes(byte[] destination)
		{
			return 0uL;
		}

		~Packet()
		{
		}

		public void Dispose()
		{
		}
	}
}
