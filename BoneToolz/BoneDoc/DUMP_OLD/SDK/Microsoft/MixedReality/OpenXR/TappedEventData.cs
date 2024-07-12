using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 4)]
	public struct TappedEventData
	{
		public uint TapCount;
	}
}
