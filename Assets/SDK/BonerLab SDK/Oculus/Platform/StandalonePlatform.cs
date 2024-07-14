using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Oculus.Platform.Models;

namespace Oculus.Platform
{
	public sealed class StandalonePlatform
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void UnityLogDelegate(IntPtr tag, IntPtr msg);

		public Request<PlatformInitialize> InitializeInEditor()
		{
			return null;
		}

		public Request<PlatformInitialize> AsyncInitialize(ulong appID, string accessToken)
		{
			return null;
		}

		public Request<PlatformInitialize> AsyncInitializeWithAccessTokenAndOptions(string appId, string accessToken, Dictionary<InitConfigOptions, bool> initConfigOptions)
		{
			return null;
		}
	}
}
