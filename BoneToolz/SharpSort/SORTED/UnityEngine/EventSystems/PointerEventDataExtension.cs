namespace UnityEngine.EventSystems
{
	public static class PointerEventDataExtension
	{
		public static bool IsVRPointer(this PointerEventData pointerEventData)
		{
			return false;
		}

		public static Ray GetRay(this PointerEventData pointerEventData)
		{
			return default(Ray);
		}

		public static Vector2 GetSwipeStart(this PointerEventData pointerEventData)
		{
			return default(Vector2);
		}

		public static void SetSwipeStart(this PointerEventData pointerEventData, Vector2 start)
		{
		}
	}
}
