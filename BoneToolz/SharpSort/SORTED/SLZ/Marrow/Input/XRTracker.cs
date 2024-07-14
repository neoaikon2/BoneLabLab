using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class XRTracker : XRDevice
	{
		public readonly string name;

		private bool _isTracking;

		public override bool IsTracking => false;

		public XRTracker(string name)
		{
		}

		public void ReadPoseContext(InputAction.CallbackContext context)
		{
		}

		public void ReadTrackingStateContext(InputAction.CallbackContext context)
		{
		}
	}
}
