using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OVR.OpenVR
{
	public struct IVRInput
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _SetActionManifestPath(string pchActionManifestPath);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionSetHandle(string pchActionSetName, ref ulong pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionHandle(string pchActionName, ref ulong pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _UpdateActionState([In][Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetPoseActionData(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, [In][Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, ref EVRSkeletalTransformSpace peTransformSpace, [In][Out] VRBoneTransform_t[] pTransformArray, uint unTransformArrayCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, [In][Out] ulong[] originsOut, uint originOutCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRInputError _ShowBindingsForActionSet([In][Out] VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, uint unSetCount, ulong originToHighlight);

		internal _SetActionManifestPath SetActionManifestPath;

		internal _GetActionSetHandle GetActionSetHandle;

		internal _GetActionHandle GetActionHandle;

		internal _GetInputSourceHandle GetInputSourceHandle;

		internal _UpdateActionState UpdateActionState;

		internal _GetDigitalActionData GetDigitalActionData;

		internal _GetAnalogActionData GetAnalogActionData;

		internal _GetPoseActionData GetPoseActionData;

		internal _GetSkeletalActionData GetSkeletalActionData;

		internal _GetSkeletalBoneData GetSkeletalBoneData;

		internal _GetSkeletalBoneDataCompressed GetSkeletalBoneDataCompressed;

		internal _DecompressSkeletalBoneData DecompressSkeletalBoneData;

		internal _TriggerHapticVibrationAction TriggerHapticVibrationAction;

		internal _GetActionOrigins GetActionOrigins;

		internal _GetOriginLocalizedName GetOriginLocalizedName;

		internal _GetOriginTrackedDeviceInfo GetOriginTrackedDeviceInfo;

		internal _ShowActionOrigins ShowActionOrigins;

		internal _ShowBindingsForActionSet ShowBindingsForActionSet;
	}
}
