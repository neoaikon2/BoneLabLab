using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Rigidbody))]
	public class shaker : MonoBehaviour
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float multiplier;

		[SerializeField]
		private Transform temptrans;

		[SerializeField]
		[HideInInspector]
		private Rigidbody bodyRB;

		private void Reset()
		{
		}

		public void TimedShake(float Shaketime)
		{
		}

		public void TimedShake(float Shaketime, float Frequency, Quaternion Direction)
		{
		}

		public void TimedShake(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
		{
		}

		public void ContinuousShake()
		{
		}
		private IEnumerator TimedShakeCo(float Shaketime, float Frequency, Quaternion Direction, Vector3 AxisAlignedIntensity)
		{
			return null;
		}
		private IEnumerator ContinuousShaking()
		{
			return null;
		}
	}
}
