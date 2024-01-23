using System;
using SLZ.Interaction;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Rig
{
	public class GameWorldSkeletonRig : HeptaRig
	{
		public static Action OnPreFixedUpdateGlobal;

		public Action OnPreFixedUpdate;

		[Header("VirtualHeptaRig")]
		public VirtualController virtualController;

		public VirtualControllerOverride bodyVCOverride;

		public Transform testGazeTarget;

		[SerializeField]
		private SkeletonHand _leftSkeletonHand;

		[SerializeField]
		private SkeletonHand _rightSkeletonHand;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		[SerializeField]
		private NavMeshAgent _navAgent;

		public AnimationCurve SwingCounterCurve;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnFirstFixedUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public SkeletonHand GetSkeletonHand(Handedness handedness)
		{
			return null;
		}

		private void UpdateHeptaBody2(Rig inRig, float deltaTime, Vector2 velocity, Vector2 accel)
		{
		}
	}
}
