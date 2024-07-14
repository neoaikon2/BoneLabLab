using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TweenRotation : MonoBehaviour
	{
		[SerializeField]
		private AnimationCurve curve;

		public void LookAtRotationTween(Transform LookAtTransform)
		{
		}
		private IEnumerator EasetoEase(Vector3 targetpos)
		{
			return null;
		}
	}
}
