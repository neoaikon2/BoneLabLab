using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(OVRVirtualKeyboardSampleInputHandler))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_virtual_keyboard_sample_controls")]
public class OVRVirtualKeyboardSampleControls : MonoBehaviour
{
	private struct OVRVirtualKeyboardBackup
	{
		private readonly Vector3 _position;

		private readonly Quaternion _rotation;

		private readonly Vector3 _scale;

		private readonly Transform _rightControllerDirectTransform;

		private readonly Transform _rightControllerRootTransform;

		private readonly Transform _leftControllerDirectTransform;

		private readonly Transform _leftControllerRootTransform;

		private readonly bool _controllerRayInteraction;

		private readonly bool _controllerDirectInteraction;

		private readonly OVRHand _handLeft;

		private readonly OVRHand _handRight;

		private readonly bool _handRayInteraction;

		private readonly bool _handDirectInteraction;

		private readonly OVRPhysicsRaycaster _controllerRaycaster;

		private readonly OVRPhysicsRaycaster _handRaycaster;

		public OVRVirtualKeyboardBackup(OVRVirtualKeyboard keyboard)
		{
			_position = default(Vector3);
			_rotation = default(Quaternion);
			_scale = default(Vector3);
			_rightControllerDirectTransform = null;
			_rightControllerRootTransform = null;
			_leftControllerDirectTransform = null;
			_leftControllerRootTransform = null;
			_controllerRayInteraction = false;
			_controllerDirectInteraction = false;
			_handLeft = null;
			_handRight = null;
			_handRayInteraction = false;
			_handDirectInteraction = false;
			_controllerRaycaster = null;
			_handRaycaster = null;
		}

		public void RestoreTo(OVRVirtualKeyboard keyboard)
		{
		}
	}
	private const float THUMBSTICK_DEADZONE = 0.2f;

	[SerializeField]
	private Button ShowButton;

	[SerializeField]
	private Button MoveButton;

	[SerializeField]
	private Button HideButton;

	[SerializeField]
	private Button MoveNearButton;

	[SerializeField]
	private Button MoveFarButton;

	[SerializeField]
	private Button DestroyKeyboardButton;

	[SerializeField]
	private OVRVirtualKeyboard keyboard;

	private OVRVirtualKeyboardSampleInputHandler inputHandler;

	private bool isMovingKeyboard_;

	private bool isMovingKeyboardFinished_;

	private float keyboardMoveDistance_;

	private float keyboardScale_;

	private OVRVirtualKeyboardBackup keyboardBackup;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void ShowKeyboard()
	{
	}
	private IEnumerator CreateKeyboard()
	{
		return null;
	}

	public void MoveKeyboard()
	{
	}

	public void MoveKeyboardNear()
	{
	}

	public void MoveKeyboardFar()
	{
	}

	public void HideKeyboard()
	{
	}

	public void DestroyKeyboard()
	{
	}

	private void OnHideKeyboard()
	{
	}

	private void UpdateButtonInteractable()
	{
	}

	private void Update()
	{
	}
}
