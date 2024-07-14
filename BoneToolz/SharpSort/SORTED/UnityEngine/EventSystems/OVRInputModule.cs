using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems
{
	[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_input_module")]
	public class OVRInputModule : PointerInputModule
	{
		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public enum InputMode
		{
			Mouse = 0,
			Buttons = 1
		}

		[Tooltip("Object which points with Z axis. E.g. CentreEyeAnchor from OVRCameraRig")]
		public Transform rayTransform;

		public OVRCursor m_Cursor;

		[Tooltip("Gamepad button to act as gaze click")]
		public OVRInput.Button joyPadClickButton;

		[Tooltip("Keyboard button to act as gaze click")]
		public KeyCode gazeClickKey;

		[Header("Physics")]
		[Tooltip("Perform an sphere cast to determine correct depth for gaze pointer")]
		public bool performSphereCastForGazepointer;

		[Header("Gamepad Stick Scroll")]
		[Tooltip("Enable scrolling with the right stick on a gamepad")]
		public bool useRightStickScroll;

		[Tooltip("Deadzone for right stick to prevent accidental scrolling")]
		public float rightStickDeadZone;

		[Tooltip("Enable scrolling by swiping the touchpad")]
		[Header("Touchpad Swipe Scroll")]
		public bool useSwipeScroll;

		[Tooltip("Minimum trackpad movement in pixels to start swiping")]
		public float swipeDragThreshold;

		[Tooltip("Distance scrolled when swipe scroll occurs")]
		public float swipeDragScale;

		[Tooltip("Invert X axis on touchpad")]
		public bool InvertSwipeXAxis;

		[NonSerialized]
		public OVRRaycaster activeGraphicRaycaster;

		[Header("Dragging")]
		[Tooltip("Minimum pointer movement in degrees to start dragging")]
		public float angleDragThreshold;

		[SerializeField]
		private float m_SpherecastRadius;

		private float m_NextAction;

		private Vector2 m_LastMousePosition;

		private Vector2 m_MousePosition;

		[SerializeField]
		[Header("Standalone Input Module")]
		private string m_HorizontalAxis;

		[SerializeField]
		private string m_VerticalAxis;

		[SerializeField]
		private string m_SubmitButton;

		[SerializeField]
		private string m_CancelButton;

		[SerializeField]
		private float m_InputActionsPerSecond;

		[SerializeField]
		private bool m_AllowActivationOnMobileDevice;

		protected Dictionary<int, OVRPointerEventData> m_VRRayPointerData;

		private readonly MouseState m_MouseState;

		[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
		public InputMode inputMode => default(InputMode);

		public bool allowActivationOnMobileDevice
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float inputActionsPerSecond
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string horizontalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string verticalAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string submitButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string cancelButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected OVRInputModule()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		public override void DeactivateModule()
		{
		}

		private bool SendSubmitEventToSelectedObject()
		{
			return false;
		}

		private bool AllowMoveEventProcessing(float time)
		{
			return false;
		}

		private Vector2 GetRawMoveVector()
		{
			return default(Vector2);
		}

		private bool SendMoveEventToSelectedObject()
		{
			return false;
		}

		private bool SendUpdateEventToSelectedObject()
		{
			return false;
		}

		private void ProcessMousePress(MouseButtonEventData data)
		{
		}

		private void ProcessMouseEvent(MouseState mouseData)
		{
		}

		public override void Process()
		{
		}

		private static bool UseMouse(bool pressed, bool released, PointerEventData pointerData)
		{
			return false;
		}

		protected void CopyFromTo(OVRPointerEventData from, OVRPointerEventData to)
		{
		}

		protected new void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		protected bool GetPointerData(int id, out OVRPointerEventData data, bool create)
		{
			data = null;
			return false;
		}

		protected new void ClearSelection()
		{
		}

		private static Vector3 GetRectTransformNormal(RectTransform rectTransform)
		{
			return default(Vector3);
		}

		protected virtual MouseState GetGazePointerData()
		{
			return null;
		}

		protected MouseState GetCanvasPointerData()
		{
			return null;
		}

		private bool ShouldStartDrag(PointerEventData pointerEvent)
		{
			return false;
		}

		private static bool IsPointerMoving(PointerEventData pointerEvent)
		{
			return false;
		}

		protected Vector2 SwipeAdjustedPosition(Vector2 originalPosition, PointerEventData pointerEvent)
		{
			return default(Vector2);
		}

		protected override void ProcessDrag(PointerEventData pointerEvent)
		{
		}

		protected virtual PointerEventData.FramePressState GetGazeButtonState()
		{
			return default(PointerEventData.FramePressState);
		}

		protected Vector2 GetExtraScrollDelta()
		{
			return default(Vector2);
		}
	}
}
