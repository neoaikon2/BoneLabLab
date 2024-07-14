using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRScreenshots
	{
		private IVRScreenshots FnTable;

		internal CVRScreenshots(IntPtr pInterface)
		{
		}

		public EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		public EVRScreenshotError HookScreenshot(EVRScreenshotType[] pSupportedTypes)
		{
			return default(EVRScreenshotError);
		}

		public EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError)
		{
			return default(EVRScreenshotType);
		}

		public uint GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError)
		{
			return 0u;
		}

		public EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle, float flProgress)
		{
			return default(EVRScreenshotError);
		}

		public EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename)
		{
			return default(EVRScreenshotError);
		}

		public EVRScreenshotError SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename)
		{
			return default(EVRScreenshotError);
		}
	}
}
