using UnityEngine;
using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class ControllerActionMap : XRController
	{
		private InputDevice _isDevice;

		private InputAction _hapticInputAction;

		private float _simIndexTouch;

		private Vector3 _position;

		private Vector3 _pointerPosition;

		protected Vector3 _offsetPosition;

		private Quaternion _rotation;

		private Quaternion _pointerRotation;

		protected Quaternion _offsetRotation;

		private double _poseUpdateTime;

		private double _lastPoseUpdateTime;

		public override string DeviceInfo => null;

		protected virtual void ProcessDeviceInfo(InputDevice device)
		{
		}

		public override void OnPreNewInputUpdate()
		{
		}

		public override void OnPostNewInputUpdate()
		{
		}

		public void SetHapticInputAction(InputAction hapticAction)
		{
		}

		public override void SetHaptic(float secondsFromNow, float duration, float frequency, float amplitude)
		{
		}

		public void OnPalmPose(InputAction.CallbackContext context)
		{
		}

		public void OnPointerPose(InputAction.CallbackContext context)
		{
		}

		public void OnTrackingState(InputAction.CallbackContext context)
		{
		}

		public void OnVelocity(InputAction.CallbackContext context)
		{
		}

		public void OnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxis(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxisClick(InputAction.CallbackContext context)
		{
		}

		public void OnPrimary2DAxisTouch(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpad(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpadClick(InputAction.CallbackContext context)
		{
		}

		public void OnTouchpadTouch(InputAction.CallbackContext context)
		{
		}

		public void OnTrigger(InputAction.CallbackContext context)
		{
		}

		public void OnTriggerPress(InputAction.CallbackContext context)
		{
		}

		public void OnTriggerTouch(InputAction.CallbackContext context)
		{
		}

		public void OnGrip(InputAction.CallbackContext context)
		{
		}

		public void OnGripPress(InputAction.CallbackContext context)
		{
		}

		public void OnGripForce(InputAction.CallbackContext context)
		{
		}

		public void OnPrimaryButton(InputAction.CallbackContext context)
		{
		}

		public void OnPrimaryTouch(InputAction.CallbackContext context)
		{
		}

		public void OnSecondaryButton(InputAction.CallbackContext context)
		{
		}

		public void OnSecondaryTouch(InputAction.CallbackContext context)
		{
		}

		public void OnMenuButton(InputAction.CallbackContext context)
		{
		}

		public void OnHaptic(InputAction.CallbackContext context)
		{
		}

		public void OnIsTracked(InputAction.CallbackContext context)
		{
		}

		public override void Refresh()
		{
		}
	}
}
