using System;

namespace TMPro
{
	[Flags]
	public enum FontFeatureLookupFlags
	{
		None = 0,
		IgnoreLigatures = 4,
		IgnoreSpacingAdjustments = 0x100
	}
}
