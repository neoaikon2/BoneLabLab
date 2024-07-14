using System;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_platform_menu")]
public class OVRPlatformMenu : MonoBehaviour
{
	public enum eHandler
	{
		ShowConfirmQuit = 0,
		RetreatOneLevel = 1
	}

	private enum eBackButtonAction
	{
		NONE = 0,
		SHORT_PRESS = 1
	}

	private OVRInput.RawButton inputCode;

	public eHandler shortPressHandler;

	public Func<bool> OnShortPress;

	private static Stack<string> sceneStack;

	private eBackButtonAction HandleBackButtonState()
	{
		return default(eBackButtonAction);
	}

	private void Awake()
	{
	}

	private void ShowConfirmQuitMenu()
	{
	}

	private static bool RetreatOneLevel()
	{
		return false;
	}

	private void Update()
	{
	}
}
