using System;
using UnityEngine;

namespace SLZ.Rig
{
	[Serializable]
	public class BodyPose
	{
		public Quaternion headRotationInRoot;

		public Quaternion chestRotationInRoot;

		public Quaternion spineRotationInRoot;

		public Quaternion pelvisRotationInRoot;

		public Vector3 cervicalDeviationInRoot;

		public Vector3 clavLfDirInRoot;

		public Vector3 clavRtDirInRoot;

		public Vector3 armLfNormInRoot;

		public Vector3 armRtNormInRoot;

		public float armLfExtension;

		public float armRtExtension;

		public Quaternion handLfRotationInRoot;

		public Quaternion handRtRotationInRoot;

		public Vector3 legLfDirInRoot;

		public Vector3 legRtDirInRoot;

		public float legLfExtension;

		public float legRtExtension;

		public Quaternion footLfRotationInRoot;

		public Quaternion footRtRotationInRoot;

		public Vector3 palmRtToLfDirInRoot;

		public float handSeparation;

		public float torsoYHandLf;

		public float torsoTHandLf;

		public Vector2 torsoSinHandLf;

		public Quaternion torsoRotInWorldHandLf;

		public Vector3 spineInPalmLfNormed;

		public float torsoYHandRt;

		public float torsoTHandRt;

		public Vector2 torsoSinHandRt;

		public Quaternion torsoRotInWorldHandRt;

		public Vector3 spineInPalmRtNormed;

		public Vector3 rootTranslation;

		public Quaternion rootRotation;

		public Vector3 headTranslation;
	}
}
