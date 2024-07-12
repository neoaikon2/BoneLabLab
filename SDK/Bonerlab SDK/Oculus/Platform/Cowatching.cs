using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public static class Cowatching
	{
		public static Request<string> GetPresenterData()
		{
			return null;
		}

		public static Request<CowatchViewerList> GetViewersData()
		{
			return null;
		}

		public static Request<CowatchingState> IsInSession()
		{
			return null;
		}

		public static Request JoinSession()
		{
			return null;
		}

		public static Request LaunchInviteDialog()
		{
			return null;
		}

		public static Request LeaveSession()
		{
			return null;
		}

		public static Request RequestToPresent()
		{
			return null;
		}

		public static Request ResignFromPresenting()
		{
			return null;
		}

		public static Request SetPresenterData(string video_title, string presenter_data)
		{
			return null;
		}

		public static Request SetViewerData(string viewer_data)
		{
			return null;
		}

		public static void SetApiNotReadyNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetApiReadyNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetInSessionChangedNotificationCallback(Message<CowatchingState>.Callback callback)
		{
		}

		public static void SetInitializedNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetPresenterDataChangedNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetSessionStartedNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetSessionStoppedNotificationCallback(Message<string>.Callback callback)
		{
		}

		public static void SetViewersDataChangedNotificationCallback(Message<CowatchViewerUpdate>.Callback callback)
		{
		}

		public static Request<CowatchViewerList> GetNextCowatchViewerListPage(CowatchViewerList list)
		{
			return null;
		}
	}
}
