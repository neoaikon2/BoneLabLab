using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class RightControllerActionMap : ControllerActionMap, InputActions.IControllerRActions
	{
		public override InputDeviceCharacteristics Characteristics
		{
			get
			{
				return default(InputDeviceCharacteristics);
			}
		}

		protected override void ProcessDeviceInfo(UnityEngine.InputSystem.InputDevice device)
		{
		}

		public RightControllerActionMap()
			: base()
		{
		}
	}
}
