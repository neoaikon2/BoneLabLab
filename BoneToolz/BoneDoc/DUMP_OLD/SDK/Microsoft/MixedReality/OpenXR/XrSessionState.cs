namespace Microsoft.MixedReality.OpenXR
{
	internal enum XrSessionState
	{
		Unknown = 0,
		Idle = 1,
		Ready = 2,
		Synchronized = 3,
		Visible = 4,
		Focused = 5,
		Stopping = 6,
		LossPending = 7,
		Exiting = 8
	}
}
