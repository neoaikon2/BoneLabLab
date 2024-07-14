using System;
using System.Text;

namespace OVR.OpenVR
{
	public class CVRApplications
	{
		private IVRApplications FnTable;

		internal CVRApplications(IntPtr pInterface)
		{
		}

		public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
		{
			return default(EVRApplicationError);
		}

		public bool IsApplicationInstalled(string pchAppKey)
		{
			return false;
		}

		public uint GetApplicationCount()
		{
			return 0u;
		}

		public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError LaunchApplication(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		public bool CancelApplicationLaunch(string pchAppKey)
		{
			return false;
		}

		public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		public uint GetApplicationProcessId(string pchAppKey)
		{
			return 0u;
		}

		public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
		{
			return null;
		}

		public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError)
		{
			return 0u;
		}

		public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return false;
		}

		public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError)
		{
			return 0uL;
		}

		public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch)
		{
			return default(EVRApplicationError);
		}

		public bool GetApplicationAutoLaunch(string pchAppKey)
		{
			return false;
		}

		public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType)
		{
			return default(EVRApplicationError);
		}

		public bool GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return false;
		}

		public bool GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer)
		{
			return false;
		}

		public uint GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer)
		{
			return 0u;
		}

		public uint GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs)
		{
			return 0u;
		}

		public EVRApplicationError GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen)
		{
			return default(EVRApplicationError);
		}

		public EVRApplicationTransitionState GetTransitionState()
		{
			return default(EVRApplicationTransitionState);
		}

		public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
		{
			return default(EVRApplicationError);
		}

		public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
		{
			return null;
		}

		public bool IsQuitUserPromptRequested()
		{
			return false;
		}

		public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory)
		{
			return default(EVRApplicationError);
		}

		public uint GetCurrentSceneProcessId()
		{
			return 0u;
		}
	}
}
