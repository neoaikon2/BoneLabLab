using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public struct IVRSpatialAnchors
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromDescriptor(string pchDescriptor, ref uint pHandleOut);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _CreateSpatialAnchorFromPose(uint unDeviceIndex, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPose, ref uint pHandleOut);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorPose(uint unHandle, ETrackingUniverseOrigin eOrigin, ref SpatialAnchorPose_t pPoseOut);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRSpatialAnchorError _GetSpatialAnchorDescriptor(uint unHandle, StringBuilder pchDescriptorOut, ref uint punDescriptorBufferLenInOut);

		internal _CreateSpatialAnchorFromDescriptor CreateSpatialAnchorFromDescriptor;

		internal _CreateSpatialAnchorFromPose CreateSpatialAnchorFromPose;

		internal _GetSpatialAnchorPose GetSpatialAnchorPose;

		internal _GetSpatialAnchorDescriptor GetSpatialAnchorDescriptor;
	}
}
