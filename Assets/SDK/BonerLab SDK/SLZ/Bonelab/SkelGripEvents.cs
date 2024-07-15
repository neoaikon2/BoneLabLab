using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SkelGripEvents : MonoBehaviour
	{
		[SerializeField]
		private List<ConfigurableJointInfo> _wallJointInfos;

		[SerializeField]
		private List<MarrowBody> _wallBodyAs;

		[SerializeField]
		private List<MarrowBody> _wallBodyBs;

		[SerializeField]
		private EntityPoseData data;

		[SerializeField]
		private MarrowBody[] _allBodies;

		[SerializeField]
		private ConfigurableJoint[] wallJoints;

		public UnityEvent onWallBreakEvent;

		public float jointStrength;

		private Coroutine jointRoutine;

		[SerializeField]
		private bool isLowBreak;

		[SerializeField]
		private Transform audioTransform;

		[SerializeField]
		private AudioClip audioClip;

		[SerializeField]
		private Zone3dSound windSound;

		private AudioPlayer _ap;

		private float sourceRadius;

		[SerializeField]
		private RagDollSkeleton _skele;

		[SerializeField]
		private bool _isPoseMode;

		private bool _hasBroken;

		private MarrowJoint _keystoneJoint1;

		private MarrowJoint _keystoneJoint2;

		private MarrowJoint _keystoneJoint3;

		private MarrowJoint _keystoneJoint4;

		private GameObject _chest;

		private GameObject _upperRightArm;

		private GameObject _lowerRightArm;

		private GameObject _rightHand;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSkeleJointsBuilt()
		{
		}

		private void OnAnySkeleBoneBreak(GameObject go)
		{
		}

		private void OnAnySkeleJointBreak(MarrowJoint joint, int index)
		{
		}

		private void OnAnyRockJointBreak(MarrowJoint mj)
		{
		}

		public void KeystoneBroke()
		{
		}

		private void BreakRocks()
		{
		}
		private IEnumerator CoAdjustJoints()
		{
			return null;
		}

		private void BuildJoints()
		{
		}
	}
}
