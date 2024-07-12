using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class XRTracker : XRDevice
	{
		public readonly string name;

		private bool _isTracking;

		public override bool IsTracking
		{
			get
			{
				return default(bool);
			}
		}

		public XRTracker(string name)
			: base()
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
