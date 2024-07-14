using UnityEngine;
using UnityEngine.InputSystem;

namespace SLZ.Marrow.Input
{
	public class HmdActionMap : XRHMD, InputActions.IHMDActions
	{
		private InputDevice _isDevice;

		private Vector3 _position;

		private Quaternion _rotation;

		private double _poseUpdateTime;

		private double _lastPoseUpdateTime;

		public override string DeviceInfo => null;

		public override void OnPostNewInputUpdate()
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnTrackingState(InputAction.CallbackContext context)
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnPosition(InputAction.CallbackContext context)
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnRotation(InputAction.CallbackContext context)
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnVelocity(InputAction.CallbackContext context)
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnAngularVelocity(InputAction.CallbackContext context)
		{
		}

		private void SLZ_002EMarrow_002EInput_002EInputActions_002EIHMDActions_002EOnIsTracked(InputAction.CallbackContext context)
		{
		}

		public override void Refresh()
		{
		}

		public void OnTrackingState(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}

		public void OnPosition(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}

		public void OnRotation(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}

		public void OnVelocity(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}

		public void OnAngularVelocity(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}

		public void OnIsTracked(InputAction.CallbackContext context)
		{
			throw new System.NotImplementedException();
		}
	}
}
