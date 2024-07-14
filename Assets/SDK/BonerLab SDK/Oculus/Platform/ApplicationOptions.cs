using System;

namespace Oculus.Platform
{
	public class ApplicationOptions
	{
		private IntPtr Handle;

		public void SetDeeplinkMessage(string value)
		{
		}

		public void SetDestinationApiName(string value)
		{
		}

		public void SetLobbySessionId(string value)
		{
		}

		public void SetMatchSessionId(string value)
		{
		}

		public void SetRoomId(ulong value)
		{
		}

		public static explicit operator IntPtr(ApplicationOptions options)
		{
			return (IntPtr)0;
		}

		~ApplicationOptions()
		{
		}
	}
}
