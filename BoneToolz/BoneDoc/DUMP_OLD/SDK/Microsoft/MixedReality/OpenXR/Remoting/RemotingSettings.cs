using System.Runtime.CompilerServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	internal class RemotingSettings : ScriptableObject
	{
		public string RemoteHostName { get; set; }

		public ushort RemoteHostPort { get; set; }

		public uint MaxBitrate { get; set; }

		public RemotingVideoCodec VideoCodec { get; set; }

		public bool EnableAudio { get; set; }

		public RemotingSettings()
			: base()
		{
		}
	}
}
