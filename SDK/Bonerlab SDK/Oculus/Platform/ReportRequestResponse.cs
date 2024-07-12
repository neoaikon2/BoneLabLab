using System.ComponentModel;

namespace Oculus.Platform
{
	public enum ReportRequestResponse
	{
		[Description("UNKNOWN")]
		Unknown = 0,
		[Description("HANDLED")]
		Handled = 1,
		[Description("UNHANDLED")]
		Unhandled = 2,
		[Description("UNAVAILABLE")]
		Unavailable = 3
	}
}
