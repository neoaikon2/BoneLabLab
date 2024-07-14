using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRSystem
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _PollNextEventPacked(ref VREvent_t_Packed pEvent, uint uncbVREvent);

		[StructLayout(2)]
		private struct PollNextEventUnion
		{
			public IVRSystem._PollNextEvent pPollNextEvent;

			public _PollNextEventPacked pPollNextEventPacked;
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStatePacked(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize);

		[StructLayout(2)]
		private struct GetControllerStateUnion
		{
			public IVRSystem._GetControllerState pGetControllerState;

			public _GetControllerStatePacked pGetControllerStatePacked;
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetControllerStateWithPosePacked(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);

		[StructLayout(2)]
		private struct GetControllerStateWithPoseUnion
		{
			public IVRSystem._GetControllerStateWithPose pGetControllerStateWithPose;

			public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked;
		}

		private IVRSystem FnTable;

		internal CVRSystem(IntPtr pInterface)
		{
		}

		public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight)
		{
		}

		public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ)
		{
			return default(HmdMatrix44_t);
		}

		public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom)
		{
		}

		public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates)
		{
			return false;
		}

		public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
		{
			return default(HmdMatrix34_t);
		}

		public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter)
		{
			return false;
		}

		public int GetD3D9AdapterIndex()
		{
			return 0;
		}

		public void GetDXGIOutputInfo(ref int pnAdapterIndex)
		{
		}

		public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance)
		{
		}

		public bool IsDisplayOnDesktop()
		{
			return false;
		}

		public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
		{
			return false;
		}

		public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray)
		{
		}

		public void ResetSeatedZeroPose()
		{
		}

		public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
		{
			return default(HmdMatrix34_t);
		}

		public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, uint[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex)
		{
			return 0u;
		}

		public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
		{
			return default(EDeviceActivityLevel);
		}

		public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform)
		{
		}

		public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
		{
			return 0u;
		}

		public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
		{
			return default(ETrackedControllerRole);
		}

		public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
		{
			return default(ETrackedDeviceClass);
		}

		public bool IsTrackedDeviceConnected(uint unDeviceIndex)
		{
			return false;
		}

		public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return false;
		}

		public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return 0f;
		}

		public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return 0;
		}

		public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return 0uL;
		}

		public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError)
		{
			return default(HmdMatrix34_t);
		}

		public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return 0u;
		}

		public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError)
		{
			return 0u;
		}

		public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
		{
			return null;
		}

		public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent)
		{
			return false;
		}

		public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return false;
		}

		public string GetEventTypeNameFromEnum(EVREventType eType)
		{
			return null;
		}

		public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type)
		{
			return default(HiddenAreaMesh_t);
		}

		public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize)
		{
			return false;
		}

		public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose)
		{
			return false;
		}

		public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec)
		{
		}

		public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
		{
			return null;
		}

		public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
		{
			return null;
		}

		public bool IsInputAvailable()
		{
			return false;
		}

		public bool IsSteamVRDrawingControllers()
		{
			return false;
		}

		public bool ShouldApplicationPause()
		{
			return false;
		}

		public bool ShouldApplicationReduceRenderingWork()
		{
			return false;
		}

		public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize)
		{
			return 0u;
		}

		public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
		{
			return default(EVRFirmwareError);
		}

		public void AcknowledgeQuit_Exiting()
		{
		}

		public void AcknowledgeQuit_UserPrompt()
		{
		}
	}
}
