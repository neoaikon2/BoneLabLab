using System;
using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

namespace SLZ.Graphics2.VRS
{
	public class VRSPluginLogger
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DebugLogDelegate(int level, string message);

		private const string VRS_PLUGIN_NAME = "GfxPluginSLZNvApiVRS";

		[PreserveSig]
		private static extern void BindLogger(IntPtr logMethodPtr);

		[PreserveSig]
		private static extern void DisposeLogger();

		[PreserveSig]
		public static extern void PrintDebugMessage();

		[PreserveSig]
		public static extern void PrintNvApiStatus();

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeLogger()
		{
		}

		[MonoPInvokeCallback(typeof(DebugLogDelegate))]
		private static void DebugLog(int level, string message)
		{
		}
	}
}
