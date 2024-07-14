using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct IVRNotifications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);

		internal _CreateNotification CreateNotification;

		internal _RemoveNotification RemoveNotification;
	}
}
