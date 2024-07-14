using System;

namespace Oculus.Platform
{
	public class AvatarEditorOptions
	{
		private IntPtr Handle;

		public void SetSourceOverride(string value)
		{
		}

		public static explicit operator IntPtr(AvatarEditorOptions options)
		{
			return (IntPtr)0;
		}

		~AvatarEditorOptions()
		{
		}
	}
}
