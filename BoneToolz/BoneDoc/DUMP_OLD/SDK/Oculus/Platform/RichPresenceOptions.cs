using System;

namespace Oculus.Platform
{
	public class RichPresenceOptions
	{
		private IntPtr Handle;

		public static explicit operator IntPtr(RichPresenceOptions options)
		{
			return default(IntPtr);
		}

		~RichPresenceOptions()
		{
		}

		public RichPresenceOptions()
			: base()
		{
		}
	}
}
