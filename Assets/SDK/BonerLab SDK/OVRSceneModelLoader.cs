using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(OVRSceneManager))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_model_loader")]
public class OVRSceneModelLoader : MonoBehaviour
{
	private const float RetryingReminderDelay = 10f;

	private bool _sceneCaptureRequested;

	protected OVRSceneManager SceneManager { get; private set; }

	private void Start()
	{
	}
	private IEnumerator AttemptToLoadSceneModel()
	{
		return null;
	}

	protected virtual void OnStart()
	{
	}

	private void LoadSceneModel()
	{
	}

	protected virtual void OnSceneModelLoadedSuccessfully()
	{
	}

	protected virtual void OnNoSceneModelToLoad()
	{
	}

	protected virtual void OnNewSceneModelAvailable()
	{
	}

	protected virtual void OnSceneCaptureReturnedWithoutError()
	{
	}

	protected virtual void OnUnexpectedErrorWithSceneCapture()
	{
	}
}
