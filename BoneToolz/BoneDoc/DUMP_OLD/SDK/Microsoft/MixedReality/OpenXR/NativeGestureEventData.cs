using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 176)]
	internal struct NativeGestureEventData
	{
		public GestureEventType eventType;

		public GestureHandedness handedness;

		public NativeGesturePoseData poseData;

		public TappedEventData tappedData;

		public ManipulationEventData manipulationData;

		public NavigationEventData navigationData;
	}
}
