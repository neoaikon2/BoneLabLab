using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 176)]
	public struct GestureEventData
	{
		private readonly NativeGestureEventData nativeData;

		public GestureEventType EventType
		{
			get
			{
				return default(GestureEventType);
			}
		}

		public GestureHandedness Handedness
		{
			get
			{
				return default(GestureHandedness);
			}
		}

		public TappedEventData? TappedData
		{
			get
			{
				return null;
			}
		}

		public ManipulationEventData? ManipulationData
		{
			get
			{
				return null;
			}
		}

		public NavigationEventData? NavigationData
		{
			get
			{
				return null;
			}
		}
	}
}
