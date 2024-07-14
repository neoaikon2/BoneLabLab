namespace OVR.OpenVR
{
	public enum EVRApplicationTransitionState
	{
		VRApplicationTransition_None = 0,
		VRApplicationTransition_OldAppQuitSent = 10,
		VRApplicationTransition_WaitingForExternalLaunch = 11,
		VRApplicationTransition_NewAppLaunched = 20
	}
}
