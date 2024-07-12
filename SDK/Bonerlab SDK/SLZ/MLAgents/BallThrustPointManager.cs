using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BallThrustPointManager : MonoBehaviour
	{
		public Rigidbody parentRb;

		public Thruster x;

		public Thruster negx;

		public Thruster y;

		public Thruster negy;

		public Thruster z;

		public Thruster negz;

		public string gameObjectName;

		public CounterTorque gyro;

		public Thruster[] thrusters;

		public CounterTorque[] gyros;

		public bool goToDest;

		public GameObject destination;

		public bool useMinHeight;

		private Vector3 destinationError;

		private float dest_dist;

		private float dest_dist_2d;

		private float cached_dest_dist;

		private int layer_mask;

		public bool useStationaryNoise;

		public float lerpStrength;

		public float noiseRadius;

		public float noiseDestThreshold;

		private bool noiseRunning;

		private Vector3 noiseVector;

		private Vector3 cachedDestination;

		private Vector3 noisePosition;

		private Coroutine noiseRoutine;

		public bool activated;

		public bool speedGovern;

		public float maxVelMag;

		public float governMod;

		private Vector3 maxVel;

		private Vector3 velError;

		public float destThresh;

		[ContextMenu("Deactivate Thrusters")]
		public void DeactivateThrusters()
		{
		}

		[ContextMenu("Activate Thrusters")]
		public void ActivateThrusters()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitFrame()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		[ContextMenu("Start Noise")]
		public void StartNoise()
		{
		}

		[ContextMenu("Stop Noise")]
		public void StopNoise()
		{
		}

		private IEnumerator NoiseRoutine()
		{
			return null;
		}

		private void OnDrawGizmos()
		{
		}

		public BallThrustPointManager()
			: base()
		{
		}
	}
}
