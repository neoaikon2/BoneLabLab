using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRSpatialAnchors
	{
		private IVRSpatialAnchors FnTable;

		internal CVRSpatialAnchors(IntPtr pInterface)
		{
		}

		public EVRSpatialAnchorError CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut)
		{
			return default(EVRSpatialAnchorError);
		}

		public EVRSpatialAnchorError CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut)
		{
			return default(EVRSpatialAnchorError);
		}

		public EVRSpatialAnchorError GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut)
		{
			return default(EVRSpatialAnchorError);
		}

		public EVRSpatialAnchorError GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut)
		{
			return default(EVRSpatialAnchorError);
		}
	}
}
