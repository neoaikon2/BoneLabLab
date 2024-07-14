using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TimeBender : MonoBehaviour
	{
		[SerializeField]
		[Header("SLOW-MOTION-FOR-ME")]
		private bool limitedSlowMo;

		[SerializeField]
		private bool isSlowTime;

		[SerializeField]
		private bool showVisuals;

		[SerializeField]
		private GameObject visObj;

		private Coroutine limitedSlowMoRoutine;

		private Coroutine regenSlowMoRoutine;

		[SerializeField]
		private float maxSlowMoJuice;

		[SerializeField]
		private float slowMoJuice;

		[SerializeField]
		private GameObject[] timeBips;

		[SerializeField]
		private GameObject slowMoSlider;

		[SerializeField]
		private AudioClip slowMoCoolClip;

		[SerializeField]
		private AudioClip slowMoJuicedClip;

		private float currStep;

		private float sliderScaleMax;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleSlowLimits(bool isLimited)
		{
		}

		public void SlowTimeToggle(float step)
		{
		}
		private IEnumerator CoLimitSlowMo(float step = 1f)
		{
			return null;
		}
		private IEnumerator CoRegenSlowMo(float delay = 0f)
		{
			return null;
		}
	}
}
