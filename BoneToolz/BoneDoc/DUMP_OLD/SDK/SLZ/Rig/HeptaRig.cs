using System;
using System.Runtime.InteropServices;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class HeptaRig : Rig
	{
		[SerializeField]
		[Header("HeptaRig")]
		protected AnimationCurve _t1UpOffsetCurve;

		[SerializeField]
		protected AnimationCurve _sacrumUpOffsetCurve;

		[SerializeField]
		protected AnimationCurve _neckTiltCurve;

		protected Vector3 _playerUp;

		[SerializeField]
		private AnimationCurve _elbowLimitCurve;

		private Quaternion _neutHumLf;

		private Quaternion _neutHumRt;

		private Quaternion _neutFemurLf;

		private Quaternion _neutFemurRt;

		private float _leftHandTwist;

		private float _rightHandTwist;

		private Quaternion _lastHandWorldLf;

		private Quaternion _lastHandWorldRt;

		private float _deviaHandLf;

		private float _deviaHandRt;

		private float _wristRelaxLerpLf;

		private float _wristRelaxVelLf;

		private float _wristRelaxLerpRt;

		private float _wristRelaxVelRt;

		private const float sDisplaceDegreesToXzMult = 0.00485f;

		private const float sDisplaceDegreesToYMult = 0.62f;

		protected const float accelLeanWeight = 0.33f;

		protected const float dragWeight = 2f;

		protected const float pACdProduct = 2f;

		protected Vector3 _velLerp;

		protected Vector3 _velLerpAccel;

		protected Vector3 _velSanGravNormal;

		protected float _velSanGravMag;

		protected float _accelSanGravMag;

		protected float _leanRetainer;

		protected float _leanVelocity;

		protected float _copToVelLerp;

		protected float _copToVelVel;

		protected float _angularVelocity;

		protected Vector3 _lastAngularFwd;

		public float leftHandDevia
		{
			get
			{
				return default(float);
			}
		}

		public float rightHandDevia
		{
			get
			{
				return default(float);
			}
		}

		protected SimpleTransform LimitSpineRotation(SimpleTransform from, SimpleTransform to, Vector4 rangeOfMotion, [Out] float limitedTilt, [Out] float limitedTwist, [Out] float tiltRom, [Out] float tiltDir, [Out] Vector2 xzFromUp)
		{
			return default(SimpleTransform);
		}

		protected Vector3 LimitSpinePosition(Vector3 trackedOffsetLocal, float length, float limitedTilt, float limitedTwist, float tiltRom, float twistRom, Vector2 xzFromUp)
		{
			return default(Vector3);
		}

		protected SimpleTransform VerifyCervicalSpinePositional(SimpleTransform inHead, SimpleTransform inNeck, SimpleTransform inChest, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform neck)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform VerifyThorLumbarSpinePositional(SimpleTransform inChest, SimpleTransform inSpine, SimpleTransform inPelvis, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform spine)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform AimSpineTowardPelvis(SimpleTransform inHead, SimpleTransform inChest, Quaternion inSpine, SimpleTransform inPelvis, SimpleTransform pelvisTarget, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform outChest, [Out] SimpleTransform outSpine, [Out] SimpleTransform outNeck)
		{
			return default(SimpleTransform);
		}

		protected Vector3 ExtrapolateCervical(Quaternion skullRot, Quaternion chestRot, SLZ.VRMK.Avatar avatar, [Out] Quaternion neckRot)
		{
			return default(Vector3);
		}

		protected SimpleTransform ExtrapolateThorLumbar(SimpleTransform inChest, Quaternion inSpineRot, Quaternion inPelvisRot, SLZ.VRMK.Avatar avatar, [Out] SimpleTransform outSpine)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest(SLZ.VRMK.Avatar avatar, SimpleTransform head, Rig inRig, float deltaTime, [Out] SimpleTransform outNeck)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform SolveChest2(SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform pelvis, Rig inRig, float limitedTwist, [Out] SimpleTransform outNeck)
		{
			return default(SimpleTransform);
		}

		protected Quaternion SolveT1ToHands(Rig inRig, SLZ.VRMK.Avatar avatar, SimpleTransform t1World, float suppressTwist = 1f)
		{
			return default(Quaternion);
		}

		protected SimpleTransform SolvePelvis(SLZ.VRMK.Avatar avatar, SimpleTransform chest, float deltaTime, [Out] SimpleTransform spine)
		{
			return default(SimpleTransform);
		}

		protected SimpleTransform SolvePelvis2(SLZ.VRMK.Avatar avatar, SimpleTransform chest, SimpleTransform pelvis, [Out] SimpleTransform spine)
		{
			return default(SimpleTransform);
		}

		protected void SolveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected void AdditiveClavicles(Rig inRig, SLZ.VRMK.Avatar avatar)
		{
		}

		protected ValueTuple<float, float> SolveArmReach(Vector3 axis, float handLocalMag, float armAngleRemap, float armLength, float clavicalLength, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft)
		{
			return default(ValueTuple<float, float>);
		}

		protected ValueTuple<float, float, Vector3> ExtractClavInRom(Vector3 shoulderLocal, Vector3 neutralDir, float fwdDegrees, float backDegrees, float upDegrees, float downDegrees, bool isLeft)
		{
			return default(ValueTuple<float, float, Vector3>);
		}

		protected ValueTuple<Vector3, Vector3> LimitHands(SLZ.VRMK.Avatar avatar, bool twoHanded = false)
		{
			return default(ValueTuple<Vector3, Vector3>);
		}

		private bool HandLimiter(float currentMag, float defaultMag, float minPerc, [Out] float newLimbMag)
		{
			return default(bool);
		}

		protected SimpleTransform SolveFeetCenter(SimpleTransform head, SimpleTransform chest, SimpleTransform pelvis, SimpleTransform handLf, SimpleTransform handRt)
		{
			return default(SimpleTransform);
		}

		protected void ApplyArms(Vector3 elbowLfWorld, Vector3 elbowRtWorld, SLZ.VRMK.Avatar avatar)
		{
		}

		protected void SolveArms(SLZ.VRMK.Avatar avatar, float deltaTime, float elbowWeightLf, Vector3 trackedElbowDirLf, float elbowWeightRt, Vector3 trackedElbowDirRt)
		{
		}

		protected ValueTuple<Vector3, float, float> LimbTrigSolve(Vector3 limbVector3, float upperMag, float lowerMag)
		{
			return default(ValueTuple<Vector3, float, float>);
		}

		private float ElbowIsNot(Quaternion handRot, Vector3 elbowFwd, Vector3 elbowUp, Vector3 wristUp, Vector3 armVectorNormed, Vector3 shoulderDown, Quaternion neutralGlenhumeral, float elbowWeight, Vector3 trackedElbowRt, float deltaTime, Quaternion lastHandRot, float twistFloat, float wristRelaxLerp, float wristRelaxVel)
		{
			return default(float);
		}

		protected void SolveLegs(SimpleTransform footstepLf, SimpleTransform footstepRt, SimpleTransform ankleLf, SimpleTransform ankleRt, Vector3 toeLf, Vector3 toeRt, float offsetLf = 0f, float offsetRt = 0f)
		{
		}

		protected void LimbLimit(float limbMag, float upperLength, float lowerLength, [Out] float newLimbMag)
		{
		}

		public void CalibratePlayerBodyScale(SLZ.VRMK.Avatar avatar)
		{
		}

		protected void ExtractProportions(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ApplyProportions(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose)
		{
		}

		protected void ExtractHandProximity(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, BodyPose bodyPose)
		{
		}

		protected void ApplyHandProximity(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, float twoHanded)
		{
		}

		protected void ExtractTorsoProximity(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, Rig inRig, SLZ.VRMK.Avatar avatar, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, BodyPose bodyPose)
		{
		}

		protected void ApplyTorsoProximity(Quaternion rootRotation, SimpleTransform palmLf, SimpleTransform palmRt, SLZ.VRMK.Avatar avatar, BodyPose bodyPose, Vector3 handLfBoundsPos, Vector3 handLfBoundsNeg, Vector3 handRtBoundsPos, Vector3 handRtBoundsNeg, float twoHanded = 0f)
		{
		}

		protected float GetSixAxisBoundsMag(Vector3 localNormedDirection, Vector3 boundsPositive, Vector3 boundsNegative)
		{
			return default(float);
		}

		protected bool PointInTorso(SimpleTransform pointWorld, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, Vector3 pelFromChestNorm, float pelFromChestMag, SLZ.VRMK.Avatar player, SimpleTransform c1, SimpleTransform sternum, SimpleTransform spine, SimpleTransform pelvis, [Out] float t, [Out] float yPercRemapped, [Out] Vector2 sin, [Out] Quaternion spineRotInWorld, [Out] Vector3 spineInPointNormed)
		{
			return default(bool);
		}

		protected SimpleTransform HandTorsoSpacewarp(SimpleTransform palm, Vector3 pointBoundsPos, Vector3 pointBoundsNeg, SLZ.VRMK.Avatar avatar, SimpleTransform head, SimpleTransform sternum, SimpleTransform spine, SimpleTransform hipCenter, Quaternion spineRot, float yPercRemapped, Vector2 sin, float t, Vector3 spineInPointNormed)
		{
			return default(SimpleTransform);
		}

		public void GenerateBasePose(float skullHeightWeight, BodyPose outPose)
		{
		}

		public void GenerateAdditivePose(BodyPose inPose, BodyPose basePose, BodyPose outPose)
		{
		}

		public HeptaRig()
			: base()
		{
		}
	}
}
