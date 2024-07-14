using System.ComponentModel;

namespace Oculus.Platform
{
	public enum PartyMicState
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("PARTY")]
		Party = 1,
		[Description("APP")]
		App = 2,
		[Description("MUTE")]
		Mute = 3,
		[Description("INACTIVE")]
		Inactive = 4,
		[Description("INPUT_SHARED")]
		InputShared = 5
	}
}
