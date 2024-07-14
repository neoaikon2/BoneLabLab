using System;

namespace OVR.OpenVR
{
	public class CVRNotifications
	{
		private IVRNotifications FnTable;

		internal CVRNotifications(IntPtr pInterface)
		{
		}

		public EVRNotificationError CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId)
		{
			return default(EVRNotificationError);
		}

		public EVRNotificationError RemoveNotification(uint notificationId)
		{
			return default(EVRNotificationError);
		}
	}
}
