using UnityEngine;

public static class OVRKeyboard
{
	public struct TrackedKeyboardState
	{
		public bool isPositionValid;

		public bool isPositionTracked;

		public bool isOrientationValid;

		public bool isOrientationTracked;

		public Vector3 position;

		public Quaternion rotation;

		public double timeInSeconds;
	}

	public struct TrackedKeyboardInfo
	{
		public string Name;

		public ulong Identifier;

		public Vector3 Dimensions;

		public OVRPlugin.TrackedKeyboardFlags KeyboardFlags;

		public OVRPlugin.TrackedKeyboardPresentationStyles SupportedPresentationStyles;
	}

	public static TrackedKeyboardState GetKeyboardState()
	{
		return default(TrackedKeyboardState);
	}

	public static bool GetSystemKeyboardInfo(OVRPlugin.TrackedKeyboardQueryFlags keyboardQueryFlags, out TrackedKeyboardInfo keyboardInfo)
	{
		keyboardInfo = default(TrackedKeyboardInfo);
		return false;
	}

	public static bool StopKeyboardTracking(TrackedKeyboardInfo keyboardInfo)
	{
		return false;
	}
}
