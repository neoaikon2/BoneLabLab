using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	public class LeftControllerActionMap : ControllerActionMap, InputActions.IControllerLActions
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

		public LeftControllerActionMap()
			: base()
		{
		}
	}
}
