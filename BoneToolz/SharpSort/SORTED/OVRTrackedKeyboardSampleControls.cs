using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OVRTrackedKeyboardSampleControls : MonoBehaviour
{
	public OVRTrackedKeyboard trackedKeyboard;

	public InputField StartingFocusField;

	public Text NameValue;

	public Text ConnectedValue;

	public Text StateValue;

	public Text SelectKeyboardValue;

	public Text TypeValue;

	public Color GoodStateColor;

	public Color BadStateColor;

	public Toggle TrackingToggle;

	public Toggle ConnectionToggle;

	public Toggle RemoteKeyboardToggle;

	public Button[] ShaderButtons;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetPresentationOpaque()
	{
	}

	public void SetPresentationMR()
	{
	}

	public void SetUnlitShader()
	{
	}

	public void SetDiffuseShader()
	{
	}
	private IEnumerator SetShaderCoroutine(string shaderName)
	{
		return null;
	}

	public void LaunchKeyboardSelection()
	{
	}

	public void SetTrackingEnabled(bool value)
	{
	}
}
