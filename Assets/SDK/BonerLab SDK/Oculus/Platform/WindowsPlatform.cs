using System;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public class WindowsPlatform
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		private void CPPLogCallback(IntPtr tag, IntPtr message)
		{
		}

		private IntPtr getCallbackPointer()
		{
			return (IntPtr)0;
		}

		public bool Initialize(string appId)
		{
			return false;
		}

		public Request<PlatformInitialize> AsyncInitialize(string appId)
		{
			return null;
		}
	}
}
