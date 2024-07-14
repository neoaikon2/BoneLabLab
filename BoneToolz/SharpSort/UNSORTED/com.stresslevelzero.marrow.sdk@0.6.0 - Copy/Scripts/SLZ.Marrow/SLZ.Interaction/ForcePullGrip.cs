using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Interaction
{
	public class ForcePullGrip : MonoBehaviour
	{
		public enum GripState
		{
			IDELING = 0,
			LONGHOVERING = 1,
			PULLING = 2
		}
		private Grip _grip;

		private Hand _pullToHand;

		private bool _isDoneSnatching;

		private bool _isStartAttaching;

		private bool _isEnabled;

		private float maxForce;

		public float maxSpeed;

		private ConfigurableJoint tempJoint;

		private Coroutine pullCoroutine;

		public GripState state { get; private set; }

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		private void OnFarHandHoverUpdate(Hand hand)
		{
		}

		private void OnFarHandHoverEnd(Hand hand)
		{
		}

		private void OnFarHandHoverBegin(Hand hand)
		{
		}

		private void Pull(Hand hand)
		{
		}

		public void OnForcePullComplete(Hand hand)
		{
		}

		public void OnStartAttach(Hand hand)
		{
		}

		public void CancelPull(Hand hand)
		{
		}
		private IEnumerator CoPull(Hand hand)
		{
			return null;
		}
	}
}
