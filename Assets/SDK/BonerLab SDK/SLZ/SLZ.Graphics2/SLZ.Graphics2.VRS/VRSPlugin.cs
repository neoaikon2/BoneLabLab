using System;
using System.Runtime.InteropServices;

namespace SLZ.Graphics2.VRS
{
	public static class VRSPlugin
	{
		[PreserveSig]
		public static extern int GetNvApiStatus();

		[PreserveSig]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		public static extern IntPtr GetRenderEventWithDataFunc();

		[PreserveSig]
		public static extern void CreateSRRViewStatic(IntPtr texturePtr, int msaa);

		[PreserveSig]
		public static extern IntPtr CreateSRRView(IntPtr texturePtr, int msaa);

		[PreserveSig]
		public static extern void CleanupSRRView(IntPtr viewPtr);

		[PreserveSig]
		public static extern void PopulateSRRTableStatic(int[] table);
	}
}
