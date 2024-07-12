using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	internal struct NativeAnchorData
	{
		public uint version;

		public ulong anchorHandle;
	}
}
