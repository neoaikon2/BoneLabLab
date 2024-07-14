using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_screen_fade")]
public class OVRScreenFade : MonoBehaviour
{
	[Tooltip("Fade duration")]
	public float fadeTime;

	[Tooltip("Screen color at maximum fade")]
	public Color fadeColor;

	public bool fadeOnStart;

	public int renderQueue;

	private float explicitFadeAlpha;

	private float animatedFadeAlpha;

	private float uiFadeAlpha;

	private MeshRenderer fadeRenderer;

	private MeshFilter fadeMesh;

	private Material fadeMaterial;

	private bool isFading;

	public static OVRScreenFade instance { get; private set; }

	public float currentAlpha => 0f;

	private void Start()
	{
	}

	public void FadeIn()
	{
	}

	public void FadeOut()
	{
	}

	private void OnLevelFinishedLoading(int level)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetUIFade(float level)
	{
	}

	public void SetExplicitFade(float level)
	{
	}
	private IEnumerator Fade(float startAlpha, float endAlpha)
	{
		return null;
	}

	private void SetMaterialAlpha()
	{
	}
}
