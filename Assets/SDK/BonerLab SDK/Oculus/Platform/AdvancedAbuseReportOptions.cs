using System;

namespace Oculus.Platform
{
	public class AdvancedAbuseReportOptions
	{
		private IntPtr Handle;

		public void SetDeveloperDefinedContext(string key, string value)
		{
		}

		public void ClearDeveloperDefinedContext()
		{
		}

		public void SetObjectType(string value)
		{
		}

		public void SetReportType(AbuseReportType value)
		{
		}

		public void AddSuggestedUser(ulong userID)
		{
		}

		public void ClearSuggestedUsers()
		{
		}

		public void SetVideoMode(AbuseReportVideoMode value)
		{
		}

		public static explicit operator IntPtr(AdvancedAbuseReportOptions options)
		{
			return (IntPtr)0;
		}

		~AdvancedAbuseReportOptions()
		{
		}
	}
}
