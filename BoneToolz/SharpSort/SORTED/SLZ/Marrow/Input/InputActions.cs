using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace SLZ.Marrow.Input
{
	public class InputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		public struct HMDActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState => null;

			public InputAction Position => null;

			public InputAction Rotation => null;

			public InputAction Velocity => null;

			public InputAction AngularVelocity => null;

			public InputAction IsTracked => null;

			public bool enabled => false;

			public HMDActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(HMDActions set)
			{
				return null;
			}

			public void AddCallbacks(IHMDActions instance)
			{
			}

			private void UnregisterCallbacks(IHMDActions instance)
			{
			}

			public void RemoveCallbacks(IHMDActions instance)
			{
			}

			public void SetCallbacks(IHMDActions instance)
			{
			}
		}

		public struct ControllerLActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState => null;

			public InputAction PalmPose => null;

			public InputAction PointerPose => null;

			public InputAction Velocity => null;

			public InputAction AngularVelocity => null;

			public InputAction Primary2DAxis => null;

			public InputAction Primary2DAxisClick => null;

			public InputAction Primary2DAxisTouch => null;

			public InputAction Touchpad => null;

			public InputAction TouchpadClick => null;

			public InputAction TouchpadTouch => null;

			public InputAction Trigger => null;

			public InputAction TriggerPress => null;

			public InputAction TriggerTouch => null;

			public InputAction Grip => null;

			public InputAction GripPress => null;

			public InputAction GripForce => null;

			public InputAction PrimaryButton => null;

			public InputAction PrimaryTouch => null;

			public InputAction SecondaryButton => null;

			public InputAction SecondaryTouch => null;

			public InputAction MenuButton => null;

			public InputAction Haptic => null;

			public InputAction IsTracked => null;

			public bool enabled => false;

			public ControllerLActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(ControllerLActions set)
			{
				return null;
			}

			public void AddCallbacks(IControllerLActions instance)
			{
			}

			private void UnregisterCallbacks(IControllerLActions instance)
			{
			}

			public void RemoveCallbacks(IControllerLActions instance)
			{
			}

			public void SetCallbacks(IControllerLActions instance)
			{
			}
		}

		public struct ControllerRActions
		{
			private InputActions m_Wrapper;

			public InputAction TrackingState => null;

			public InputAction PalmPose => null;

			public InputAction PointerPose => null;

			public InputAction Velocity => null;

			public InputAction AngularVelocity => null;

			public InputAction Primary2DAxis => null;

			public InputAction Primary2DAxisClick => null;

			public InputAction Primary2DAxisTouch => null;

			public InputAction Touchpad => null;

			public InputAction TouchpadClick => null;

			public InputAction TouchpadTouch => null;

			public InputAction Trigger => null;

			public InputAction TriggerPress => null;

			public InputAction TriggerTouch => null;

			public InputAction Grip => null;

			public InputAction GripPress => null;

			public InputAction GripForce => null;

			public InputAction PrimaryButton => null;

			public InputAction PrimaryTouch => null;

			public InputAction SecondaryButton => null;

			public InputAction SecondaryTouch => null;

			public InputAction Haptic => null;

			public InputAction IsTracked => null;

			public bool enabled => false;

			public ControllerRActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(ControllerRActions set)
			{
				return null;
			}

			public void AddCallbacks(IControllerRActions instance)
			{
			}

			private void UnregisterCallbacks(IControllerRActions instance)
			{
			}

			public void RemoveCallbacks(IControllerRActions instance)
			{
			}

			public void SetCallbacks(IControllerRActions instance)
			{
			}
		}

		public struct GamepadActions
		{
			private InputActions m_Wrapper;

			public InputAction LeftJoystick2DAxis => null;

			public InputAction LeftTrigger1DAxis => null;

			public InputAction LeftJoystickButton => null;

			public InputAction LeftShoulderButton => null;

			public InputAction LeftNorthButton => null;

			public InputAction LeftEastButton => null;

			public InputAction LeftSouthButton => null;

			public InputAction LeftWestButton => null;

			public InputAction SelectButton => null;

			public InputAction RightJoystick2DAxis => null;

			public InputAction RightTrigger1DAxis => null;

			public InputAction RightJoystickButton => null;

			public InputAction RightShoulderButton => null;

			public InputAction RightNorthButton => null;

			public InputAction RightEastButton => null;

			public InputAction RightSouthButton => null;

			public InputAction RightWestButton => null;

			public InputAction StartButton => null;

			public bool enabled => false;

			public GamepadActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(GamepadActions set)
			{
				return null;
			}

			public void AddCallbacks(IGamepadActions instance)
			{
			}

			private void UnregisterCallbacks(IGamepadActions instance)
			{
			}

			public void RemoveCallbacks(IGamepadActions instance)
			{
			}

			public void SetCallbacks(IGamepadActions instance)
			{
			}
		}

		public struct MouseActions
		{
			private InputActions m_Wrapper;

			public InputAction Mouse_ForwardButton => null;

			public InputAction Mouse_BackButton => null;

			public InputAction Mouse_RButton => null;

			public InputAction Mouse_MButton => null;

			public InputAction Mouse_LButton => null;

			public InputAction Mouse_Delta => null;

			public InputAction Mouse_Scroll => null;

			public bool enabled => false;

			public MouseActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(MouseActions set)
			{
				return null;
			}

			public void AddCallbacks(IMouseActions instance)
			{
			}

			private void UnregisterCallbacks(IMouseActions instance)
			{
			}

			public void RemoveCallbacks(IMouseActions instance)
			{
			}

			public void SetCallbacks(IMouseActions instance)
			{
			}
		}

		public struct PositionalKeyboardActions
		{
			private InputActions m_Wrapper;

			public InputAction Positional_Escape => null;

			public InputAction Positional_Space => null;

			public InputAction Positional_Enter => null;

			public InputAction Positional_Tab => null;

			public InputAction Positional_Backquote => null;

			public InputAction Positional_Quote => null;

			public InputAction Positional_Semicolon => null;

			public InputAction Positional_Comma => null;

			public InputAction Positional_Period => null;

			public InputAction Positional_Slash => null;

			public InputAction Positional_Backslash => null;

			public InputAction Positional_LeftBracket => null;

			public InputAction Positional_RightBracket => null;

			public InputAction Positional_Minus => null;

			public InputAction Positional_Equals => null;

			public InputAction Positional_UpArrow => null;

			public InputAction Positional_DownArrow => null;

			public InputAction Positional_LeftArrow => null;

			public InputAction Positional_RightArrow => null;

			public InputAction Positional_A => null;

			public InputAction Positional_B => null;

			public InputAction Positional_C => null;

			public InputAction Positional_D => null;

			public InputAction Positional_E => null;

			public InputAction Positional_F => null;

			public InputAction Positional_G => null;

			public InputAction Positional_H => null;

			public InputAction Positional_I => null;

			public InputAction Positional_J => null;

			public InputAction Positional_K => null;

			public InputAction Positional_L => null;

			public InputAction Positional_M => null;

			public InputAction Positional_N => null;

			public InputAction Positional_O => null;

			public InputAction Positional_P => null;

			public InputAction Positional_Q => null;

			public InputAction Positional_R => null;

			public InputAction Positional_S => null;

			public InputAction Positional_T => null;

			public InputAction Positional_U => null;

			public InputAction Positional_V => null;

			public InputAction Positional_W => null;

			public InputAction Positional_X => null;

			public InputAction Positional_Y => null;

			public InputAction Positional_Z => null;

			public InputAction Positional_1 => null;

			public InputAction Positional_2 => null;

			public InputAction Positional_3 => null;

			public InputAction Positional_4 => null;

			public InputAction Positional_5 => null;

			public InputAction Positional_6 => null;

			public InputAction Positional_7 => null;

			public InputAction Positional_8 => null;

			public InputAction Positional_9 => null;

			public InputAction Positional_0 => null;

			public InputAction Positional_LeftShift => null;

			public InputAction Positional_RightShift => null;

			public InputAction Positional_LeftAlt => null;

			public InputAction Positional_RightAlt => null;

			public InputAction Positional_LeftCtrl => null;

			public InputAction Positional_RightCtrl => null;

			public InputAction Positional_LeftMeta => null;

			public InputAction Positional_RightMeta => null;

			public InputAction Positional_ContextMenu => null;

			public InputAction Positional_Backspace => null;

			public InputAction Positional_PageDown => null;

			public InputAction Positional_PageUp => null;

			public InputAction Positional_Home => null;

			public InputAction Positional_End => null;

			public InputAction Positional_Insert => null;

			public InputAction Positional_Delete => null;

			public InputAction Positional_CapsLock => null;

			public InputAction Positional_NumLock => null;

			public InputAction Positional_PrintScreen => null;

			public InputAction Positional_ScrollLock => null;

			public InputAction Positional_Pause => null;

			public InputAction Positional_NumpadEnter => null;

			public InputAction Positional_NumpadDivide => null;

			public InputAction Positional_NumpadMultiply => null;

			public InputAction Positional_NumpadPlus => null;

			public InputAction Positional_NumpadMinus => null;

			public InputAction Positional_NumpadPeriod => null;

			public InputAction Positional_NumpadEquals => null;

			public InputAction Positional_Numpad1 => null;

			public InputAction Positional_Numpad2 => null;

			public InputAction Positional_Numpad3 => null;

			public InputAction Positional_Numpad4 => null;

			public InputAction Positional_Numpad5 => null;

			public InputAction Positional_Numpad6 => null;

			public InputAction Positional_Numpad7 => null;

			public InputAction Positional_Numpad8 => null;

			public InputAction Positional_Numpad9 => null;

			public InputAction Positional_Numpad0 => null;

			public InputAction Positional_F1 => null;

			public InputAction Positional_F2 => null;

			public InputAction Positional_F3 => null;

			public InputAction Positional_F4 => null;

			public InputAction Positional_F5 => null;

			public InputAction Positional_F6 => null;

			public InputAction Positional_F7 => null;

			public InputAction Positional_F8 => null;

			public InputAction Positional_F9 => null;

			public InputAction Positional_F10 => null;

			public InputAction Positional_F11 => null;

			public InputAction Positional_F12 => null;

			public InputAction Positional_OEM1 => null;

			public InputAction Positional_OEM2 => null;

			public InputAction Positional_OEM3 => null;

			public InputAction Positional_OEM4 => null;

			public InputAction Positional_OEM5 => null;

			public bool enabled => false;

			public PositionalKeyboardActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(PositionalKeyboardActions set)
			{
				return null;
			}

			public void AddCallbacks(IPositionalKeyboardActions instance)
			{
			}

			private void UnregisterCallbacks(IPositionalKeyboardActions instance)
			{
			}

			public void RemoveCallbacks(IPositionalKeyboardActions instance)
			{
			}

			public void SetCallbacks(IPositionalKeyboardActions instance)
			{
			}
		}

		public struct JoystickActions
		{
			private InputActions m_Wrapper;

			public InputAction Stick => null;

			public InputAction Trigger => null;

			public bool enabled => false;

			public JoystickActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(JoystickActions set)
			{
				return null;
			}

			public void AddCallbacks(IJoystickActions instance)
			{
			}

			private void UnregisterCallbacks(IJoystickActions instance)
			{
			}

			public void RemoveCallbacks(IJoystickActions instance)
			{
			}

			public void SetCallbacks(IJoystickActions instance)
			{
			}
		}

		public struct TrackersActions
		{
			private InputActions m_Wrapper;

			public InputAction LeftFoot => null;

			public InputAction LeftFootTrackingState => null;

			public InputAction RightFoot => null;

			public InputAction RightFootTrackingState => null;

			public InputAction LeftShoulder => null;

			public InputAction LeftShoulderTrackingState => null;

			public InputAction RightShoulder => null;

			public InputAction RightShoulderTrackingState => null;

			public InputAction LeftElbow => null;

			public InputAction LeftElbowTrackingState => null;

			public InputAction RightElbow => null;

			public InputAction RightElbowTrackingState => null;

			public InputAction LeftKnee => null;

			public InputAction LeftKneeTrackingState => null;

			public InputAction RightKnee => null;

			public InputAction RightKneeTrackingState => null;

			public InputAction Waist => null;

			public InputAction WaistTrackingState => null;

			public InputAction Chest => null;

			public InputAction ChestTrackingState => null;

			public bool enabled => false;

			public TrackersActions(InputActions wrapper)
			{
				m_Wrapper = null;
			}

			public InputActionMap Get()
			{
				return null;
			}

			public void Enable()
			{
			}

			public void Disable()
			{
			}

			public static implicit operator InputActionMap(TrackersActions set)
			{
				return null;
			}

			public void AddCallbacks(ITrackersActions instance)
			{
			}

			private void UnregisterCallbacks(ITrackersActions instance)
			{
			}

			public void RemoveCallbacks(ITrackersActions instance)
			{
			}

			public void SetCallbacks(ITrackersActions instance)
			{
			}
		}

		public interface IHMDActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPosition(InputAction.CallbackContext context);

			void OnRotation(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);

			void OnIsTracked(InputAction.CallbackContext context);
		}

		public interface IControllerLActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPalmPose(InputAction.CallbackContext context);

			void OnPointerPose(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);

			void OnPrimary2DAxis(InputAction.CallbackContext context);

			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			void OnTouchpad(InputAction.CallbackContext context);

			void OnTouchpadClick(InputAction.CallbackContext context);

			void OnTouchpadTouch(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);

			void OnTriggerPress(InputAction.CallbackContext context);

			void OnTriggerTouch(InputAction.CallbackContext context);

			void OnGrip(InputAction.CallbackContext context);

			void OnGripPress(InputAction.CallbackContext context);

			void OnGripForce(InputAction.CallbackContext context);

			void OnPrimaryButton(InputAction.CallbackContext context);

			void OnPrimaryTouch(InputAction.CallbackContext context);

			void OnSecondaryButton(InputAction.CallbackContext context);

			void OnSecondaryTouch(InputAction.CallbackContext context);

			void OnMenuButton(InputAction.CallbackContext context);

			void OnHaptic(InputAction.CallbackContext context);

			void OnIsTracked(InputAction.CallbackContext context);
		}

		public interface IControllerRActions
		{
			void OnTrackingState(InputAction.CallbackContext context);

			void OnPalmPose(InputAction.CallbackContext context);

			void OnPointerPose(InputAction.CallbackContext context);

			void OnVelocity(InputAction.CallbackContext context);

			void OnAngularVelocity(InputAction.CallbackContext context);

			void OnPrimary2DAxis(InputAction.CallbackContext context);

			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			void OnTouchpad(InputAction.CallbackContext context);

			void OnTouchpadClick(InputAction.CallbackContext context);

			void OnTouchpadTouch(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);

			void OnTriggerPress(InputAction.CallbackContext context);

			void OnTriggerTouch(InputAction.CallbackContext context);

			void OnGrip(InputAction.CallbackContext context);

			void OnGripPress(InputAction.CallbackContext context);

			void OnGripForce(InputAction.CallbackContext context);

			void OnPrimaryButton(InputAction.CallbackContext context);

			void OnPrimaryTouch(InputAction.CallbackContext context);

			void OnSecondaryButton(InputAction.CallbackContext context);

			void OnSecondaryTouch(InputAction.CallbackContext context);

			void OnHaptic(InputAction.CallbackContext context);

			void OnIsTracked(InputAction.CallbackContext context);
		}

		public interface IGamepadActions
		{
			void OnLeftJoystick2DAxis(InputAction.CallbackContext context);

			void OnLeftTrigger1DAxis(InputAction.CallbackContext context);

			void OnLeftJoystickButton(InputAction.CallbackContext context);

			void OnLeftShoulderButton(InputAction.CallbackContext context);

			void OnLeftNorthButton(InputAction.CallbackContext context);

			void OnLeftEastButton(InputAction.CallbackContext context);

			void OnLeftSouthButton(InputAction.CallbackContext context);

			void OnLeftWestButton(InputAction.CallbackContext context);

			void OnSelectButton(InputAction.CallbackContext context);

			void OnRightJoystick2DAxis(InputAction.CallbackContext context);

			void OnRightTrigger1DAxis(InputAction.CallbackContext context);

			void OnRightJoystickButton(InputAction.CallbackContext context);

			void OnRightShoulderButton(InputAction.CallbackContext context);

			void OnRightNorthButton(InputAction.CallbackContext context);

			void OnRightEastButton(InputAction.CallbackContext context);

			void OnRightSouthButton(InputAction.CallbackContext context);

			void OnRightWestButton(InputAction.CallbackContext context);

			void OnStartButton(InputAction.CallbackContext context);
		}

		public interface IMouseActions
		{
			void OnMouse_ForwardButton(InputAction.CallbackContext context);

			void OnMouse_BackButton(InputAction.CallbackContext context);

			void OnMouse_RButton(InputAction.CallbackContext context);

			void OnMouse_MButton(InputAction.CallbackContext context);

			void OnMouse_LButton(InputAction.CallbackContext context);

			void OnMouse_Delta(InputAction.CallbackContext context);

			void OnMouse_Scroll(InputAction.CallbackContext context);
		}

		public interface IPositionalKeyboardActions
		{
			void OnPositional_Escape(InputAction.CallbackContext context);

			void OnPositional_Space(InputAction.CallbackContext context);

			void OnPositional_Enter(InputAction.CallbackContext context);

			void OnPositional_Tab(InputAction.CallbackContext context);

			void OnPositional_Backquote(InputAction.CallbackContext context);

			void OnPositional_Quote(InputAction.CallbackContext context);

			void OnPositional_Semicolon(InputAction.CallbackContext context);

			void OnPositional_Comma(InputAction.CallbackContext context);

			void OnPositional_Period(InputAction.CallbackContext context);

			void OnPositional_Slash(InputAction.CallbackContext context);

			void OnPositional_Backslash(InputAction.CallbackContext context);

			void OnPositional_LeftBracket(InputAction.CallbackContext context);

			void OnPositional_RightBracket(InputAction.CallbackContext context);

			void OnPositional_Minus(InputAction.CallbackContext context);

			void OnPositional_Equals(InputAction.CallbackContext context);

			void OnPositional_UpArrow(InputAction.CallbackContext context);

			void OnPositional_DownArrow(InputAction.CallbackContext context);

			void OnPositional_LeftArrow(InputAction.CallbackContext context);

			void OnPositional_RightArrow(InputAction.CallbackContext context);

			void OnPositional_A(InputAction.CallbackContext context);

			void OnPositional_B(InputAction.CallbackContext context);

			void OnPositional_C(InputAction.CallbackContext context);

			void OnPositional_D(InputAction.CallbackContext context);

			void OnPositional_E(InputAction.CallbackContext context);

			void OnPositional_F(InputAction.CallbackContext context);

			void OnPositional_G(InputAction.CallbackContext context);

			void OnPositional_H(InputAction.CallbackContext context);

			void OnPositional_I(InputAction.CallbackContext context);

			void OnPositional_J(InputAction.CallbackContext context);

			void OnPositional_K(InputAction.CallbackContext context);

			void OnPositional_L(InputAction.CallbackContext context);

			void OnPositional_M(InputAction.CallbackContext context);

			void OnPositional_N(InputAction.CallbackContext context);

			void OnPositional_O(InputAction.CallbackContext context);

			void OnPositional_P(InputAction.CallbackContext context);

			void OnPositional_Q(InputAction.CallbackContext context);

			void OnPositional_R(InputAction.CallbackContext context);

			void OnPositional_S(InputAction.CallbackContext context);

			void OnPositional_T(InputAction.CallbackContext context);

			void OnPositional_U(InputAction.CallbackContext context);

			void OnPositional_V(InputAction.CallbackContext context);

			void OnPositional_W(InputAction.CallbackContext context);

			void OnPositional_X(InputAction.CallbackContext context);

			void OnPositional_Y(InputAction.CallbackContext context);

			void OnPositional_Z(InputAction.CallbackContext context);

			void OnPositional_1(InputAction.CallbackContext context);

			void OnPositional_2(InputAction.CallbackContext context);

			void OnPositional_3(InputAction.CallbackContext context);

			void OnPositional_4(InputAction.CallbackContext context);

			void OnPositional_5(InputAction.CallbackContext context);

			void OnPositional_6(InputAction.CallbackContext context);

			void OnPositional_7(InputAction.CallbackContext context);

			void OnPositional_8(InputAction.CallbackContext context);

			void OnPositional_9(InputAction.CallbackContext context);

			void OnPositional_0(InputAction.CallbackContext context);

			void OnPositional_LeftShift(InputAction.CallbackContext context);

			void OnPositional_RightShift(InputAction.CallbackContext context);

			void OnPositional_LeftAlt(InputAction.CallbackContext context);

			void OnPositional_RightAlt(InputAction.CallbackContext context);

			void OnPositional_LeftCtrl(InputAction.CallbackContext context);

			void OnPositional_RightCtrl(InputAction.CallbackContext context);

			void OnPositional_LeftMeta(InputAction.CallbackContext context);

			void OnPositional_RightMeta(InputAction.CallbackContext context);

			void OnPositional_ContextMenu(InputAction.CallbackContext context);

			void OnPositional_Backspace(InputAction.CallbackContext context);

			void OnPositional_PageDown(InputAction.CallbackContext context);

			void OnPositional_PageUp(InputAction.CallbackContext context);

			void OnPositional_Home(InputAction.CallbackContext context);

			void OnPositional_End(InputAction.CallbackContext context);

			void OnPositional_Insert(InputAction.CallbackContext context);

			void OnPositional_Delete(InputAction.CallbackContext context);

			void OnPositional_CapsLock(InputAction.CallbackContext context);

			void OnPositional_NumLock(InputAction.CallbackContext context);

			void OnPositional_PrintScreen(InputAction.CallbackContext context);

			void OnPositional_ScrollLock(InputAction.CallbackContext context);

			void OnPositional_Pause(InputAction.CallbackContext context);

			void OnPositional_NumpadEnter(InputAction.CallbackContext context);

			void OnPositional_NumpadDivide(InputAction.CallbackContext context);

			void OnPositional_NumpadMultiply(InputAction.CallbackContext context);

			void OnPositional_NumpadPlus(InputAction.CallbackContext context);

			void OnPositional_NumpadMinus(InputAction.CallbackContext context);

			void OnPositional_NumpadPeriod(InputAction.CallbackContext context);

			void OnPositional_NumpadEquals(InputAction.CallbackContext context);

			void OnPositional_Numpad1(InputAction.CallbackContext context);

			void OnPositional_Numpad2(InputAction.CallbackContext context);

			void OnPositional_Numpad3(InputAction.CallbackContext context);

			void OnPositional_Numpad4(InputAction.CallbackContext context);

			void OnPositional_Numpad5(InputAction.CallbackContext context);

			void OnPositional_Numpad6(InputAction.CallbackContext context);

			void OnPositional_Numpad7(InputAction.CallbackContext context);

			void OnPositional_Numpad8(InputAction.CallbackContext context);

			void OnPositional_Numpad9(InputAction.CallbackContext context);

			void OnPositional_Numpad0(InputAction.CallbackContext context);

			void OnPositional_F1(InputAction.CallbackContext context);

			void OnPositional_F2(InputAction.CallbackContext context);

			void OnPositional_F3(InputAction.CallbackContext context);

			void OnPositional_F4(InputAction.CallbackContext context);

			void OnPositional_F5(InputAction.CallbackContext context);

			void OnPositional_F6(InputAction.CallbackContext context);

			void OnPositional_F7(InputAction.CallbackContext context);

			void OnPositional_F8(InputAction.CallbackContext context);

			void OnPositional_F9(InputAction.CallbackContext context);

			void OnPositional_F10(InputAction.CallbackContext context);

			void OnPositional_F11(InputAction.CallbackContext context);

			void OnPositional_F12(InputAction.CallbackContext context);

			void OnPositional_OEM1(InputAction.CallbackContext context);

			void OnPositional_OEM2(InputAction.CallbackContext context);

			void OnPositional_OEM3(InputAction.CallbackContext context);

			void OnPositional_OEM4(InputAction.CallbackContext context);

			void OnPositional_OEM5(InputAction.CallbackContext context);
		}

		public interface IJoystickActions
		{
			void OnStick(InputAction.CallbackContext context);

			void OnTrigger(InputAction.CallbackContext context);
		}

		public interface ITrackersActions
		{
			void OnLeftFoot(InputAction.CallbackContext context);

			void OnLeftFootTrackingState(InputAction.CallbackContext context);

			void OnRightFoot(InputAction.CallbackContext context);

			void OnRightFootTrackingState(InputAction.CallbackContext context);

			void OnLeftShoulder(InputAction.CallbackContext context);

			void OnLeftShoulderTrackingState(InputAction.CallbackContext context);

			void OnRightShoulder(InputAction.CallbackContext context);

			void OnRightShoulderTrackingState(InputAction.CallbackContext context);

			void OnLeftElbow(InputAction.CallbackContext context);

			void OnLeftElbowTrackingState(InputAction.CallbackContext context);

			void OnRightElbow(InputAction.CallbackContext context);

			void OnRightElbowTrackingState(InputAction.CallbackContext context);

			void OnLeftKnee(InputAction.CallbackContext context);

			void OnLeftKneeTrackingState(InputAction.CallbackContext context);

			void OnRightKnee(InputAction.CallbackContext context);

			void OnRightKneeTrackingState(InputAction.CallbackContext context);

			void OnWaist(InputAction.CallbackContext context);

			void OnWaistTrackingState(InputAction.CallbackContext context);

			void OnChest(InputAction.CallbackContext context);

			void OnChestTrackingState(InputAction.CallbackContext context);
		}

		private readonly InputActionMap m_HMD;

		private List<IHMDActions> m_HMDActionsCallbackInterfaces;

		private readonly InputAction m_HMD_TrackingState;

		private readonly InputAction m_HMD_Position;

		private readonly InputAction m_HMD_Rotation;

		private readonly InputAction m_HMD_Velocity;

		private readonly InputAction m_HMD_AngularVelocity;

		private readonly InputAction m_HMD_IsTracked;

		private readonly InputActionMap m_ControllerL;

		private List<IControllerLActions> m_ControllerLActionsCallbackInterfaces;

		private readonly InputAction m_ControllerL_TrackingState;

		private readonly InputAction m_ControllerL_PalmPose;

		private readonly InputAction m_ControllerL_PointerPose;

		private readonly InputAction m_ControllerL_Velocity;

		private readonly InputAction m_ControllerL_AngularVelocity;

		private readonly InputAction m_ControllerL_Primary2DAxis;

		private readonly InputAction m_ControllerL_Primary2DAxisClick;

		private readonly InputAction m_ControllerL_Primary2DAxisTouch;

		private readonly InputAction m_ControllerL_Touchpad;

		private readonly InputAction m_ControllerL_TouchpadClick;

		private readonly InputAction m_ControllerL_TouchpadTouch;

		private readonly InputAction m_ControllerL_Trigger;

		private readonly InputAction m_ControllerL_TriggerPress;

		private readonly InputAction m_ControllerL_TriggerTouch;

		private readonly InputAction m_ControllerL_Grip;

		private readonly InputAction m_ControllerL_GripPress;

		private readonly InputAction m_ControllerL_GripForce;

		private readonly InputAction m_ControllerL_PrimaryButton;

		private readonly InputAction m_ControllerL_PrimaryTouch;

		private readonly InputAction m_ControllerL_SecondaryButton;

		private readonly InputAction m_ControllerL_SecondaryTouch;

		private readonly InputAction m_ControllerL_MenuButton;

		private readonly InputAction m_ControllerL_Haptic;

		private readonly InputAction m_ControllerL_IsTracked;

		private readonly InputActionMap m_ControllerR;

		private List<IControllerRActions> m_ControllerRActionsCallbackInterfaces;

		private readonly InputAction m_ControllerR_TrackingState;

		private readonly InputAction m_ControllerR_PalmPose;

		private readonly InputAction m_ControllerR_PointerPose;

		private readonly InputAction m_ControllerR_Velocity;

		private readonly InputAction m_ControllerR_AngularVelocity;

		private readonly InputAction m_ControllerR_Primary2DAxis;

		private readonly InputAction m_ControllerR_Primary2DAxisClick;

		private readonly InputAction m_ControllerR_Primary2DAxisTouch;

		private readonly InputAction m_ControllerR_Touchpad;

		private readonly InputAction m_ControllerR_TouchpadClick;

		private readonly InputAction m_ControllerR_TouchpadTouch;

		private readonly InputAction m_ControllerR_Trigger;

		private readonly InputAction m_ControllerR_TriggerPress;

		private readonly InputAction m_ControllerR_TriggerTouch;

		private readonly InputAction m_ControllerR_Grip;

		private readonly InputAction m_ControllerR_GripPress;

		private readonly InputAction m_ControllerR_GripForce;

		private readonly InputAction m_ControllerR_PrimaryButton;

		private readonly InputAction m_ControllerR_PrimaryTouch;

		private readonly InputAction m_ControllerR_SecondaryButton;

		private readonly InputAction m_ControllerR_SecondaryTouch;

		private readonly InputAction m_ControllerR_Haptic;

		private readonly InputAction m_ControllerR_IsTracked;

		private readonly InputActionMap m_Gamepad;

		private List<IGamepadActions> m_GamepadActionsCallbackInterfaces;

		private readonly InputAction m_Gamepad_LeftJoystick2DAxis;

		private readonly InputAction m_Gamepad_LeftTrigger1DAxis;

		private readonly InputAction m_Gamepad_LeftJoystickButton;

		private readonly InputAction m_Gamepad_LeftShoulderButton;

		private readonly InputAction m_Gamepad_LeftNorthButton;

		private readonly InputAction m_Gamepad_LeftEastButton;

		private readonly InputAction m_Gamepad_LeftSouthButton;

		private readonly InputAction m_Gamepad_LeftWestButton;

		private readonly InputAction m_Gamepad_SelectButton;

		private readonly InputAction m_Gamepad_RightJoystick2DAxis;

		private readonly InputAction m_Gamepad_RightTrigger1DAxis;

		private readonly InputAction m_Gamepad_RightJoystickButton;

		private readonly InputAction m_Gamepad_RightShoulderButton;

		private readonly InputAction m_Gamepad_RightNorthButton;

		private readonly InputAction m_Gamepad_RightEastButton;

		private readonly InputAction m_Gamepad_RightSouthButton;

		private readonly InputAction m_Gamepad_RightWestButton;

		private readonly InputAction m_Gamepad_StartButton;

		private readonly InputActionMap m_Mouse;

		private List<IMouseActions> m_MouseActionsCallbackInterfaces;

		private readonly InputAction m_Mouse_Mouse_ForwardButton;

		private readonly InputAction m_Mouse_Mouse_BackButton;

		private readonly InputAction m_Mouse_Mouse_RButton;

		private readonly InputAction m_Mouse_Mouse_MButton;

		private readonly InputAction m_Mouse_Mouse_LButton;

		private readonly InputAction m_Mouse_Mouse_Delta;

		private readonly InputAction m_Mouse_Mouse_Scroll;

		private readonly InputActionMap m_PositionalKeyboard;

		private List<IPositionalKeyboardActions> m_PositionalKeyboardActionsCallbackInterfaces;

		private readonly InputAction m_PositionalKeyboard_Positional_Escape;

		private readonly InputAction m_PositionalKeyboard_Positional_Space;

		private readonly InputAction m_PositionalKeyboard_Positional_Enter;

		private readonly InputAction m_PositionalKeyboard_Positional_Tab;

		private readonly InputAction m_PositionalKeyboard_Positional_Backquote;

		private readonly InputAction m_PositionalKeyboard_Positional_Quote;

		private readonly InputAction m_PositionalKeyboard_Positional_Semicolon;

		private readonly InputAction m_PositionalKeyboard_Positional_Comma;

		private readonly InputAction m_PositionalKeyboard_Positional_Period;

		private readonly InputAction m_PositionalKeyboard_Positional_Slash;

		private readonly InputAction m_PositionalKeyboard_Positional_Backslash;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftBracket;

		private readonly InputAction m_PositionalKeyboard_Positional_RightBracket;

		private readonly InputAction m_PositionalKeyboard_Positional_Minus;

		private readonly InputAction m_PositionalKeyboard_Positional_Equals;

		private readonly InputAction m_PositionalKeyboard_Positional_UpArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_DownArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_RightArrow;

		private readonly InputAction m_PositionalKeyboard_Positional_A;

		private readonly InputAction m_PositionalKeyboard_Positional_B;

		private readonly InputAction m_PositionalKeyboard_Positional_C;

		private readonly InputAction m_PositionalKeyboard_Positional_D;

		private readonly InputAction m_PositionalKeyboard_Positional_E;

		private readonly InputAction m_PositionalKeyboard_Positional_F;

		private readonly InputAction m_PositionalKeyboard_Positional_G;

		private readonly InputAction m_PositionalKeyboard_Positional_H;

		private readonly InputAction m_PositionalKeyboard_Positional_I;

		private readonly InputAction m_PositionalKeyboard_Positional_J;

		private readonly InputAction m_PositionalKeyboard_Positional_K;

		private readonly InputAction m_PositionalKeyboard_Positional_L;

		private readonly InputAction m_PositionalKeyboard_Positional_M;

		private readonly InputAction m_PositionalKeyboard_Positional_N;

		private readonly InputAction m_PositionalKeyboard_Positional_O;

		private readonly InputAction m_PositionalKeyboard_Positional_P;

		private readonly InputAction m_PositionalKeyboard_Positional_Q;

		private readonly InputAction m_PositionalKeyboard_Positional_R;

		private readonly InputAction m_PositionalKeyboard_Positional_S;

		private readonly InputAction m_PositionalKeyboard_Positional_T;

		private readonly InputAction m_PositionalKeyboard_Positional_U;

		private readonly InputAction m_PositionalKeyboard_Positional_V;

		private readonly InputAction m_PositionalKeyboard_Positional_W;

		private readonly InputAction m_PositionalKeyboard_Positional_X;

		private readonly InputAction m_PositionalKeyboard_Positional_Y;

		private readonly InputAction m_PositionalKeyboard_Positional_Z;

		private readonly InputAction m_PositionalKeyboard_Positional_1;

		private readonly InputAction m_PositionalKeyboard_Positional_2;

		private readonly InputAction m_PositionalKeyboard_Positional_3;

		private readonly InputAction m_PositionalKeyboard_Positional_4;

		private readonly InputAction m_PositionalKeyboard_Positional_5;

		private readonly InputAction m_PositionalKeyboard_Positional_6;

		private readonly InputAction m_PositionalKeyboard_Positional_7;

		private readonly InputAction m_PositionalKeyboard_Positional_8;

		private readonly InputAction m_PositionalKeyboard_Positional_9;

		private readonly InputAction m_PositionalKeyboard_Positional_0;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftShift;

		private readonly InputAction m_PositionalKeyboard_Positional_RightShift;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftAlt;

		private readonly InputAction m_PositionalKeyboard_Positional_RightAlt;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftCtrl;

		private readonly InputAction m_PositionalKeyboard_Positional_RightCtrl;

		private readonly InputAction m_PositionalKeyboard_Positional_LeftMeta;

		private readonly InputAction m_PositionalKeyboard_Positional_RightMeta;

		private readonly InputAction m_PositionalKeyboard_Positional_ContextMenu;

		private readonly InputAction m_PositionalKeyboard_Positional_Backspace;

		private readonly InputAction m_PositionalKeyboard_Positional_PageDown;

		private readonly InputAction m_PositionalKeyboard_Positional_PageUp;

		private readonly InputAction m_PositionalKeyboard_Positional_Home;

		private readonly InputAction m_PositionalKeyboard_Positional_End;

		private readonly InputAction m_PositionalKeyboard_Positional_Insert;

		private readonly InputAction m_PositionalKeyboard_Positional_Delete;

		private readonly InputAction m_PositionalKeyboard_Positional_CapsLock;

		private readonly InputAction m_PositionalKeyboard_Positional_NumLock;

		private readonly InputAction m_PositionalKeyboard_Positional_PrintScreen;

		private readonly InputAction m_PositionalKeyboard_Positional_ScrollLock;

		private readonly InputAction m_PositionalKeyboard_Positional_Pause;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEnter;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadDivide;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMultiply;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPlus;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMinus;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPeriod;

		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEquals;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad1;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad2;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad3;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad4;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad5;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad6;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad7;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad8;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad9;

		private readonly InputAction m_PositionalKeyboard_Positional_Numpad0;

		private readonly InputAction m_PositionalKeyboard_Positional_F1;

		private readonly InputAction m_PositionalKeyboard_Positional_F2;

		private readonly InputAction m_PositionalKeyboard_Positional_F3;

		private readonly InputAction m_PositionalKeyboard_Positional_F4;

		private readonly InputAction m_PositionalKeyboard_Positional_F5;

		private readonly InputAction m_PositionalKeyboard_Positional_F6;

		private readonly InputAction m_PositionalKeyboard_Positional_F7;

		private readonly InputAction m_PositionalKeyboard_Positional_F8;

		private readonly InputAction m_PositionalKeyboard_Positional_F9;

		private readonly InputAction m_PositionalKeyboard_Positional_F10;

		private readonly InputAction m_PositionalKeyboard_Positional_F11;

		private readonly InputAction m_PositionalKeyboard_Positional_F12;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM1;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM2;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM3;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM4;

		private readonly InputAction m_PositionalKeyboard_Positional_OEM5;

		private readonly InputActionMap m_Joystick;

		private List<IJoystickActions> m_JoystickActionsCallbackInterfaces;

		private readonly InputAction m_Joystick_Stick;

		private readonly InputAction m_Joystick_Trigger;

		private readonly InputActionMap m_Trackers;

		private List<ITrackersActions> m_TrackersActionsCallbackInterfaces;

		private readonly InputAction m_Trackers_LeftFoot;

		private readonly InputAction m_Trackers_LeftFootTrackingState;

		private readonly InputAction m_Trackers_RightFoot;

		private readonly InputAction m_Trackers_RightFootTrackingState;

		private readonly InputAction m_Trackers_LeftShoulder;

		private readonly InputAction m_Trackers_LeftShoulderTrackingState;

		private readonly InputAction m_Trackers_RightShoulder;

		private readonly InputAction m_Trackers_RightShoulderTrackingState;

		private readonly InputAction m_Trackers_LeftElbow;

		private readonly InputAction m_Trackers_LeftElbowTrackingState;

		private readonly InputAction m_Trackers_RightElbow;

		private readonly InputAction m_Trackers_RightElbowTrackingState;

		private readonly InputAction m_Trackers_LeftKnee;

		private readonly InputAction m_Trackers_LeftKneeTrackingState;

		private readonly InputAction m_Trackers_RightKnee;

		private readonly InputAction m_Trackers_RightKneeTrackingState;

		private readonly InputAction m_Trackers_Waist;

		private readonly InputAction m_Trackers_WaistTrackingState;

		private readonly InputAction m_Trackers_Chest;

		private readonly InputAction m_Trackers_ChestTrackingState;

		private int m_XRUsageSchemeIndex;

		private int m_GamepadSchemeIndex;

		private int m_PositionalKeyboardMouseSchemeIndex;

		public InputActionAsset asset { get; }

		public InputBinding? bindingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputDevice>? devices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ReadOnlyArray<InputControlScheme> controlSchemes => default(ReadOnlyArray<InputControlScheme>);

		public IEnumerable<InputBinding> bindings => null;

		public HMDActions HMD => default(HMDActions);

		public ControllerLActions ControllerL => default(ControllerLActions);

		public ControllerRActions ControllerR => default(ControllerRActions);

		public GamepadActions Gamepad => default(GamepadActions);

		public MouseActions Mouse => default(MouseActions);

		public PositionalKeyboardActions PositionalKeyboard => default(PositionalKeyboardActions);

		public JoystickActions Joystick => default(JoystickActions);

		public TrackersActions Trackers => default(TrackersActions);

		public InputControlScheme XRUsageScheme => default(InputControlScheme);

		public InputControlScheme GamepadScheme => default(InputControlScheme);

		public InputControlScheme PositionalKeyboardMouseScheme => default(InputControlScheme);

		public void Dispose()
		{
		}

		public bool Contains(InputAction action)
		{
			return false;
		}

		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			action = null;
			return 0;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
