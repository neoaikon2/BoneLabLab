using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GarageDoorControl : MonoBehaviour
	{
		public enum Direction
		{
			Down = -1,
			Stationary = 0,
			Up = 1
		}

		[CompilerGenerated]
		private sealed class _003CCoDoorMoveUp_003Ed__38
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GarageDoorControl _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003Cendtime_003E5__3;

			private Vector3 _003CstartPos_003E5__4;

			private Vector3 _003CendPos_003E5__5;

			private Vector3 _003CstartScale_003E5__6;

			private Vector3 _003CendScale_003E5__7;

			private int _003CprevRounded_003E5__8;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoDoorMoveUp_003Ed__38(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoDoorMoveDown_003Ed__39
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GarageDoorControl _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003Cendtime_003E5__3;

			private Vector3 _003CstartPos_003E5__4;

			private Vector3 _003CendPos_003E5__5;

			private Vector3 _003CstartScale_003E5__6;

			private Vector3 _003CendScale_003E5__7;

			private int _003CprevRounded_003E5__8;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoDoorMoveDown_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public bool Powered;

		[Range(2f, 1000f)]
		[Tooltip("How long it takes to get from [0,1]. Should never be 0 and 2 is the safe minimum threshold")]
		public float DoorDuration;

		private bool m_currentlyMoving;

		private Direction m_dir;

		private Direction m_lastDir;

		public Transform SlatParent;

		public Transform[] SlatArr;

		private Vector3[] m_SlatArrPos;

		public Transform ColliderTrans;

		private Coroutine m_CoDoorUp;

		private Coroutine m_CoDoorDown;

		public float m_upPerc;

		public float m_downPerc;

		private int m_slatUpPrev;

		private int m_slatDownPrev;

		private bool m_doorAllUp;

		private bool m_doorAllDown;

		private float m_slatUpBegIndx;

		private float m_slatDownBegIndx;

		private float m_slatUpCurrIndx;

		private float m_slatDownCurrIndx;

		private float debug_upTimeStart;

		private float debug_downTimeStart;

		private float debug_downTimeEnd;

		public Vector3 currPos;

		public Vector3 startPos;

		public float currDistTraveled;

		public float startTime;

		public float debug_upTimeEnd;

		public float timeTraveled;

		public float currSpeed;

		[HideInInspector]
		public float UpTime;

		[HideInInspector]
		public float DownTime;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void ObjUnderStopGarage(bool isUnder)
		{
		}

		public void UseGarageDoor(Direction activateDir)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDoorMoveUp_003Ed__38))]
		private IEnumerator CoDoorMoveUp()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoDoorMoveDown_003Ed__39))]
		private IEnumerator CoDoorMoveDown()
		{
			return null;
		}

		private float M_Remap(float value, float from1, float to1, float from2, float to2)
		{
			return 0f;
		}

		private void M_TurnOffSlat(int index, int prevRounded)
		{
		}

		private void M_TurnOnSlat(int index, int prevRounded)
		{
		}
	}
}
