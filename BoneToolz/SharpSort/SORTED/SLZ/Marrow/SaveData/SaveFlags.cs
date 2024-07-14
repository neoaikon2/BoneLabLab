using System;

namespace SLZ.Marrow.SaveData
{
	[Flags]
	public enum SaveFlags
	{
		DefaultAndPlayerSettingsAndUnlocks = 0,
		Progression = 2,
		Complete = 2
	}
}
