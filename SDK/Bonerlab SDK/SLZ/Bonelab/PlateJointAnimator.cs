using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlateJointAnimator : MonoBehaviour
	{
		public ConfigurableJoint runnerJoint;

		public ConfigurableJoint pivotJoint;

		public ConfigurableJoint plate1Joint;

		public ConfigurableJoint plate2Joint;

		public float runnerTime;

		public float runnerTriggerTime;

		public Vector3 runnerTarget;

		public AnimationCurve runnerCurve;

		public float pivotTime;

		public float pivotTriggerTime;

		public Vector3 pivotTarget;

		public AnimationCurve pivotCurve;

		public float plateTime;

		public float plate1Start;

		public float plate2Start;

		public float plateTarget;

		public AnimationCurve plate1Curve;

		public AnimationCurve plate2Curve;

		private IEnumerator mainSequence;

		private IEnumerator pivotSequence;

		private IEnumerator runnerSequence;

		[ContextMenu("STARTSEQUENCE")]
		public void STARTSEQUENCE()
		{
		}

		private IEnumerator MainSequence()
		{
			return null;
		}

		private IEnumerator PivotSequence()
		{
			return null;
		}

		private IEnumerator RunnerSequence()
		{
			return null;
		}

		public PlateJointAnimator()
			: base()
		{
		}
	}
}
