using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.VRMK
{
	public class SLZ_Body : MonoBehaviour
	{
		[Serializable]
		public class Footstep
		{
			public enum StepState
			{
				Grounded = 0,
				Lifted = 1,
				Soaring = 2,
				Stepping = 3
			}

			public Transform target;

			public float stepSpeed;

			public Vector3 position;

			public Quaternion rotation;

			public float footOffset;

			public float heelOffset;

			public float stepProgressThreshold;

			public Vector3 stepFrom;

			public Vector3 stepTo;

			private Quaternion stepFromRot;

			public int gear;

			private Quaternion stepToRot;

			private float _toeLiftOffset;

			private float _toeLiftTo;

			private float _freeOffsetT;

			private float _freeOffsetVel;

			private SimpleTransform _soaringOffset;

			public FootstepSFX stepSfx;

			private HashSet<Rigidbody> _selfRbs;

			private RaycastHit[] _footHits;

			private Footstep _otherStep;

			[Range(0f, 1f)]
			public float supportLegW;

			public StepState stepState;

			public Quaternion grounderRotOffset;

			public Transform hip;

			private bool _wasGrounded;

			private Locomotion _loco;

			private float _wasGroundedTimer;

			public bool isStepping
			{
				get
				{
					return default(bool);
				}
			}

			public float stepProgress { get; private set; }

			public float stepProgressSmooth { get; private set; }

			public Vector3 grounderOffset { get; private set; }

			public bool isGrounded { get; private set; }

			public void Reset(Vector3 footPosition, Quaternion footRotation)
			{
			}

			public void OnAwake(Vector3 charSpaceOffset, Locomotion l, Footstep otherStep, HashSet<Rigidbody> excludeRbs)
			{
			}

			public void StartStep(float velocitySanGravNorm)
			{
			}

			public void UpdateStepping(Vector3 rootPosition, Quaternion rootRotation, Quaternion footRotation, Vector3 rootUp, Vector3 velocitySanGrav, Vector3 accel, float angularVel, float velocitySanGravNorm, float stepLZ, float velDot, float sacrumHeightWeight, float deltaTime)
			{
			}

			public void UpdateStanding(Vector3 rootPosition, Quaternion rootRotation, Quaternion footRotation, Vector3 rootUp, Vector3 velocitySanGrav, float stepLZ, float deltaTime)
			{
			}

			public void PreUpdate(Vector3 rootPosition, Quaternion rootRotation, Quaternion footRotation, Vector3 rootUp, Vector3 velocitySanGrav, Vector3 accel, float angularVel, float velocitySanGravNorm, float velDot, float sacrumHeightWeight, float deltaTime)
			{
			}

			public void UpdateSoaring(Vector3 rootPosition, Quaternion rootRotation, Quaternion footRotation, Vector3 rootUp, Vector3 velocitySanGrav, float angularVelocity, float stepLZ, float deltaTime)
			{
			}

			public ValueTuple<SimpleTransform, float, float> Update(float velocitySanGravNorm, Quaternion rootRotation, float sacrumHeightWeight, float deltaTime)
			{
				return default(ValueTuple<SimpleTransform, float, float>);
			}

			public void AddDeltaRotation(float delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public void UpdateLifted(Vector3 rootPosition, Quaternion rootRotation, Quaternion footRotation, Vector3 rootUp, Vector3 velocitySanGrav, float stepLZ, float deltaTime)
			{
			}

			private void CaptureOffset(Quaternion footRotation)
			{
			}

			public void ProcessGrounder(Vector3 rootUp, float deltaTime)
			{
			}

			public bool RaycastExcludeRbHashset(Vector3 origin, Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance, int layerMask, RaycastHit[] buffer, HashSet<Rigidbody> rbHashSet)
			{
				return default(bool);
			}

			public Footstep()
				: base()
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			public Transform neutralRoot;

			[Range(0f, 1f)]
			public float supportLeg;

			private const float angleThreshold = 40f;

			[HideInInspector]
			public float legLength;

			[HideInInspector]
			public float tippyToeExt;

			[Range(0f, 1f)]
			private float animCycle;

			private float _legLengthMult;

			private float _legLengthInvMult;

			public Gear[] gears;

			[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
			public LayerMask layers;

			public Footstep[] footsteps;

			private float lastAnimCycle;

			private bool wasStepping;

			public void SetAvatar(Avatar avatar)
			{
			}

			public void Initiate(SLZ.Rig.Rig animRig)
			{
			}

			public void Reset(SLZ.Rig.Rig animRig)
			{
			}

			public void AddDeltaRotation(float delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public void Solve(Vector3 velocitySanGrav, float velocitySanGravMag, Vector3 accelerationSanGrav, float angularVelocity, float sacrumHeightWeight, float deltaTime, [Out] SimpleTransform footstepLf, [Out] SimpleTransform footstepRt, [Out] float leftFootOffset, [Out] float rightFootOffset, [Out] float leftHeelOffset, [Out] float rightHeelOffset)
			{
			}

			public void UpdateAnimCycle(float deltaTime)
			{
			}

			private bool CanStep()
			{
				return default(bool);
			}

			private void GearShifter(float speed, int gear)
			{
			}

			public Locomotion()
				: base()
			{
			}
		}

		[Serializable]
		public class Gear
		{
			public float upshiftVel;

			public float downshiftVel;

			[Range(0f, 1f)]
			[Tooltip("Percentage of previous step completion before another can be triggered 0-1f")]
			public float stepProgressThreshold;

			[Range(0f, 1f)]
			[Tooltip("Blend of how much step is behind and in front of neutral point")]
			public float stepfromtoWeight;

			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[FormerlySerializedAs("StepZInterpolationVCurve")]
			public AnimationCurve StepZInterpolation;

			[Range(0f, 1f)]
			public float stepTakeOff;

			[Range(0f, 1f)]
			public float stepLand;

			public AnimationCurve StepProgressThreshVCurve;

			public AnimationCurve StepSpeedVCurve;

			public AnimationCurve StepLandingZoneVCurve;

			public Gear()
				: base()
			{
			}
		}

		private float _hipZDamped;

		private float _hipZVelocity;

		public HeptaRig skeletonRig;

		public Locomotion locomotion;

		public void OnStart()
		{
		}

		public void SetAvatar(Avatar avatar)
		{
		}

		public ValueTuple<SimpleTransform, SimpleTransform, SimpleTransform, SimpleTransform, float, float> SolveLegs(float deltaTime, Vector3 velocitySanGrav, float velocitySanGravMag, Vector3 accelerationSanGrav, float angularVelocity, float sacrumHeightWeight, SimpleTransform pelvisOffset)
		{
			return default(ValueTuple<SimpleTransform, SimpleTransform, SimpleTransform, SimpleTransform, float, float>);
		}

		public SLZ_Body()
			: base()
		{
		}
	}
}
