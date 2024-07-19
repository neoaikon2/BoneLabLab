using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	[ExecuteInEditMode]
	public class GenericLauncher : MonoBehaviour
	{
		public Rigidbody[] allRBs;

		public Transform target;

		public float height;

		public Vector3 totalRevs;

		public bool DrawDebugPath;

		public bool DrawDebugMesh;

		public bool applyCorrectiveThrust;

		[SerializeField]
		private GameObject simLaunchObj;

		[SerializeField]
		private int splineResolution;

		public Vector3[] positions;

		public Vector3[] directions;

		public float gizmosSize;

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

		private Vector3[] initPos;

		private Quaternion[] initRot;

		[Header("TestDummy")]
		public GameObject testGO;

		public Mesh previewMesh;

		public Seat seat;

		public void SetInitVals()
		{
		}

		public void ResetToInitVals()
		{
		}

		public void SetupAndLaunchAll(GameObject parentGO, Vector3 targPos, float h)
		{
		}

		[ContextMenu("TestAllSetup")]
		public void TestAll()
		{
		}

		[ContextMenu("LaunchAll")]
		public void LaunchAll()
		{
		}
		private IEnumerator CoMeasureError(float timeToTarg)
		{
			return null;
		}

		private void ApplyCorrectiveThrust()
		{
		}

		[ContextMenu("RandThrust")]
		public void TestRandomFailThrust()
		{
		}

		public TrajectoryData CalcInitialVelocity()
		{
			return null;
		}

		public Vector3 CalculateLaunchTorque(float timeToTarget, Vector3 totalRevs)
		{
			return default(Vector3);
		}

		private void DrawPath()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public TrajectoryData CalcInitialVelocityDebug(Transform targ, GameObject launchObj, float h)
		{
			return null;
		}

		public void GetAllRBs(GameObject go)
		{
		}

		public void OnPlayerEnter()
		{
		}
	}
}
