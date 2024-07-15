using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UltEvents;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Dice : MonoBehaviour
	{
		[Serializable]
		public class UnityEventInt : UnityEvent<int>
		{
		}

		private enum DieState
		{
			Untouched = 0,
			Held = 1,
			Rolling = 2,
			Rolled = 3
		}

		[Serializable]
		public class dieSide
		{
			public Transform zDirection;

			public bool twoSided;

			public int fwdInt;

			public int backInt;
		}
		[SerializeField]
		public UnityEventInt activeRoll;

		public UltEvent<int> onActiveRoll;

		public UnityEventInt resultRoll;

		public UltEvent<int> onResultRoll;

		[SerializeField]
		private Rigidbody _rb;

		[SerializeField]
		private InteractableHost _host;

		private Coroutine _rollingCo;

		private WaitForSeconds _wait;

		private int _lastRoll;

		private DieState _dieState;

		public dieSide[] sides;

		public InteractableHost host => null;

		public Rigidbody rb => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Reset()
		{
		}

		public int GetUpInt(Vector3 upDirection)
		{
			return 0;
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}
		private IEnumerator Rolling()
		{
			return null;
		}
	}
}
