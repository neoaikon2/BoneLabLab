using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PageElementView : MonoBehaviour, IPopUpElementable
	{
		[Header("Options")]
		[ColorUsage(true, true)]
		public Color highlightColor1;

		[ColorUsage(true, true)]
		public Color highlightColor2;

		[ColorUsage(true, true)]
		public Color color1;

		[ColorUsage(true, true)]
		public Color color2;

		public AnimationCurve blipCurve;

		private float blipTime;

		private float blipProgress;

		private Vector3 cashedScale;

		[Header("References")]
		public HighlightUI[] elements;

		private bool m_IsShown;

		[HideInInspector]
		public bool isShown => false;

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void Show(float duration)
		{
		}

		public void Hide()
		{
		}

		public void Hide(float duration)
		{
		}
		public IEnumerator Blip(float time)
		{
			return null;
		}

		public void SetTransform(Vector3 position, Quaternion rotation)
		{
		}
	}
}
