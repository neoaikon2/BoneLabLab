using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class Rig : MonoBehaviour
	{
		public RigManager manager;

		[Header("Rig")]
		public Transform m_head;

		public Transform m_jaw;

		public Transform m_neck;

		public Transform m_chest;

		public Transform m_spine;

		public Transform m_pelvis;

		public Transform m_shoulderLf;

		public Transform m_elbowLf;

		public Transform m_handLf;

		public Transform m_shoulderRt;

		public Transform m_elbowRt;

		public Transform m_handRt;

		public Transform m_hipLf;

		public Transform m_kneeLf;

		public Transform m_footLf;

		public Transform m_hipRt;

		public Transform m_kneeRt;

		public Transform m_footRt;

		public Transform centerOfPressure;

		public Vector4 eyeGaze;

		protected BodyPose _bodyPose;

		[HideInInspector]
		public int rigIndex;

		public BodyPose bodyPose
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Reset()
		{
		}

		public virtual void OnAwake()
		{
		}

		public virtual void OnRigEnable(bool reEnable)
		{
		}

		public virtual void OnStart()
		{
		}

		public virtual void OnEarlyUpdate()
		{
		}

		public virtual void OnFirstFixedUpdate()
		{
		}

		public virtual void OnFixedUpdate(float deltaTime)
		{
		}

		public virtual void OnAfterFixedUpdate()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnLateUpdate()
		{
		}

		public virtual void OnRigDisable()
		{
		}

		public virtual void Teleport(Vector3 displace, bool zeroVelocity = false)
		{
		}

		public virtual void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public Rig GetPreviousRig()
		{
			return null;
		}

		protected Vector3 Gimbal(Vector3 target, ref Vector3 lastTarget, ref Vector3 gimbaledVelocity, ref Vector3 gimbalAccel, ref Vector3 gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return default(Vector3);
		}

		protected float Gimbal(float target, ref float lastTarget, ref float gimbaledVelocity, ref float gimbalAccel, ref float gimbleOffset, float lerpRate, float deltaTime, float maxOffset = float.MaxValue, float smoothTime = 0.1f)
		{
			return 0f;
		}
	}
}
