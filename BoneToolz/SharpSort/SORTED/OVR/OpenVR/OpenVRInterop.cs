using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public class OpenVRInterop
	{
		[PreserveSig]
		internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);

		[PreserveSig]
		internal static extern uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, [In] string pStartupInfo);

		[PreserveSig]
		internal static extern void ShutdownInternal();

		[PreserveSig]
		internal static extern bool IsHmdPresent();

		[PreserveSig]
		internal static extern bool IsRuntimeInstalled();

		[PreserveSig]
		internal static extern IntPtr GetStringForHmdError(EVRInitError error);

		[PreserveSig]
		internal static extern IntPtr GetGenericInterface([In] string pchInterfaceVersion, ref EVRInitError peError);

		[PreserveSig]
		internal static extern bool IsInterfaceVersionValid([In] string pchInterfaceVersion);

		[PreserveSig]
		internal static extern uint GetInitToken();
	}
}
