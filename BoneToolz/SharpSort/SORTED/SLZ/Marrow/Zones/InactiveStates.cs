using System;

namespace SLZ.Marrow.Zones
{
	[Flags]
	public enum InactiveStates
	{
		None = 0,
		Hide = 1,
		Cull = 2,
		Despawn = 4,
		All = 7
	}
}
