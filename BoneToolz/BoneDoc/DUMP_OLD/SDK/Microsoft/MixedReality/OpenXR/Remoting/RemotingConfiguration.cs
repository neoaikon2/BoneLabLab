using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	public struct RemotingConfiguration
	{
		public string RemoteHostName;

		public ushort RemotePort;

		public uint MaxBitrateKbps;

		public RemotingVideoCodec VideoCodec;

		public bool EnableAudio;
	}
}
