using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	public struct RemotingListenConfiguration
	{
		public string ListenInterface;

		public ushort HandshakeListenPort;

		public ushort TransportListenPort;

		public uint MaxBitrateKbps;

		public RemotingVideoCodec VideoCodec;

		public bool EnableAudio;
	}
}
