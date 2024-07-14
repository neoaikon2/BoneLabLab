using System;

namespace Oculus.Platform.Models
{
	public class UserCapability
	{
		public readonly string Description;

		public readonly bool IsEnabled;

		public readonly string Name;

		public readonly string ReasonCode;

		public UserCapability(IntPtr o)
		{
		}
	}
}
