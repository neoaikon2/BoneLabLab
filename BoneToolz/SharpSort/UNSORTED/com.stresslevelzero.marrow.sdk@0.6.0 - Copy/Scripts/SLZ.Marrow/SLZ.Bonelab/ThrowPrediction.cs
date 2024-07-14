using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class ThrowPrediction : MonoBehaviour
	{
		public RigManager rigManager;

		[SerializeField]
		private Rigidbody rb;

		[SerializeField]
		private Grip grip;

		[SerializeField]
		private Transform reboundTarget;

		[SerializeField]
		[Header("Trajectory")]
		private TrajectoryData trajData;

		[SerializeField]
		private float height;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private GameObject simObject;

		[SerializeField]
		[Header("Error")]
		private bool applyCorrectiveThrust;

		[SerializeField]
		private float thrustFactor;

		[SerializeField]
		private GameObject targetSphere;

		[SerializeField]
		private float error;

		[SerializeField]
		private float thrustThreshold;

		[SerializeField]
		private float failThreshold;

		private float xError;

		private float yError;

		private float zError;

		private Coroutine errorRoutine;

		[SerializeField]
		[Header("Prediction")]
		private float predictionTime;

		[SerializeField]
		private bool isDrawingPrediction;

		[SerializeField]
		private int splineResolution;

		[SerializeField]
		private float gizmoScale;

		[SerializeField]
		private Vector3 releaseVelocity;

		public Vector3[] positions;

		public Vector3[] predictedPositions;

		public Vector3[] predictedDirections;

		public Vector3[] oldPositions;

		public Vector3[] oldDirections;

		[SerializeField]
		private LineRenderer predictLineRend;

		[SerializeField]
		private LineRenderer idealLineRend;

		private int lerpValInt;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		private void OnDrop(Hand hand)
		{
		}

		[ContextMenu("TestDrop")]
		public void TestDrop()
		{
		}
		private IEnumerator CoMeasureError(float timeToTarg)
		{
			return null;
		}

		private void Rebound_TeleportToPlayer()
		{
		}

		private void ApplyCorrectiveThrust()
		{
		}

		public TrajectoryData CalcInitialVelocity()
		{
			return null;
		}

		private void DrawPredictedPath()
		{
		}

		private void DrawIdealPath()
		{
		}
	}
}
