using System;

namespace Microsoft.MixedReality.OpenXR
{
	[Flags]
	internal enum NativeSpaceLocationFlags : uint
	{
		OrientationValid = 1u,
		PositionValid = 2u,
		OrientationTracked = 4u,
		PositionTracked = 8u,
		All = 0xFu
	}
}
