using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class ArmFinale : MonoBehaviour
	{
		private enum ArmStage
		{
			Preshow = 0,
			Decent = 1,
			Hold = 2,
			Ascent = 3,
			Dropped = 4,
			Void = 5
		}
		public Rigidbody windmillBlades;

		public ConfigurableJoint windmillJoint;

		public PlayableDirector decent;

		public PlayableDirector ascent;

		public InteractableHostManager hostManager;

		public GameObject holeStopper;

		public SkinnedMeshRenderer armMesh;

		public Seat palmSeat;

		private RigManager _lastRmToDetatch;

		private int _attachedHandCount;

		[SerializeField]
		private List<MarrowBody> _ceilingTiles;

		private ConfigurableJoint[] _tileJoints;

		[SerializeField]
		private ConfigurableJointInfo _jointInfo;

		private ArmStage _armStage;

		private float _timer;

		public void GongHit()
		{
		}

		public void ReadyForAscent()
		{
		}

		public void ReadyForVoid()
		{
		}

		public void WindmillProjectRotation(float secondsFromNow)
		{
		}
		private IEnumerator CoTargetWindMill(float duration, float deltaAngVel)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		private void BuildJoints()
		{
		}

		public void JointDestroyEvent(int tile)
		{
		}
	}
}
