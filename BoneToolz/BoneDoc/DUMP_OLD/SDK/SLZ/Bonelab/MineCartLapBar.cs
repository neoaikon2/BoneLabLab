using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Vehicle;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineCartLapBar : MonoBehaviour
	{
		[InspectorDisplayName("Configurable Joint")]
		[Tooltip("Joint for lapbar")]
		public ConfigurableJoint cj;

		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[Tooltip("Servo script goes here")]
		[InspectorDisplayName("Servo Script")]
		public Servo servo;

		[Tooltip("The amount of rotation in degrees that will lock the joint")]
		[InspectorDisplayName("Lock Angle")]
		public float lockAngle;

		[SerializeField]
		[Tooltip("Event to fire on player seated")]
		[Header("Events")]
		private UnityEvent OnSeat;

		[SerializeField]
		[Tooltip("Event to fire on player unseated")]
		private UnityEvent OnUnseat;

		[SerializeField]
		[Tooltip("Event to fire on bar locked")]
		private UnityEvent OnBarLocked;

		[Tooltip("Event to fire on bar unlocked")]
		[SerializeField]
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
			return default(bool);
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

		public MineCartLapBar()
			: base()
		{
		}
	}
}
