namespace UnityEngine.EventSystems
{
	[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_pointer_event_data")]
	public class OVRPointerEventData : PointerEventData
	{
		public Ray worldSpaceRay;

		public Vector2 swipeStart;

		public OVRPointerEventData(EventSystem eventSystem)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
