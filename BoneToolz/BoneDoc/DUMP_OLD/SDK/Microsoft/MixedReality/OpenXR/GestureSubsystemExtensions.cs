namespace Microsoft.MixedReality.OpenXR
{
	internal static class GestureSubsystemExtensions
	{
		public static bool IsValid(this NativeSpaceLocationFlags flags)
		{
			return default(bool);
		}

		public static bool IsTracked(this NativeSpaceLocationFlags flags)
		{
			return default(bool);
		}

		public static bool IsTappedEvent(this NativeGestureEventData eventData)
		{
			return default(bool);
		}

		public static bool IsManipulationEvent(this NativeGestureEventData eventData)
		{
			return default(bool);
		}

		public static bool IsNavigationEvent(this NativeGestureEventData eventData)
		{
			return default(bool);
		}

		public static T? Get<T>(this NativeGestureEventData eventData, T value, bool hasValue) where T : struct
		{
			return null;
		}
	}
}
