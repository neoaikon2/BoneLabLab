using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.SceneStreaming;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ChunkDebugger : MonoBehaviour
	{
		private class Box
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 extends;
		}

		private class TriggerBox : Box
		{
			public ChunkTrigger chunkTrigger;
		}

		private class TrackerBox : Box
		{
			public ChunkTracker chunkTracker;

			public Collider collider;
		}
		public Grip triggerGrip;

		private List<TriggerBox> _triggerBox;

		private List<TrackerBox> _trackerBox;

		private Vector3 _boundsCenter;

		private float _scale;

		private void Awake()
		{
		}
		private IEnumerator Start()
		{
			return null;
		}

		private void OnTrackerAdd(ChunkTracker tracker)
		{
		}

		private void OnTrackerRemove(ChunkTracker tracker)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
