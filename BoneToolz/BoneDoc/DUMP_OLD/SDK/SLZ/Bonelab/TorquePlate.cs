using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TorquePlate : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private ConfigurableJoint jnt;

		public float launchReturnSeconds;

		private Coroutine _moveCoroutine;

		public AudioClip launchClip;

		public float rotTargetHigh;

		public float rotTargetLow;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		public void Launch()
		{
		}

		public IEnumerator CoLaunch()
		{
			return null;
		}

		public TorquePlate()
			: base()
		{
		}
	}
}
