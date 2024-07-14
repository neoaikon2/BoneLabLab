using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_runtime_controller")]
public class OVRRuntimeController : MonoBehaviour
{
	public OVRInput.Controller m_controller;

	public Shader m_controllerModelShader;

	public bool m_supportAnimation;

	private GameObject m_controllerObject;

	private static string leftControllerModelPath;

	private static string rightControllerModelPath;

	private string m_controllerModelPath;

	private bool m_modelSupported;

	private bool m_hasInputFocus;

	private bool m_hasInputFocusPrev;

	private bool m_controllerConnectedPrev;

	private Dictionary<OVRGLTFInputNode, OVRGLTFAnimatinonNode> m_animationNodes;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool IsModelSupported(string modelPath)
	{
		return false;
	}

	private bool LoadControllerModel(string modelPath)
	{
		return false;
	}
	private IEnumerator UpdateControllerModel()
	{
		return null;
	}

	private void UpdateControllerAnimation()
	{
	}

	public void InputFocusAquired()
	{
	}

	public void InputFocusLost()
	{
	}
}
