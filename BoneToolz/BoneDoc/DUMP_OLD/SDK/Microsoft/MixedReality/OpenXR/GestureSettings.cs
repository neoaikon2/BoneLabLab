using System;

namespace Microsoft.MixedReality.OpenXR
{
	[Flags]
	public enum GestureSettings
	{
		None = 0,
		Tap = 1,
		DoubleTap = 2,
		Hold = 4,
		ManipulationTranslate = 8,
		NavigationX = 0x10,
		NavigationY = 0x20,
		NavigationZ = 0x40,
		NavigationRailsX = 0x80,
		NavigationRailsY = 0x100,
		NavigationRailsZ = 0x200
	}
}
