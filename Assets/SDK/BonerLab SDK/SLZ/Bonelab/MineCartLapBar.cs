using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineCartLapBar : MonoBehaviour
	{
		[Tooltip("Joint for lapbar")]
		[InspectorDisplayName("Configurable Joint")]
		public ConfigurableJoint cj;

		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[Tooltip("Servo script goes here")]
		[InspectorDisplayName("Servo Script")]
		public Servo servo;

		[InspectorDisplayName("Lock Angle")]
		[Tooltip("The amount of rotation in degrees that will lock the joint")]
		public float lockAngle;

		[Tooltip("Event to fire on player seated")]
		[Header("Events")]
		[SerializeField]
		private UnityEvent OnSeat;

		[Tooltip("Event to fire on player unseated")]
		[SerializeField]
		private UnityEvent OnUnseat;

		[SerializeField]
		[Tooltip("Event to fire on bar locked")]
		private UnityEvent OnBarLocked;

		[SerializeField]
		[Tooltip("Event to fire on bar unlocked")]
		private UnityEvent OnBarUnlocked;

		private Quaternion startRotation;

		private Coroutine _checkingBar;

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnSeated()
		{
		}

		private void OnUnSeated()
		{
		}
		private IEnumerator CoCheckBar()
		{
			return null;
		}

		public bool CheckBar()
		{
			return false;
		}

		public void LockBar()
		{
		}

		public void UnlockBar()
		{
		}

		private void OnDisable()
		{
		}
	}
}
