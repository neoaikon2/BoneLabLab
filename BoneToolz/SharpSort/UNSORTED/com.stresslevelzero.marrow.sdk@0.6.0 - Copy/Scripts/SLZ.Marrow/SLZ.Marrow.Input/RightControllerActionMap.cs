using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class RightControllerActionMap : ControllerActionMap, InputActions.IControllerRActions
	{
		public override InputDeviceCharacteristics Characteristics => default(InputDeviceCharacteristics);

		protected override void ProcessDeviceInfo(UnityEngine.InputSystem.InputDevice device)
		{
		}
	}
}
