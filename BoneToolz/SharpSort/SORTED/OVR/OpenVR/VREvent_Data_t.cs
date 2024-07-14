using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	[StructLayout(2)]
	public struct VREvent_Data_t
	{
		public VREvent_Reserved_t reserved;
		
		public VREvent_Controller_t controller;

		public VREvent_Mouse_t mouse;

		public VREvent_Scroll_t scroll;

		public VREvent_Process_t process;

		public VREvent_Notification_t notification;

		public VREvent_Overlay_t overlay;

		public VREvent_Status_t status;

		public VREvent_Ipd_t ipd;

		public VREvent_Chaperone_t chaperone;

		public VREvent_PerformanceTest_t performanceTest;

		public VREvent_TouchPadMove_t touchPadMove;

		public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;

		public VREvent_Screenshot_t screenshot;

		public VREvent_ScreenshotProgress_t screenshotProgress;

		public VREvent_ApplicationLaunch_t applicationLaunch;

		public VREvent_EditingCameraSurface_t cameraSurface;

		public VREvent_MessageOverlay_t messageOverlay;

		public VREvent_Property_t property;

		public VREvent_DualAnalog_t dualAnalog;

		public VREvent_HapticVibration_t hapticVibration;
		
		public VREvent_WebConsole_t webConsole;

		public VREvent_InputBindingLoad_t inputBinding;

		public VREvent_SpatialAnchor_t spatialAnchor;

		public VREvent_Keyboard_t keyboard;
	}
}
