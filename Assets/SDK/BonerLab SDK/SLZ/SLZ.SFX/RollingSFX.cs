using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.SFX
{
	public class RollingSFX : MonoBehaviour
	{
		public MarrowBody[] mbWheels;

		public GameObject sourceObj;

		public float maxAngularV;

		public float realtimeUpdateFrequency;

		public float wheelRadius;

		public float minSpeed;

		public float maxSpeed;

		private ManagedAudioPlayer _mapLoop;

		private bool _hasAp;

		public AudioClip spinningNotColliding;

		public AudioClip rollingWithCollision;

		private bool wheelColliding;

		private WaitForSecondsRealtime _wfsRealtime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCollisionEnter()
		{
		}

		private void OnCollisionExit()
		{
		}
		private IEnumerator UpdateSound()
		{
			return null;
		}
	}
}
