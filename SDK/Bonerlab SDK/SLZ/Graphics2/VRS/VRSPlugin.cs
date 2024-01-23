using System;

namespace SLZ.Graphics2.VRS
{
	public static class VRSPlugin
	{
		public static extern int GetNvApiStatus();

		public static extern IntPtr GetRenderEventFunc();

		public static extern IntPtr GetRenderEventWithDataFunc();

		public static extern void CreateSRRViewStatic(IntPtr texturePtr, int msaa);

		public static extern IntPtr CreateSRRView(IntPtr texturePtr, int msaa);

		public static extern void CleanupSRRView(IntPtr viewPtr);

		public static extern void PopulateSRRTableStatic(int[] table);
	}
}
