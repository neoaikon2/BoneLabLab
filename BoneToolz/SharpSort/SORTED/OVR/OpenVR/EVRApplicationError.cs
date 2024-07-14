namespace OVR.OpenVR
{
	public enum EVRApplicationError
	{
		None = 0,
		AppKeyAlreadyExists = 100,
		NoManifest = 101,
		NoApplication = 102,
		InvalidIndex = 103,
		UnknownApplication = 104,
		IPCFailed = 105,
		ApplicationAlreadyRunning = 106,
		InvalidManifest = 107,
		InvalidApplication = 108,
		LaunchFailed = 109,
		ApplicationAlreadyStarting = 110,
		LaunchInProgress = 111,
		OldApplicationQuitting = 112,
		TransitionAborted = 113,
		IsTemplate = 114,
		SteamVRIsExiting = 115,
		BufferTooSmall = 200,
		PropertyNotSet = 201,
		UnknownProperty = 202,
		InvalidParameter = 203
	}
}
