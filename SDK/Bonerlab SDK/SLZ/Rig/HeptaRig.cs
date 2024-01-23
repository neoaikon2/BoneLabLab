using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class HeptaRig : Rig
	{
		[Header("HeptaRig")]
		public Transform wristLf;

		public Transform wristRt;

		[Header("Spine")]
		public float spineCrouchOffset;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurve;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _t1UpOffsetCurveMantle;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurve;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveVelocity;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveClimb;

		[SerializeField]
		private AnimationCurve _sacrumUpOffsetCurveMantle;

		[SerializeField]
		private AnimationCurve _neckTiltCurve;

		[SerializeField]
		private AnimationCurve _thoracicTwistCurve;

		protected Vector3 _playerUp;

		protected Vector3 _dragUp;

		protected Vector3 _skullPosWorld;

		private float _t1ToVelLerp;

		private float _t1ToVelVel;

		private float _sacrumToVelLerp;

		private float _sacrumToVelVel;

		private float _t1UpOffsetLerp;

		private float _t1UpOffsetVel;

		private float _sacrumUpOffsetLerp;

		private float _sacrumUpOffsetVel;

		private Vector2 _lastT1FwdV2;

		private Vector2 _lastSacrumFwdV2;

		private float _suppressChestVelocityTwist;

		private bool _suppressionDirty;

		private bool _suppressionFreshlyFilthy;

		[SerializeField]
		private AnimationCurve _elbowLimitCurve;

		[SerializeField]
		private AnimationCurve _wristElbowIsNotCurve;

		private Quaternion _neutHumLf;

		private Quaternion _neutHumRt;

		private float _leftHandTwist;

		private float _rightHandTwist;

		public float leftHandDevia;

		public float rightHandDevia;

		private float _wristRelaxLerpLf;

		private float _wristRelaxLerpRt;

		private const float sDisplaceDegreesToXzMult = 0.00485f;

		private const float sDisplaceDegreesToYMult = 0.62f;

		private const float accelLeanWeight = 0.33f;

		private const float dragWeight = 2f;

		private const float pACdProduct = 2f;

		private Vector3 _velLerp;

		private Vector3 _velSanGravNormal;

		private float _velSanGravMag;

		private float _accelSanGravMag;

		public float suppressChestVelocityTwist
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void OnStart()
		{
		}

		public override void OnRigEnable(bool reEnable)
		{
		}

		protected SimpleTransform LimitSpineRotation(SimpleTransform from, SimpleTransform to, Vector4 rangeOfMotion, out float limitedTilt, out float limitedTwist, out float tiltRom, out float tiltDir, out Vector2 xzFromUp)
		{
			limitedTilt = default(float);
			limitedTwist = default(float);
			tiltRom = default(float);
			tiltDir = default(float);
			xzFromUp = default(Vector2);
			return default(SimpleTransform);
		}

		protected Vector3 LimitSpinePosition(Vector3 trackedOffsetLocal, float length, float limitedTilt, float limitedTwist, float tiltRom, float twistRom, Vector2 xzFromUp)
		{
			return default(Vector3);
		}

		protected SimpleTransform VerifyThorLumbarSpinePositional(SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SLZ.VRMK.Avatar avatar, out SimpleTransform spine)
		{
			spine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform AimSpineTowardPelvis(SimpleTransform inHead, SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SimpleTransform pelvisTarget, SLZ.VRMK.Avatar avatar, out SimpleTransform outChest, out SimpleTransform outSpine)
		{
			outChest = default(SimpleTransform);
			outSpine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected Vector3 ExtrapolateCervical(Quaternion skullRot, Quaternion chestRot, SLZ.VRMK.Avatar avatar)
		{
			return default(Vector3);
		}

		protected SimpleTransform ExtrapolateThorLumbar(SimpleTransform inChest, Quaternion inSpineRot, Quaternion inPelvisRot, SLZ.VRMK.Avatar avatar, out SimpleTransform outSpine)
		{
			outSpine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest(SLZ.VRMK.Avatar avatar, Rig inRig, float deltaTime, bool slerp = false, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			return default(SimpleTransform);
		}

		protected float SolveT1UpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs, ref float lastOffset, ref float offsetVel, bool slerp = false)
		{
			return 0f;
		}

		protected float SolveSacrumUpOffset(float heightWeight, float mantle, float footSupported, float handSupported, float velocityInLegs)
		{
			return 0f;
		}

		protected Quaternion SolveT1ToHands(Rig inRig, SLZ.VRMK.Avatar avatar, SimpleTransform t1World)
		{
			return default(Quaternion);
		}

		protected SimpleTransform SolvePelvis(SLZ.VRMK.Avatar avatar, SimpleTransform chest, float deltaTime, out SimpleTransform spine, SimpleTransform pelvisLocalAnimOff, bool slerp = false, float mantle = 0f, float footSupported = 1f, float handSupported = 0f, float physKneeOffset = 0f)
		{
			spine = default(SimpleTransform);
			return default(SimpleTransform);
		}

		protected void SolveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected (float, float, Vector3) SolveArmReach(Vector3 handLocal, Vector3 neutralDir, float armLength, float clavicalLength, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft, float structuralArm = 1f)
		{
			return default((float, float, Vector3));
		}

		protected void LimitHands(SLZ.VRMK.Avatar avatar, bool twoHanded = false)
		{
		}

		private bool HandLimiter(float currentMag, float defaultMag, float minPerc, out float newLimbMag)
		{
			newLimbMag = default(float);
			return false;
		}

		protected SimpleTransform SolveFeetCenter(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, bool dragOffset = true)
		{
			return default(SimpleTransform);
		}

		protected void SolveArms(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		private void WristRelax(Vector3 leftHandVector3, Vector3 rightHandVector3, Quaternion neutralHumerusLf, Quaternion neutralHumerusRt)
		{
		}

		private float ElbowIsNot(Vector3 armVectorNormed, Vector3 neutralGh, Quaternion neutralGlenhumeral, ref float twistFloat)
		{
			return 0f;
		}

		private float ElbowIsNotRt(Vector3 armVectorNormed, Vector3 neutralGh, Quaternion neutralGlenhumeral, ref float twistFloat)
		{
			return 0f;
		}

		public void CalibratePlayerBodyScale(SLZ.VRMK.Avatar avatar)
		{
		}

		protected Vector3 BodyVelocity(Vector2 vel, Vector2 accel, float deltaTime)
		{
			return default(Vector3);
		}

		protected void ExtractProportions(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, ref BodyPose bodyPose)
		{
		}

		protected void ApplyProportions(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ExtractHandProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, ref BodyPose bodyPose)
		{
		}

		protected void ApplyHandProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg)
		{
		}

		protected void ExtractTorsoProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, ref BodyPose bodyPose)
		{
		}

		protected void ApplyTorsoProximity(Quaternion rootRotation, ref SimpleTransform palmLf, ref SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg)
		{
		}

		protected float GetSixAxisBoundsMag(Vector3 localNormedDirection, Vector3 boundsPositive, Vector3 boundsNegative)
		{
			return 0f;
		}

		protected bool PointInTorso(SimpleTransform pointWorld, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, Vector3 pelFromChestNorm, float pelFromChestMag, SLZ.VRMK.Avatar player, SimpleTransform c1, SimpleTransform sternum, SimpleTransform spine, SimpleTransform pelvis, out float t, out float yPercRemapped, out Vector2 sin, out Quaternion spineRotInWorld, out Vector3 spineInPointNormed)
		{
			t = default(float);
			yPercRemapped = default(float);
			sin = default(Vector2);
			spineRotInWorld = default(Quaternion);
			spineInPointNormed = default(Vector3);
			return false;
		}

		protected void HandTorsoSpacewarp(ref SimpleTransform palm, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform chest, SimpleTransform spine, SimpleTransform pelvis, Quaternion spineRot, float yPercRemapped, Vector2 sin, float t, Vector3 spineInPointNormed)
		{
		}
	}
}
