namespace Microsoft.MixedReality.OpenXR
{
	internal interface IOpenXRContext
	{
		ulong Instance { get; }

		ulong SystemId { get; }

		ulong Session { get; }

		bool IsSessionRunning { get; }

		XrSessionState SessionState { get; }

		ulong SceneOriginSpace { get; }

		event OpenXRContextEvent InstanceCreated;

		event OpenXRContextEvent InstanceDestroying;

		event OpenXRContextEvent SessionCreated;

		event OpenXRContextEvent SessionDestroying;

		event OpenXRContextEvent SessionBegun;

		event OpenXRContextEvent SessionEnding;
	}
}
