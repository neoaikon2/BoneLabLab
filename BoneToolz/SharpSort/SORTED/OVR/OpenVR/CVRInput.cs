using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRInput
	{
		private IVRInput FnTable;

		internal CVRInput(IntPtr pInterface)
		{
		}

		public EVRInputError SetActionManifestPath(string pchActionManifestPath)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetActionSetHandle(string pchActionSetName, ref ulong pHandle)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetActionHandle(string pchActionName, ref ulong pHandle)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetInputSourceHandle(string pchInputSourcePath, ref ulong pHandle)
		{
			return default(EVRInputError);
		}

		public EVRInputError UpdateActionState(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetDigitalActionData(ulong action, ref InputDigitalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetAnalogActionData(ulong action, ref InputAnalogActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetPoseActionData(ulong action, ETrackingUniverseOrigin eOrigin, float fPredictedSecondsFromNow, ref InputPoseActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetSkeletalActionData(ulong action, ref InputSkeletalActionData_t pActionData, uint unActionDataSize, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetSkeletalBoneData(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, VRBoneTransform_t[] pTransformArray, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetSkeletalBoneDataCompressed(ulong action, EVRSkeletalTransformSpace eTransformSpace, EVRSkeletalMotionRange eMotionRange, IntPtr pvCompressedData, uint unCompressedSize, ref uint punRequiredCompressedSize, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError DecompressSkeletalBoneData(IntPtr pvCompressedBuffer, uint unCompressedBufferSize, ref EVRSkeletalTransformSpace peTransformSpace, VRBoneTransform_t[] pTransformArray)
		{
			return default(EVRInputError);
		}

		public EVRInputError TriggerHapticVibrationAction(ulong action, float fStartSecondsFromNow, float fDurationSeconds, float fFrequency, float fAmplitude, ulong ulRestrictToDevice)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetActionOrigins(ulong actionSetHandle, ulong digitalActionHandle, ulong[] originsOut)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetOriginLocalizedName(ulong origin, StringBuilder pchNameArray, uint unNameArraySize)
		{
			return default(EVRInputError);
		}

		public EVRInputError GetOriginTrackedDeviceInfo(ulong origin, ref InputOriginInfo_t pOriginInfo, uint unOriginInfoSize)
		{
			return default(EVRInputError);
		}

		public EVRInputError ShowActionOrigins(ulong actionSetHandle, ulong ulActionHandle)
		{
			return default(EVRInputError);
		}

		public EVRInputError ShowBindingsForActionSet(VRActiveActionSet_t[] pSets, uint unSizeOfVRSelectedActionSet_t, ulong originToHighlight)
		{
			return default(EVRInputError);
		}
	}
}
