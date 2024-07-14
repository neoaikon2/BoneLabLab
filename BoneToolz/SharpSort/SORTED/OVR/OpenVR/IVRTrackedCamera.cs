using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct IVRTrackedCamera
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraIntrinsics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);

		internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

		internal _HasCamera HasCamera;

		internal _GetCameraFrameSize GetCameraFrameSize;

		internal _GetCameraIntrinsics GetCameraIntrinsics;

		internal _GetCameraProjection GetCameraProjection;

		internal _AcquireVideoStreamingService AcquireVideoStreamingService;

		internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

		internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

		internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

		internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

		internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

		internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;
	}
}
